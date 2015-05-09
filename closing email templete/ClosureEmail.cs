// The Willis Tool
// Created on 12/09/2013
// updated on 11/21/2013 made minor changes, changed around the email template to present information for emailing manager first
// Also updated information to show what has been copied to clipboard


using System;
using System.Windows.Forms;
// to use Missing.Value
using Outlook = Microsoft.Office.Interop.Outlook;
// to use Menu and Toolbars
using System.IO; // needed for the signature email to be grabbed
using System.Text;//for grabbbing signature for email
//needed to convert signature from html
using System.Windows.Controls;
using System.Reflection; //adding for spellcheck



namespace closing_email_templete
{
    public partial class ClosureEmail : Form
    {


        public ClosureEmail()
        {

            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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




        private void btnSubmit_Click(object sender, EventArgs e)
        {

            //string Manager = "Thomas, Benjamin <benjamin.thomas@emc.com>";



            string displayMessage = "Hello " + txtCustomerName.Text + ",\nIt was my pleasure to work with you on EMC SR#" + txtSRNumber.Text + ".  According to our last communication, I will go ahead and close this case. \n\nPlease allow me to briefly summarize the case for your own record. \n\nIssue Summary: \n"
                + txtCustomerIssue.Text + "\n\nAnalysis/Troubleshooting(if applicable): \n" + txtTroubleshootingSteps.Text + "\n\nRoot Cause(if applicable): \n" + txtRootCause.Text + "\n\nResolution/Workaround: \n" + txtResolution.Text + "\n\n A Customer satisfaction Survey may be sent to you via email. You are welcome to submit your feedback regarding my service by filling in our survey.  In the survey I'm identified as a 'Remote Technical Support Engineer' who worked with you on this 'service request SR#" + txtSRNumber.Text + "'\n\nIn the meantime, you may also feel free to provide feedback to my manager " + txtManagerInfo.Text + "\n\nYour valued feedback is vital to EMC in order to maintain and improve our Customer service\n\nBest Regards,\n\n "; 
            string emailSubject = "EMC SR#" + txtSRNumber.Text + "/ " + txtCompanyname.Text + " ";

            

            if (txtResolution.Text == "")
            {
                txtResolution.Text = "You forgot a resolution"; //put this in incase someone for some reason leaves resolution blank
                MessageBox.Show(txtResolution.Text);
                

            }
            else
            {
                

                Outlook.Application outlookApp = new Outlook.Application();
                Outlook._MailItem mailItem = (Outlook._MailItem)outlookApp.CreateItem(Outlook.OlItemType.olMailItem);
                mailItem.To = txtEmailAddress.Text;
                mailItem.Subject = emailSubject;
                mailItem.Body = displayMessage + "\n\n " + ReadSignature(); // ReadSignature() this will place signature in the body               
                mailItem.Display(true);
                    


                Clipboard.SetText(displayMessage); //this sets the clipboard to exactly what is in that string

                string emailTemplateCopiedToClipBoard = "Your email message has been copied to your clipboard so you can add it to your notes\n***********************************************\n\n" + displayMessage;

                MessageBox.Show(emailTemplateCopiedToClipBoard);



                //section for closing email template to be copied to clipboard

                string closureBox = "Reported Symptoms: " + txtCustomerIssue.Text +
                    "\nConclusions/Resolution: " + txtResolution.Text +
                    "\nCustomer Approval (if NO, Give Reason): yes\nApproved By: " + txtCustomerName.Text +
                    "\nKB Article:\nFilter Applied / Altered:\nRelated SR Number:";
                Clipboard.SetText(closureBox);

                DateTime currentDate = DateTime.Now;

                string closureNotes = "This note has been copied to your clipboard so you can add it to your notes.\n\n***********************************************\n\n\n\n" + "Email sent at \n" + currentDate.ToString("H:mm:ss") + "        " + currentDate.ToString("M/dd/yyyy") + "\n***********************************************\n\n" + closureBox;

                MessageBox.Show("Email sent at \n" + currentDate.ToString("H:mm:ss") + "        " + currentDate.ToString("M/dd/yyyy") + "\n***********************************************\n\n" + closureNotes);


                string resolutionNotes = "resolution has been copied to your clipboard: \n\n" + txtResolution.Text;

                Clipboard.SetText(txtResolution.Text);

                MessageBox.Show(resolutionNotes);



                //set all fields in the Form to blank again
                txtCustomerName.Text = " ";
                txtSRNumber.Text = " ";
                txtEmailAddress.Text = " ";
                txtCompanyname.Text = " ";
                txtCustomerIssue.Text = " ";
                txtTroubleshootingSteps.Text = " ";
                txtResolution.Text = " ";
                txtRootCause.Text = " ";
                txtManagerInfo.Text = " ";

            }

            return;
        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {

            //SpellCheck.SetIsEnabled = true; //txtCustomerName.SpellCheck.IsEnabled = true; // need to figure out how to get spellcheck to work.


        }

        private void txtCustomerIssue_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtTroubleshootingSteps_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRootCause_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ClosureEmail_Load(object sender, EventArgs e)
        {

        }

        private void lblResolution_Click(object sender, EventArgs e)
        {

        }

        private void lblRootCause_Click(object sender, EventArgs e)
        {

        }

        private void txtRootCause_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }
    }
}
