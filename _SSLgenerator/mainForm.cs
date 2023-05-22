using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _SSLgenerator
{
    public partial class mainForm : Form
    {
        private delegate void SafeCallDelegate(string text);
        public mainForm()
        {
            InitializeComponent();
        }

        string code= "le64.exe --api 2 --key @nameaccount.key --csr @namemydomain.csr --csr-key key.key --crt crt.crt --domains \"@domains\" --generate-missing --handle-as http --live -export-pfx @namepfxpswsifre -email \"@email\"";

        string workingPath = @"";
        string domain = "";

        information info;
        List<information> infoList = new List<information>();
        static string path = Environment.CurrentDirectory + @"\\websites.json";

        public void runProcess()
        {

            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = "/C "+code;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.WorkingDirectory = workingPath;
            process.Start();

            string q = "";
            int counter = 0;
            while (!process.HasExited)
            {
                q = process.StandardError.ReadLine();
                SetText("\n" + q);
                if (q != null)
                {
                    if (q.Contains("A file"))
                    {
                        counter++;
                        string fileName = q.Substring(q.IndexOf("A file '") + 8, ((q.IndexOf("' in") - q.IndexOf("A file '")) - 8));
                        using (FileStream fs = File.Create(workingPath + fileName))
                        {
                            byte[] info = new UTF8Encoding(true).GetBytes(q.Substring(q.IndexOf("text: ") + 6));
                            fs.Write(info, 0, info.Length);
                        }
                        upload(info.ftpUrl,info.ftpUsername,info.ftpPassword,domain, fileName);
                        if (counter == 1)
                        {
                            process.StandardInput.WriteLine();
                            counter++;
                        }
                    }
                }
                if (counter > 2)
                {
                    process.StandardInput.WriteLine();
                    counter = 0;
                }
            }
            SetText("\nCompleted !");
        }
        public void Process_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            Console.WriteLine(e.Data);
            rtxtInfo.Text = (e.ToString());
        }

        private void WriteTextSafe(string text)
        {
            if (rtxtInfo.InvokeRequired)
            {
                var d = new SafeCallDelegate(WriteTextSafe);
                rtxtInfo.Invoke(d, new object[] { text });
            }
            else
            {
                rtxtInfo.Text += text;
                rtxtInfo.Focus();
                rtxtInfo.Select(rtxtInfo.Text.Length, 0);
                rtxtInfo.ScrollToCaret();
            }
        }

        private void SetText(string whatToWrite)
        {
            WriteTextSafe(whatToWrite);
        }

        public void upload(string url, string user, string pass, string domain, string fileName)
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(url+domain);
            request.Credentials = new NetworkCredential(user, pass);
            request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
            FtpWebResponse response = (FtpWebResponse)request.GetResponse();
            StreamReader streamReader = new StreamReader(response.GetResponseStream());
            bool fol1 = false,fol2=false;
            string line = streamReader.ReadLine();
            while (!string.IsNullOrEmpty(line))
            {
                if(line.Contains(".well-known"))
                {
                    fol1 = true;
                    break;
                }
                line = streamReader.ReadLine();
            }
            streamReader.Close();

            request = (FtpWebRequest)WebRequest.Create(url + domain+"/.well-known");
            request.Credentials = new NetworkCredential(user, pass);
            request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;

            response = (FtpWebResponse)request.GetResponse();
            streamReader = new StreamReader(response.GetResponseStream());

            line = streamReader.ReadLine();
            while (!string.IsNullOrEmpty(line))
            {
                if (line.Contains("acme-challenge"))
                {
                    fol2 = true;
                    break;
                }
                line = streamReader.ReadLine();
            }
            streamReader.Close();
            if(!fol1)
            {
                WebRequest wrequest = WebRequest.Create(url+domain+"/.well-known");
                wrequest.Method = WebRequestMethods.Ftp.MakeDirectory;
                wrequest.Credentials = new NetworkCredential(user, pass);
                using (var resp = (FtpWebResponse)wrequest.GetResponse())
                {
                    MessageBox.Show(".well-known was missing and created.");
                }
            }
            if(!fol2)
            {
                WebRequest wrequest = WebRequest.Create(url + domain + "/.well-known/acme-challenge");
                wrequest.Method = WebRequestMethods.Ftp.MakeDirectory;
                wrequest.Credentials = new NetworkCredential(user, pass);
                using (var resp = (FtpWebResponse)wrequest.GetResponse())
                {
                    MessageBox.Show("acme-challenge was missing and created.");
                }
            }

            WebClient client = new WebClient();
            client.Credentials = new NetworkCredential(user, pass);
            client.UploadFile(url + domain + "/.well-known/acme-challenge/" + fileName, workingPath + fileName);
            SetText("\n" + fileName + " uploaded.");
        }

        public void reloadWebsites()
        {
            if (File.Exists(path))
            {
                string text = File.ReadAllText(path);
                infoList = JsonConvert.DeserializeObject<List<information>>(text);

                lstbDelete.Items.Clear();
                cbSelectWebsite.Items.Clear();
                foreach (information item in infoList)
                {
                    cbSelectWebsite.Items.Add(item.name);
                    lstbDelete.Items.Add(item.name);
                }
            }
            else
            {
                File.WriteAllText(path, "");
                MessageBox.Show("Configuration file not found! Re-open the application.");
            }
        }

        public void save()
        {
            string json = JsonConvert.SerializeObject(infoList.ToArray());
            File.WriteAllText(path, json);
            reloadWebsites();
        }

        public bool checkFtpConnection(string url, string user, string pass, string folder)
        {

            bool isexist = false;

            try
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(url+folder);
                request.Credentials = new NetworkCredential(user, pass);
                request.Method = WebRequestMethods.Ftp.ListDirectory;
                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                {
                    isexist = true;
                }
            }
            catch (WebException ex)
            {
                if (ex.Response != null)
                {
                    FtpWebResponse response = (FtpWebResponse)ex.Response;
                    if (response.StatusCode == FtpStatusCode.ActionNotTakenFileUnavailable)
                    {
                        return false;
                    }
                }
            }
            return isexist;
        }

        public void cleanBoxes()
        {
            txtSiteName.Clear();
            txtWebsites.Clear();
            txtEmail.Clear();
            txtFtpUrl.Clear();
            txtFtpUser.Clear();
            txtFtpPass.Clear();
        }

        private void btnAddWebsite_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != "" && txtSiteName.Text != "" && txtWebsites.Text != "" && txtFtpUrl.Text != "" && txtFtpUser.Text != "" && txtFtpPass.Text != "")
            {
                if (!(txtEmail.Text.Contains(" ")) && !(txtSiteName.Text.Contains(" ")) && !(txtWebsites.Text.Contains(" ")) && !(txtFtpUrl.Text.Contains(" ")) && !(txtFtpUser.Text.Contains(" ")) && !(txtFtpPass.Text.Contains(" ")))
                {
                    if (infoList.Find(x => x.name == txtSiteName.Text) == null)
                    {
                        infoList.Add(new information()
                        {
                            name = txtSiteName.Text,
                            website = txtWebsites.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None).ToList(),
                            email = txtEmail.Text,
                            ftpUrl=txtFtpUrl.Text,
                            ftpUsername=txtFtpUser.Text,
                            ftpPassword=txtFtpPass.Text

                        });
                        save();
                        cleanBoxes();
                    }
                    else
                    {
                        MessageBox.Show("Name exists give it another name!");
                    }
                }
                else
                {
                    MessageBox.Show("Do not use [space]s");
                }
            }
            else
            {
                MessageBox.Show("Do not leave it empty");
            }
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            this.Width = 390;
            reloadWebsites();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(lstbDelete.SelectedIndex>=0)
            {
                if (MessageBox.Show(lstbDelete.SelectedItem+" Will be deleted are you sure?","Confirm Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    infoList.RemoveAt(infoList.FindIndex(x => x.name == lstbDelete.SelectedItem.ToString()));
                    save();//
                }
            }
            else
            {
                MessageBox.Show("Select something to delete first!");
            }
        }

        private void btnCheckFtp_Click(object sender, EventArgs e)
        {
            if(checkFtpConnection(txtFtpUrl.Text,txtFtpUser.Text,txtFtpPass.Text,txtWebsites.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None)[0]))
            {
                MessageBox.Show("Success");
            }
            else
            {
                MessageBox.Show("Failed to connect!");
            }
        }

        private void btnGetPrevious_Click(object sender, EventArgs e)
        {
            if(infoList.Count>0)
            {
                txtFtpUrl.Text = infoList[infoList.Count - 1].ftpUrl;
                txtFtpUser.Text = infoList[infoList.Count - 1].ftpUsername;
                txtFtpPass.Text = infoList[infoList.Count - 1].ftpPassword;
            }
            else
            {
                MessageBox.Show("There is no record!");
            }
        }

        private void checkGhostText(TextBox txt)
        {
            
            if (txt.Text.Contains("Ex: "))
            {
                txt.Clear();
            }
        }

        private void txtSiteName_Enter(object sender, EventArgs e)
        {
            checkGhostText(txtSiteName);
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            checkGhostText(txtEmail);
        }

        private void txtFtpUrl_Enter(object sender, EventArgs e)
        {
            checkGhostText(txtFtpUrl);
        }

        private void txtFtpUser_Enter(object sender, EventArgs e)
        {
            checkGhostText(txtFtpUser);
        }

        private void txtFtpPass_Enter(object sender, EventArgs e)
        {
            checkGhostText(txtFtpPass);
        }

        private void txtWebsites_Enter(object sender, EventArgs e)
        {
            checkGhostText(txtWebsites);
        }

        private async void btnGenerate_Click(object sender, EventArgs e)
        {
            if (cbSelectWebsite.SelectedIndex >= 0)
            {
                string domains = "";
                foreach (string item in info.website)
                {
                    domains += item + ",";
                }
                domains = domains.Substring(0, domains.Length - 1);
                code = code.Replace("@name", info.name).Replace("@email", info.email).Replace("@domains", domains);
                MessageBox.Show(code);
                if(!(File.Exists(workingPath+"\\le64.exe")))
                {
                    File.Copy(Environment.CurrentDirectory + "\\le64.exe", workingPath + "\\le64.exe");
                }
                await Task.Run(() => runProcess());
                string crt = File.ReadAllText(workingPath + @"\crt.crt").ToString();
                string key = File.ReadAllText(workingPath + @"\key.key").ToString();
                lstbInfo.Items.Add(crt.Substring(0, crt.IndexOf("-----END CERTIFICATE-----") + 25));
                lstbInfo.Items.Add(key);
            }
            else
            {
                MessageBox.Show("Select a website from list above!");
            }
        }

        private void lstbInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clipboard.SetText(lstbInfo.SelectedItem.ToString());
        }

        private void cbSelectWebsite_SelectedIndexChanged(object sender, EventArgs e)
        {
            info = infoList.Find(x => x.name == cbSelectWebsite.SelectedItem.ToString());
            workingPath = Environment.CurrentDirectory + @"\" + info.name;
            if(!(Directory.Exists(workingPath)))
            {
                Directory.CreateDirectory(workingPath);
            }
            domain = info.website[0];
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            while(this.Width< 695)
            {
                this.Width++;
            }
            gbAddNew.Visible = true;
            gbDelete.Visible = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            while(this.Width> 390)
            {
                this.Width--;
            }
            gbAddNew.Visible = false;
            gbDelete.Visible = false;
        }
    }
}
