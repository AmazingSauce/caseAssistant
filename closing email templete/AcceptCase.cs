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
    public partial class AcceptCase : Form
    {
        public AcceptCase()
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



        private void btnAcceptCase_Click(object sender, EventArgs e)
        {


            DateTime currentDate = DateTime.Now;

            string displayMessage = "Hi " + txtCustomerName.Text + ",\n" + "Greetings from EMC technical support my name is " + txtAgentName.Text + " and I have accepted the SR#" + txtSRNumber.Text + " and will be assisting you with this issue. Please let me know when you will be available to discuss and work on the VNXe in order to quickly resolve the service request.";
            string emailSubject = "SR#" + txtSRNumber.Text + "/ " + txtCompanyname.Text + " ";



            Outlook.Application outlookApp = new Outlook.Application();
            Outlook._MailItem mailItem = (Outlook._MailItem)outlookApp.CreateItem(Outlook.OlItemType.olMailItem);
            mailItem.To = txtEmailAddress.Text;
            mailItem.Subject = emailSubject;
            mailItem.Body = displayMessage + "\n\n " + ReadSignature(); // ReadSignature() this will place signature in the body               
            mailItem.Display(true);



            Clipboard.SetText("Email sent at \n" + currentDate.ToString("H:mm:ss") + "        " + currentDate.ToString("M/dd/yyyy") + "\n***********************************************\n\n" + displayMessage); //this sets the clipboard to exactly what is in that string

            string emailTemplateCopiedToClipBoard = "Your email message has been copied to your clipboard so you can add it to your notes\n***********************************************\n\n"+ "Email sent at \n" + currentDate.ToString("H:mm:ss") + "        " + currentDate.ToString("M/dd/yyyy") +"\n***********************************************\n\n"  + displayMessage;

            MessageBox.Show(emailTemplateCopiedToClipBoard);







            //set all fields in the Form to blank again
            txtCustomerName.Text = " ";
            txtSRNumber.Text = " ";
            txtEmailAddress.Text = " ";
            txtCompanyname.Text = " ";
            txtAgentName.Text = " ";








        }

        private void AcceptCase_Load(object sender, EventArgs e)
        {

        }
    }
}
