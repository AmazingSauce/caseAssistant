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
    public partial class BreakFixIssuesCompleted : Form
    {
        public BreakFixIssuesCompleted()
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

        private void btnDisplayTemplate_Click(object sender, EventArgs e)
        {


            DateTime currentDate = DateTime.Now;

            string displayMessage = "Hi " + txtCustomerName.Text + "\nThe majority of this information is covered in the documentation I provided. Please understand that I am limited in the amount of configuration support I may provide, as I am in the break/fix department. We do have EMC Guru Live and Professional services available to customers who seek configuration support. You can obtain this service by contacting your DSM " + txtDSMName.Text + "\n\nI hope the support I have provided has been beneficaial and helpful; however, without an error code or evidence of something not functioning properly; I am afraid this is the limit of configuration support that I can provide. For additional help with configuration I recommend discussing Guru Live or professional services options with your DSM.\n\n If there are any break fix issues that I can assist with please let me know.\n\nThank you very much and have a great day!";
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




            //set all fields in the Form to blank again
            txtCustomerName.Text = " ";
            txtSRNumber.Text = " ";
            txtEmailAddress.Text = " ";
            txtCompanyname.Text = " ";
            txtDSMName.Text = " ";



            return;


        }

        private void BreakFixIssuesCompleted_Load(object sender, EventArgs e)
        {

        }
    }
}
