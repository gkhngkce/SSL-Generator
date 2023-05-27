# SSL Generator

Before start if you have any question or problem about this project do not hasitate to ask it to me.

This project for who is suffering from hosting brands who does not let you automate SSL certifications with certbot. I am using a hosting brand called Natro in Turkey. The do not allow people to automate certificate using certbot. So I decided automate it by myself. Project allow you to save your website information to automatize nearly everyting. You just copy certificate code to the SSL management panel.

## Getting Started

This program basically runs le64 code in your local machine to create certificate. As verification it uploads files to .well-known/acme-challenge folder in your hosting. After validation it creates certificate and private key files for you to copy. You can do it manually by yourself using [le64.exe](https://github.com/do-know/Crypt-LE) with the code below. But you need to upload files manually then confirm it then copy the certification codes etc. For one website may be it is ok to do unfortunatelly i have around 10 websites that i renew every 3 month that is not the case for me.

You can run this code with using le64 by yourself for free SSL from Let's Encrypt to create your own. Do not forget to change parameters in the brackets [ ]
```
le64.exe --api 2 --key [nameaccount].key --csr [namemydomain].csr --csr-key key.key --crt crt.crt --domains "[domains splitted by ,(comma)]" --generate-missing --handle-as http --live -export-pfx  [namepfxpswsifre] -email "[email]"
```

### Prerequisites

Project written with C# .Net Framework so you need .Net Framework 4.5.2 or higher

### Installing

You can download executables from [Releases](https://github.com/gkhngkce/SSL-Generator/releases).

## Running

Unzip Debug file and just run _SSLgenerator.exe

##Additionally
Just fill your informations to add new website

![image](https://github.com/gkhngkce/SSL-Generator/assets/20401028/a2f99f56-4e5b-41c4-8930-06732e381614)

Select your website to create certificate then click Generate Certificate

![image](https://github.com/gkhngkce/SSL-Generator/assets/20401028/26c85635-9d9d-4cd7-8d7b-096d279121b3)

le64 will progress rest of the steps for you and your certificate is ready to copy. You can double click to copy.

![image](https://github.com/gkhngkce/SSL-Generator/assets/20401028/20103cfd-89af-4d25-a363-c86edb81abd0)

After that you can go to your cPanel > SSL/TLS > Manage SSL Certificates> Select Your Domain

![Screenshot_4](https://github.com/gkhngkce/SSL-Generator/assets/20401028/64775765-3e20-4747-91c7-fb72dca96663)

Thats it.
You need to run it every 3 months to renew the certificate. You can check the website that i used for this project to check details of the certificate.
