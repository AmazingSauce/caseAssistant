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
    public partial class SPPanic : Form
    {
        public SPPanic()
        {
            InitializeComponent();
        }

        private void SPPanic_Load(object sender, EventArgs e)
        {

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


            string displayMessage = "Hello " + txtCustomerName.Text + ",\nMy Name is " + txtTechnicianName.Text + " from EMC and I am responding to service request SR#" + txtSRNumber.Text + ".\n\nThe message you received on your VNXe: servers configured for SPX have stopped and will be restarted, is indicative of an SP or DART panic which in older versions of the code can be attributed to a few bugs and memory leaks that have been discovered, and consequently corrected in the latest version of code.\n\nIf you are not on the current version I recommend an upgrade as soon as possible. If you are on the current version I will need to gather service logs to be analyzed to determine cause and produce a resolution.\n\nPlease let me know if you have any questions; or if your current version of code is on the latest, we can schedule a good time to have a webex session for further investigation if needed.\n\nThank you very much\n\nhave a great day!";
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
            txtTechnicianName.Text = " ";



            return;



        }
    }
}
