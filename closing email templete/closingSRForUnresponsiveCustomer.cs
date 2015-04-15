using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;


namespace closing_email_templete
{
    public partial class closingSRForUnresponsiveCustomer : Form
    {
        public closingSRForUnresponsiveCustomer()
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




        private void closingSRForUnresponsiveCustomer_Load(object sender, EventArgs e)
        {









        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {


            DateTime currentDate = DateTime.Now;

            string displayMessage = "Hi " + txtCustomerName.Text + ",\nThis notification is to inform you that the following Service Request will be transitioned to an archived state:\n\nSRNumber: " + txtSRNumber.Text + "\nIssue: " + txtIssue.Text + "\nResolution: " + txtResolution.Text + "\n\nThe Service Request may be re-activated at your discretion via EMC Support https://support.emc.com/ or any EMC Support channel.\n\nIf there is anything regarding this Service Request that you are unsatisfied with please feel free to contact me - my email address is " + txtEmployeeEmail.Text + ".\n\nA Customer Satisfaction Survey may be sent to you via email.  Thank you for taking your time to respond to the survey and rating your experience with EMC Service, Support and Product. In the survey I'm identified as a 'Remote Technical Support Engineer' who worked with you on this 'Service Request'.  I look forward to receiving your positive responses.\n\nThere are several new ways you can communicate and receive information from EMC and other EMC customers.  You may find the following information valuable for future Service Requests when you have a problem or question:\n\n•         Support Forums – these discussion forums are an interactive message board for sharing knowledge and questions about EMC technologies as well as feedback from other EMC users worldwide.  Go to http://forums.emc.com/forums\n\n•         Support by Product - offers consolidated, product specific information on the web at https://support.emc.com/products. Includes quick links to frequently used knowledgebase entries, technical articles, installation & maintenance downloads, documentation, as well as more dynamic content such as presentations, Customer Support Forum entries, and a link to Live Chat. \n\n•         Live Chat puts you directly through to a Remote Technical Support Engineer without going through the phone service request process.\n\t1.     Go to http://powerlink.emc.com/ and select the Support tab.\n\t2.     Select Request Support then Live Chat. From the drop down, select the product you're interested in and Chat will appear.Note: the hours of operation vary by product so be sure to check the landing page once you've selected a product family.\n\t3.     Follow the Begin Chat button (note the wait times for a Live Chat representative).\n\t4.     Follow the steps on the Pre-Chat Form. \n\nNote:  You must allow pop-ups for the Live Chat feature. Please disable your pop-up blocker before launching a chat.\n\nBest Regards,";

            string emailSubject = "SR#" + txtSRNumber.Text + "/ " + txtCompanyName.Text + " ";



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
            txtIssue.Text = " ";
            txtEmailAddress.Text = " ";
            txtCompanyName.Text = " ";
            txtResolution.Text = " ";
            txtEmployeeEmail.Text = " ";
            







        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
