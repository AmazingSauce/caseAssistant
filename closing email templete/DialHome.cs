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
    public partial class DialHome : Form
    {
        public DialHome()
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

        


        private void DialHome_Load(object sender, EventArgs e)
        {


        }

        private void btnGatherNewLogs_Click(object sender, EventArgs e)
        {

            DateTime currentDate = DateTime.Now;

            string displayMessage = "Hi " + txtCustomerName.Text + ",\n" + "Greetings from EMC Technical Support, I am contacting you in relation to SR# " + txtSRNumber.Text + ".  A dial home notification was received from VNXe Serial: " + txtSerialNumber.Text + "  with the following symptom code:" + txtSymptomcode.Text + "showing as a faulted: " + txtFaultedPart.Text + "\n\nI have taken ownership of this case and will be investigating this issue for you. I would like to start by verifying the fault. If you could log in to the Unisphere, go to system > system health and highlight the part that is showing to be faulted and take a screen shot for me please. If this is not acceptable we can set up a WebEx session and I can gather the information I need during the session.\n\nPlease either send me the screen shot or the time that would be best for you for a WebEx session and I will do my best to resolve this for you as quickly as possible\n\nIf the part is showing faulted in unisphere under system>system health you can order this part by following the instructions below.\n\nAll parts on the VNXe are NBD.\n\nAfter the part has been ordered you should receive an email giving you the tracking information, if you have not received that email a couple hours after you ordered the part please feel free to call 1-800-782-4362 and reference the new SR# that the order created to request tracking informationt.\n\nA hardware component in your storage system has faulted. To restore full operation of your system, you must replace the faulted hardware component.  If a disk has faulted, the disk should be replaced immediately.\n\nIn Unisphere, go to System > System Health page to identify the faulted component.(The VNXe online Help has detailed instructions on how to identify the part, order, replace, and return a defective part. See the VNXe Replace a faulted hardware component online help topic.)\n\nCable part numbers can be found on the label attached to each cable.\n\nTo order replacement parts, in Unisphere, click Support > Need More Help? > Customer Replaceable Parts > Order a Customer Replaceable Part.\n\nYou can also go to support.emc.com and select service center, and then select Order a part replacement.\n\nIf you have troubles getting the part ordered please feel free to let me know and I can get the part ordered for you.\n\nI would need the correct shipping address and the part number of the faulted part to do that.\n\nThank you very much " + txtCustomerName.Text + "\n\nHave a good day!";

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

            string kbArticle = "000014376";

            Clipboard.SetText(kbArticle);

            MessageBox.Show("KbArticle to attach to your service reqeust has been saved to your clipboard" + kbArticle);





            //set all fields in the Form to blank again
            txtCustomerName.Text = " ";
            txtSRNumber.Text = " ";
            txtEmailAddress.Text = " ";
            txtCompanyname.Text = " ";
            txtSerialNumber.Text = " ";
            txtSymptomcode.Text = " ";
            txtAgentName.Text = " ";

        }
    }
}
