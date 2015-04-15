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
    public partial class GatherNewLogs : Form
    {
        public GatherNewLogs()
        {
            InitializeComponent();
        }



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

        



        private void btnGatherNewLogs_Click(object sender, EventArgs e)
        {

            DateTime currentDate = DateTime.Now;

            string displayMessage = "Hi " + txtCustomerName.Text + ",\n" + "Here is the procedure to collect the logs from Unisphere. \n\nThis can also be found at support.emc.com by going to support by product and choosing the product\n\nlist of different products and how to gather logs can be found here https://emc--c.na5.visual.force.com/apex/KB_BreakFix_1?id=kA1700000000Pr8 \n\nHow to gather logs on the VNXe can be found here https://emc--c.na5.visual.force.com/apex/KB_HowTo?id=kA0700000004Iw8 \n\n\t1.Click Settings > Service System. \n\t2.Enter the Service password to access the Service System page. \n\t3.Under System Components, select Storage System. \n\t4.Under Service Actions, select Collect service information. \n\t5.Click Execute service action. (Choose option No to gather new set of logs) \n\t6.Wait up to 10 minutes for the data collection to complete. \n\t7.In the VNXe Service Data dialog box, click yes to download the collected data file. \n\t8 Select a location to save the file, such as your desktop or an external storage location. \n\t8.Click Save to start downloading the file. \n\t10.Once logs file is downloaded, please navigate to service request on support.emc.com then select view and manage my service request\n\t11. you can then select SR#" + txtSRNumber.Text + "\n\t12. at the top of the screen there will be a paperclip that you can upload the logs to Service Request.\n\nLet me know if you have troubles uploading the logs or if you need any assistance\n\nPlease let me know what code version you are on and when the logs have been uploaded\n\nThank you very much " + txtCustomerName.Text + "\n\nHave a good day!";
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

            string kbArticle = "000013051 ";

            Clipboard.SetText(kbArticle);

            MessageBox.Show("KB article 000013051 has been copied to your clipboard, this is for gathering logs on the VNXe");

            //set all fields in the Form to blank again
            txtCustomerName.Text = " ";
            txtSRNumber.Text = " ";
            txtEmailAddress.Text = " ";
            txtCompanyname.Text = " ";
            txtAgentName.Text = " ";

        }

        private void GatherNewLogs_Load(object sender, EventArgs e)
        {

        } 
               

    }
}
