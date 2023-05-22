namespace _SSLgenerator
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cbSelectWebsite = new System.Windows.Forms.ComboBox();
            this.lstbInfo = new System.Windows.Forms.ListBox();
            this.rtxtInfo = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSiteName = new System.Windows.Forms.TextBox();
            this.txtWebsites = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddWebsite = new System.Windows.Forms.Button();
            this.gbAddNew = new System.Windows.Forms.GroupBox();
            this.btnGetPrevious = new System.Windows.Forms.Button();
            this.btnCheckFtp = new System.Windows.Forms.Button();
            this.txtFtpPass = new System.Windows.Forms.TextBox();
            this.txtFtpUser = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFtpUrl = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gbDelete = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lstbDelete = new System.Windows.Forms.ListBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.gbAddNew.SuspendLayout();
            this.gbDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Website";
            // 
            // cbSelectWebsite
            // 
            this.cbSelectWebsite.FormattingEnabled = true;
            this.cbSelectWebsite.Location = new System.Drawing.Point(61, 12);
            this.cbSelectWebsite.Name = "cbSelectWebsite";
            this.cbSelectWebsite.Size = new System.Drawing.Size(277, 21);
            this.cbSelectWebsite.TabIndex = 0;
            this.cbSelectWebsite.Text = "Select a Website to Generate SSL";
            this.cbSelectWebsite.SelectedIndexChanged += new System.EventHandler(this.cbSelectWebsite_SelectedIndexChanged);
            // 
            // lstbInfo
            // 
            this.lstbInfo.FormattingEnabled = true;
            this.lstbInfo.Location = new System.Drawing.Point(12, 327);
            this.lstbInfo.Name = "lstbInfo";
            this.lstbInfo.Size = new System.Drawing.Size(326, 199);
            this.lstbInfo.TabIndex = 6;
            this.lstbInfo.SelectedIndexChanged += new System.EventHandler(this.lstbInfo_SelectedIndexChanged);
            // 
            // rtxtInfo
            // 
            this.rtxtInfo.Location = new System.Drawing.Point(12, 81);
            this.rtxtInfo.Name = "rtxtInfo";
            this.rtxtInfo.Size = new System.Drawing.Size(326, 213);
            this.rtxtInfo.TabIndex = 5;
            this.rtxtInfo.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Process";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Certificate Info(Double Click to Copy)";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(12, 39);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(326, 23);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Generate Certificate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(344, 12);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(23, 514);
            this.btnAddNew.TabIndex = 11;
            this.btnAddNew.Text = ">> ADD NEW >>";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Name :";
            // 
            // txtSiteName
            // 
            this.txtSiteName.Location = new System.Drawing.Point(51, 19);
            this.txtSiteName.Name = "txtSiteName";
            this.txtSiteName.Size = new System.Drawing.Size(200, 20);
            this.txtSiteName.TabIndex = 13;
            this.txtSiteName.Text = "Ex: Facebook";
            this.txtSiteName.Enter += new System.EventHandler(this.txtSiteName_Enter);
            // 
            // txtWebsites
            // 
            this.txtWebsites.Location = new System.Drawing.Point(67, 176);
            this.txtWebsites.Multiline = true;
            this.txtWebsites.Name = "txtWebsites";
            this.txtWebsites.Size = new System.Drawing.Size(184, 113);
            this.txtWebsites.TabIndex = 19;
            this.txtWebsites.Text = "Ex: facebook.com\r\nwww.facebook.com";
            this.txtWebsites.Enter += new System.EventHandler(this.txtWebsites_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Websites :";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(51, 45);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 20);
            this.txtEmail.TabIndex = 14;
            this.txtEmail.Text = "Ex: mark@facebook.com";
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "E-mail:";
            // 
            // btnAddWebsite
            // 
            this.btnAddWebsite.Location = new System.Drawing.Point(114, 295);
            this.btnAddWebsite.Name = "btnAddWebsite";
            this.btnAddWebsite.Size = new System.Drawing.Size(137, 23);
            this.btnAddWebsite.TabIndex = 21;
            this.btnAddWebsite.Text = "Add Website";
            this.btnAddWebsite.UseVisualStyleBackColor = true;
            this.btnAddWebsite.Click += new System.EventHandler(this.btnAddWebsite_Click);
            // 
            // gbAddNew
            // 
            this.gbAddNew.Controls.Add(this.btnGetPrevious);
            this.gbAddNew.Controls.Add(this.btnCheckFtp);
            this.gbAddNew.Controls.Add(this.txtSiteName);
            this.gbAddNew.Controls.Add(this.btnAddWebsite);
            this.gbAddNew.Controls.Add(this.label4);
            this.gbAddNew.Controls.Add(this.txtFtpPass);
            this.gbAddNew.Controls.Add(this.txtFtpUser);
            this.gbAddNew.Controls.Add(this.label9);
            this.gbAddNew.Controls.Add(this.txtFtpUrl);
            this.gbAddNew.Controls.Add(this.label8);
            this.gbAddNew.Controls.Add(this.txtEmail);
            this.gbAddNew.Controls.Add(this.label7);
            this.gbAddNew.Controls.Add(this.label5);
            this.gbAddNew.Controls.Add(this.label6);
            this.gbAddNew.Controls.Add(this.txtWebsites);
            this.gbAddNew.Location = new System.Drawing.Point(384, 15);
            this.gbAddNew.Name = "gbAddNew";
            this.gbAddNew.Size = new System.Drawing.Size(257, 324);
            this.gbAddNew.TabIndex = 19;
            this.gbAddNew.TabStop = false;
            this.gbAddNew.Text = "Add New Website";
            this.gbAddNew.Visible = false;
            // 
            // btnGetPrevious
            // 
            this.btnGetPrevious.Location = new System.Drawing.Point(7, 71);
            this.btnGetPrevious.Name = "btnGetPrevious";
            this.btnGetPrevious.Size = new System.Drawing.Size(244, 23);
            this.btnGetPrevious.TabIndex = 15;
            this.btnGetPrevious.Text = "Get Ftp Info From Previous Record";
            this.btnGetPrevious.UseVisualStyleBackColor = true;
            this.btnGetPrevious.Click += new System.EventHandler(this.btnGetPrevious_Click);
            // 
            // btnCheckFtp
            // 
            this.btnCheckFtp.Location = new System.Drawing.Point(6, 295);
            this.btnCheckFtp.Name = "btnCheckFtp";
            this.btnCheckFtp.Size = new System.Drawing.Size(102, 23);
            this.btnCheckFtp.TabIndex = 20;
            this.btnCheckFtp.Text = "Check Ftp";
            this.btnCheckFtp.UseVisualStyleBackColor = true;
            this.btnCheckFtp.Click += new System.EventHandler(this.btnCheckFtp_Click);
            // 
            // txtFtpPass
            // 
            this.txtFtpPass.Location = new System.Drawing.Point(51, 150);
            this.txtFtpPass.Name = "txtFtpPass";
            this.txtFtpPass.PasswordChar = '*';
            this.txtFtpPass.Size = new System.Drawing.Size(200, 20);
            this.txtFtpPass.TabIndex = 18;
            this.txtFtpPass.Text = "Ex: 123456";
            this.txtFtpPass.Enter += new System.EventHandler(this.txtFtpPass_Enter);
            // 
            // txtFtpUser
            // 
            this.txtFtpUser.Location = new System.Drawing.Point(51, 124);
            this.txtFtpUser.Name = "txtFtpUser";
            this.txtFtpUser.Size = new System.Drawing.Size(200, 20);
            this.txtFtpUser.TabIndex = 17;
            this.txtFtpUser.Text = "Ex: admin@facebook.com";
            this.txtFtpUser.Enter += new System.EventHandler(this.txtFtpUser_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Pass :";
            // 
            // txtFtpUrl
            // 
            this.txtFtpUrl.Location = new System.Drawing.Point(51, 98);
            this.txtFtpUrl.Name = "txtFtpUrl";
            this.txtFtpUrl.Size = new System.Drawing.Size(200, 20);
            this.txtFtpUrl.TabIndex = 16;
            this.txtFtpUrl.Text = "Ex: ftp://ftp.facebook.com/";
            this.txtFtpUrl.Enter += new System.EventHandler(this.txtFtpUrl_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "User :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Ftp Url :";
            // 
            // gbDelete
            // 
            this.gbDelete.Controls.Add(this.btnDelete);
            this.gbDelete.Controls.Add(this.lstbDelete);
            this.gbDelete.Location = new System.Drawing.Point(384, 345);
            this.gbDelete.Name = "gbDelete";
            this.gbDelete.Size = new System.Drawing.Size(257, 183);
            this.gbDelete.TabIndex = 20;
            this.gbDelete.TabStop = false;
            this.gbDelete.Text = "Delete Website";
            this.gbDelete.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(7, 146);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(244, 23);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Delete Website";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lstbDelete
            // 
            this.lstbDelete.FormattingEnabled = true;
            this.lstbDelete.Location = new System.Drawing.Point(7, 19);
            this.lstbDelete.Name = "lstbDelete";
            this.lstbDelete.Size = new System.Drawing.Size(244, 121);
            this.lstbDelete.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(647, 15);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(23, 514);
            this.btnBack.TabIndex = 22;
            this.btnBack.Text = "<< BACK <<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 540);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gbDelete);
            this.Controls.Add(this.gbAddNew);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstbInfo);
            this.Controls.Add(this.rtxtInfo);
            this.Controls.Add(this.cbSelectWebsite);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SSL Certificate Generator";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.gbAddNew.ResumeLayout(false);
            this.gbAddNew.PerformLayout();
            this.gbDelete.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSelectWebsite;
        private System.Windows.Forms.ListBox lstbInfo;
        private System.Windows.Forms.RichTextBox rtxtInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSiteName;
        private System.Windows.Forms.TextBox txtWebsites;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddWebsite;
        private System.Windows.Forms.GroupBox gbAddNew;
        private System.Windows.Forms.GroupBox gbDelete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListBox lstbDelete;
        private System.Windows.Forms.TextBox txtFtpPass;
        private System.Windows.Forms.TextBox txtFtpUser;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFtpUrl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCheckFtp;
        private System.Windows.Forms.Button btnGetPrevious;
        private System.Windows.Forms.Button btnBack;
    }
}

