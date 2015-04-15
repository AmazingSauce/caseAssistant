using System;
using System.Windows.Forms;
// to use Missing.Value
using Outlook = Microsoft.Office.Interop.Outlook;
// to use Menu and Toolbars
using System.IO; // needed for the signature email to be grabbed
using System.Text;//for grabbbing signature for email
//needed to convert signature from html



namespace closing_email_templete
{
    public partial class HowToOrderPart : Form
    {
        public HowToOrderPart()
        {
            InitializeComponent();
        }

        private void lblCustomerName_Click(object sender, EventArgs e)
        {

        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
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






        private void button1_Click(object sender, EventArgs e)
        {

            DateTime currentDate = DateTime.Now;

            string emailSubject = "SR#" + txtSRNumber.Text + "/ " + txtCompanyname.Text + " ";
            string displayMessage = "Hi " + txtCustomerName.Text + ",\nIf the part is showing faulted in unisphere under system>system health you can order this part by following the instructions below.\n\n the below steps can be found by going to support.emc.com and selecting support by product.\n\nYou can then search the product and find documents and knowledge articles for replacing parts and ordering parts\n\nFor ordering parts you can go to https://emc--c.na5.visual.force.com/apex/KB_HowTo?id=kA0700000004JHV\n\n Most parts are next business day depending on contract and availability.\n\nAfter the part has been ordered you should receive an email giving you the tracking information, if you have not received that email a couple hours after you ordered the part please feel free to call 1-800-782-4362 and reference the new SR# that the order created to request tracking information.\n\nA hardware component in your storage system has faulted. To restore full operation of your system, you must replace the faulted hardware component.  If a disk has faulted, the disk should be replaced immediately.\n\nIn Unisphere, go to System > System Health page to identify the faulted component.(The VNXe online Help has detailed instructions on how to identify the part, order, replace, and return a defective part. See the VNXe Replace a faulted hardware component online help topic.)\n\nCable part numbers can be found on the label attached to each cable.\n\nTo order replacement parts, in Unisphere, click Support > Need More Help? > Customer Replaceable Parts > Order a Customer Replaceable Part.\n\nYou can also go to support.emc.com and select service center, and then select Order a part replacement.\n\nIf you have troubles getting the part ordered please feel free to let me know and I can get the part ordered for you.\n\nI would need the correct shipping address and the part number of the faulted part to do that.\n\nThank you very much " + txtCustomerName.Text + "\n\nHave a good day!";


            Outlook.Application outlookApp = new Outlook.Application();
            Outlook._MailItem mailItem = (Outlook._MailItem)outlookApp.CreateItem(Outlook.OlItemType.olMailItem);
            mailItem.To = txtEmailAddress.Text;
            mailItem.Subject = emailSubject;
            mailItem.Body = displayMessage + "\n\n " + ReadSignature(); 
            mailItem.Display(true);

            string copiedToClipboard = txtEmailAddress.Text + "\n\n" + emailSubject + "\n\n" + displayMessage;

            string kbArticle = "000014376 ";

            Clipboard.SetText("Email sent at \n" + currentDate.ToString("H:mm:ss") + "        " + currentDate.ToString("M/dd/yyyy") + "\n***********************************************\n\n" + copiedToClipboard);
    
            MessageBox.Show("Email order part template has been compied to your clipboard:\n\n***********************************************\n\n" + "Email sent at \n" + currentDate.ToString("H:mm:ss") + "        " + currentDate.ToString("M/dd/yyyy") + "\n***********************************************\n\n" + txtEmailAddress.Text + "\n\n" + emailSubject + "\n\n" + displayMessage);

            Clipboard.SetText(kbArticle);

            MessageBox.Show("KbArticle to attach to your service reqeust has been saved to your clipboard" + kbArticle);

            txtCustomerName.Text = null;
            txtEmailAddress.Text = null;
            emailSubject = null;
            txtSRNumber.Text = null;
            txtCompanyname.Text = null;

            


        }

        private void HowToOrderPart_Load(object sender, EventArgs e)
        {

        }
    }
}
