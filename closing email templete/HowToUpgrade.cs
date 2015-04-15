using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;
using System.IO; // needed for the signature email to be grabbed

namespace closing_email_templete
{
    public partial class HowToUpgrade : Form
    {
        public HowToUpgrade()
        {
            InitializeComponent();
        }


        //THis should allow the program to grab the users default signature from outlook and place it in the email template, this is getting the signature in HTML need to find out how to convert it.
        private string ReadSignature()
        {
            string appDataDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Microsoft\\Signatures";
            string signature = string.Empty;
            DirectoryInfo diInfo = new DirectoryInfo(appDataDir);
            if (diInfo.Exists)
            {
                FileInfo[] fiSignature = diInfo.GetFiles("*.txt");
                if (fiSignature.Length > 0)
                {
                    StreamReader sr = new StreamReader(fiSignature[0].FullName, Encoding.Default);
                    signature = sr.ReadToEnd();

                    if (!string.IsNullOrEmpty(signature))
                    {
                        string fileName = fiSignature[0].Name.Replace(fiSignature[0].Extension, string.Empty);
                        signature = signature.Replace(fileName + "_files/", appDataDir + "/" + fileName + "_files/");
                    }
                }
            }

            return signature;
        }

        private void HowToUpgrade_Load(object sender, EventArgs e)
        {

        }

        private void btnDisplayTemplate_Click(object sender, EventArgs e)
        {

            DateTime currentDate = DateTime.Now;


            string displayMessage = "Hello " + txtCustomerName.Text + ",\nI understand you are planning on upgrading the operating environment on your VNXe. I will provide you with all of the information and recommendations I possess to ensure a successful upgrade. If you would like to see all of the release notes between version and the current version you can visit https://support.emc.com/search/?text=VNXe%20release%20notes&product_id=8864&resource=DOC_LIB. Please note that if you are on any version prior to 2.1.0.14097 you will need to upgrade to 2.1.0.14097 prior to upgrading to the latest version, Also, if you are on any version prior to 2.4.0 you will need to upgrade to 2.4.1 prior to upgrading to the latest version.\n\nAlthough, failover will occur during an upgrade, any virtual machines you may have should remain connected; we have seen problems arise where virtual machines can become disconnected or loss of other connections if your high availability is not set up or set up properly. It is with that in mind that I recommend doing this during a maintenance window and shutting down all virtual machines prior to installing the upgrade. If this is not possible ensure that all timeout values are set to greater than or equal to 600 seconds, and power off all non-vital VM’s. I also recommend doing the health check from the upgrade screen prior to the upgrade.\n\nWe have seen a problem where the candidate version will not upload. This is due to the SSD being too full. You can mitigate this particular problem by running a command from the CLI. The steps to do this are as follows:\n\t1. Enable SSH; To do this in Unisphere navigate to Settings > Service System and then click enable SSH and then Execute service action.\n\t2. Login through putty as service (password should be the same as Unisphere password).\n\t3. Run the command svc_clean_ssd  -c this will remove redundant or unnecessary files from the SSD.\n\nYou can follow the steps below to start the upgrade processes\n\t1. In Unisphere navigate to settings> More configuration> Update software.\n\t2. From here you can obtain candidate version online where you can download the latest code version.\n\t3. upload candidate version after downloading from the support site\n\t4. After the upgrade has been uploaded you can then install the candidate version.\n\nThe upgrade will take approximately 2 hours to complete, and you will notice that the progress bar may remain at 50% and 77% for lengthy periods of time, this is normal. If you receive an error at any time during the process; or if your upgrade takes more than three hours to complete please contact me for assistance. If I am not available or offshift please feel free to contact customer services by calling 1-800-782-4362.\n\nPlease let me know if you have any questions.\n\nThank you very much " + txtCustomerName.Text + "\n\nHave a wonderful day!";
            string emailSubject = "SR#" + txtSRNumber.Text + "/ " + txtCompanyname.Text + " ";






            Outlook.Application outlookApp = new Outlook.Application();
            Outlook._MailItem mailItem = (Outlook._MailItem)outlookApp.CreateItem(Outlook.OlItemType.olMailItem);
            mailItem.To = txtEmailAddress.Text;
            mailItem.Subject = emailSubject;
            mailItem.Body = displayMessage + "\n\n " + ReadSignature(); // ReadSignature() this will place signature in the body               
            mailItem.Display(true);



            Clipboard.SetText("Email sent at \n" + currentDate.ToString("H:mm:ss") + "        " + currentDate.ToString("M/dd/yyyy") + "\n***********************************************\n\n" + displayMessage); //this sets the clipboard to exactly what is in that string

            string emailTemplateCopiedToClipBoard = "Your email message has been copied to your clipboard so you can add it to your notes\n***********************************************\n\n" + "Email sent at \n" + currentDate.ToString("H:mm:ss") + "        " + currentDate.ToString("M/dd/yyyy") + "\n***********************************************\n\n" + displayMessage;

            MessageBox.Show(emailTemplateCopiedToClipBoard);

            Clipboard.SetText("000175632");

            MessageBox.Show("Knowledge article for doing an updgrade that can be linked to your service request is 000175632 \nhttps://emc--c.na5.visual.force.com/apex/KB_HowTo?id=kA0700000004Qwx\n\n000175632 has been copied to your clipboard ");

           


            //set all fields in the Form to blank again
            txtCustomerName.Text = " ";
            txtSRNumber.Text = " ";
            txtEmailAddress.Text = " ";
            txtCompanyname.Text = " ";




            return;



        }
    }
}
