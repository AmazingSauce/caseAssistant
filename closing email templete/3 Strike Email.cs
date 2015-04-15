using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Controls;
using System.Reflection; //adding for spellcheck
using Outlook = Microsoft.Office.Interop.Outlook;
// to use Menu and Toolbars
using System.IO; // needed for the signature email to be grabbed


namespace closing_email_templete
{
    public partial class _3_Strike_Email : Form
    {
        public _3_Strike_Email()
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





        private void button1_Click(object sender, EventArgs e)
        {






            string displayMessage = "Dear " + txtCusomterName.Text + ",\nI have attempted to reach you on the following dates:\n\n\t1st attempt: " + txt1stAttempt.Text + "\n\t2nd attempt: " + txt2ndAttempt.Text + "\n\t3rd attempt: " + txt3rdAttempt.Text + "\n\nI have also left you voicemail at " + txtCustomerNumber.Text + ".\n\nAs I have not been able to reach you, I will go ahead and archive this SR. If this issue is still pending, please feel free to re-open the SR in the next 10 days. After 10 days, please open up a new SR to engage Support once again, and make reference to this SR " + txtSRNumber.Text + ".\n\nKind Regards,";
            string emailSubject = "SR#" + txtSRNumber.Text + "/ " + txtCompanyname.Text + " ";
           
            
                

                Outlook.Application outlookApp = new Outlook.Application();
                Outlook._MailItem mailItem = (Outlook._MailItem)outlookApp.CreateItem(Outlook.OlItemType.olMailItem);
                mailItem.To = txtCustomerEmail.Text;
                mailItem.Subject = emailSubject;
                mailItem.Body = displayMessage + "\n\n " + ReadSignature(); // ReadSignature() this will place signature in the body               
                mailItem.Display(true);
                    
      

                DateTime currentDate = DateTime.Now;

                string closureNotes = "This note has been copied to your clipboard so you can add it to your notes.\n\n***********************************************\n\n\n\n" + "Email sent at \n" + currentDate.ToString("H:mm:ss") + "        " + currentDate.ToString("M/dd/yyyy") + "\n***********************************************\n\n" + displayMessage;

                MessageBox.Show("Email sent at \n" + currentDate.ToString("H:mm:ss") + "        " + currentDate.ToString("M/dd/yyyy") + "\n***********************************************\n\n" + displayMessage);


                //set all fields in the Form to blank again
                txtCusomterName.Text = " ";
                txtSRNumber.Text = " ";
                txt1stAttempt.Text = " ";
                txt2ndAttempt.Text = " ";
                txt3rdAttempt.Text = " ";
                txtCustomerNumber.Text = " ";
                txtCustomerEmail.Text = " ";
                txtCompanyname.Text = " ";
            

          
        



        }

        private void lblCustomerEmail_Click(object sender, EventArgs e)
        {

        }

        private void txtCustomerEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
