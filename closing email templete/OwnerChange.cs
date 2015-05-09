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
using System.IO;
using System.Net; // needed for the signature email to be grabbed and used to translete html code to be added to a string


//next idea to is to add a clipboard optoin for the header of the service request for the turnover, GEO || date time || next actions or current status

namespace closing_email_templete
{
    public partial class OwnerChange : Form
    {
        public OwnerChange()
        {
            InitializeComponent();
        }

        private void OwnerChange_Load(object sender, EventArgs e)
        {

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




        private void btnTemplate_Click(object sender, EventArgs e)
        {

            DateTime currentDate = DateTime.Now;

            //commited this out to try and make a table instead of just a string format
            //displayMessage = "Reason for Transition: " + txtReasonForTransition.Text + "\nCurrent Business Impact: " + txtCurrentBusinessImpact.Text + "\nIssue Description: " + txtIssueDescription.Text + "\nLocation of Logs: " + txtLocationOfLogs.Text + "\nTurnover to: " + txtTurnoverTo.Text + "\nCode Red: " + txtCodeRed.Text + "\nWarm Turnover: " + txtWarmTurnover.Text + "\nOS/Product/Skill area: " + txtOS.Text + "\nSnr Skills/SME Required: " + txtSrSkill.Text + "\nEngineering/Vendor: " + txtEE.Text + "\nDU/DL: " + txtDUDL.Text + "\nContact Name: " + txtContactName.Text + "\n Contact Number and Time: " + txtcontactNumberAndeTime.Text + "\nWebEx ID : " + txtWebexID.Text + "\nNext action: " + txtNextAction.Text + "\nNext Action Due: " + txtNextActionDue.Text + "\nLast Worked By: "+ txtLastWorked.Text;
            string displayMessage = "Case Type: (Severity)" + txtSeverity.Text + "\n\nSR Number: " + txtSRNumber.Text + "\n\nReason for Transition: " + txtReasonForTransition.Text + "\n\nEng Working Case: " + txtLastWorked.Text + "\n\nCurrent Business Impact: " + txtCurrentBusinessImpact.Text + "\n\nIssue Description: " + txtIssueDescription.Text + "\n\nLocation of Logs: " + txtLocationOfLogs.Text + "\n\nWarm Turnover: (Yes/No): " + txtWarmTurnover.Text + "\n\nOngoing Bridge/Number:" + txtBridgeNumber + "\n\nTurnover to: " + txtTurnoverTo.Text + "\n\nCode Red: " + txtCodeRed.Text + "\n\nOS/Product/Skill area: " + txtOS.Text + "\n\nSnr skills/SME Required: " + txtSrSkill.Text + "\n\nEngineering/Vendor (Engaged/Not Engaged): " + txtEE.Text + "\n\nDU/DL (Yes/No): " + txtDUDL.Text + "\n\nContact Name: " + txtContactName.Text + "\n\nContact Number: " + txtcontactNumberAndeTime.Text + "\n\nNext Steps: " + txtNextAction.Text + "\n\nNext Action Due: " + txtNextActionDue.Text + "\n\n"; 
            string emailSubject = "SR#" + txtSRNumber.Text + "/ " + txtCompanyName.Text + " ";

            
            //creating a table so I can add boarders to the owner changte email template when placed in the email



   

            Outlook.Application outlookApp = new Outlook.Application();
            Outlook._MailItem mailItem = (Outlook._MailItem)outlookApp.CreateItem(Outlook.OlItemType.olMailItem);
            mailItem.To = "VNXe_Turnover <VNXeTurnover@emc.com>";
            mailItem.Subject = emailSubject;
            //commiting out as I will be using the mailItem.HTMLBody to try and make a table with boarders
            //mailItem.Body = displayMessage + "\n\n " + ReadSignature(); // ReadSignature() this will place signature in the body     
            //mailItem.BodyFormat = olFormatHTML;
            //making body use a table
            mailItem.HTMLBody = "<table border='2' style='width:auto'><tr><td>Case Type: (Severity)</td><td>" + txtSeverity.Text + "</td></tr><tr><td>SR Number:</td><td>" + txtSRNumber.Text + "</td></tr><tr><td>Reason for Transition:</td><td>" + txtReasonForTransition.Text + "</td></tr><tr><td>Eng Working Case:</td><td>" + txtLastWorked.Text + "</td></tr><tr><td>Current Business Impact:</td><td>" + txtCurrentBusinessImpact.Text + "</td></tr><tr><td>Issue Description:</td><td>" + txtIssueDescription.Text + "</td></tr><tr><td>Location of Logs:</td><td>" + txtLocationOfLogs.Text + "</td></tr><tr><td>Warm Turnover: (Yes/No):</td><td>" + txtWarmTurnover.Text + "</td></tr><tr><td>Ongoing Bridge/Number:</td><td>" + txtBridgeNumber.Text + "</td></tr><tr><td>Turnover to:</td><td>" + txtTurnoverTo.Text + "</td></tr><tr><td>Code Red:</td><td>" + txtCodeRed.Text + "</td></tr><tr><td>OS/Product/Skill area:</td><td>" + txtOS.Text + "</td></tr><tr><td>Snr skills/SME Required:</td><td>" + txtSrSkill.Text + "</td></tr><tr><td>Engineering/Vendor (Engaged/Not Engaged):</td><td>" + txtEE.Text + "</td></tr><tr><td>DU/DL (Yes/No):</td><td>" + txtDUDL.Text + "</td></tr><tr><td>Contact Name:</td><td>" + txtContactName.Text + "</td></tr><tr><td>Contact Number:</td><td>" + txtcontactNumberAndeTime.Text + "</td></tr><tr><td>Next Steps:</td><td>" + txtNextAction.Text + "</td></tr><tr><td>Next Action Due:</td><td>" + txtNextActionDue.Text + "</td></tr></table></body></html>";
            mailItem.Display(true);



            Clipboard.SetText("Email sent at \n" + currentDate.ToString("H:mm:ss") + "        " + currentDate.ToString("M/dd/yyyy") + "\n***********************************************\n\n" + displayMessage); //this sets the clipboard to exactly what is in that string

            string emailTemplateCopiedToClipBoard = "Your email message has been copied to your clipboard so you can add it to your notes\n***********************************************\n\n" + "Email sent at \n" + currentDate.ToString("H:mm:ss") + "        " + currentDate.ToString("M/dd/yyyy") + "\n***********************************************\n\n" + displayMessage;

            MessageBox.Show(emailTemplateCopiedToClipBoard);



            //set all fields in the Form to blank again
            txtCodeRed.Text = " ";
            txtContactName.Text = " ";
            txtcontactNumberAndeTime.Text = " ";
            txtCurrentBusinessImpact.Text = " ";
            txtDUDL.Text = " ";
            txtIssueDescription.Text = " ";
            txtLastWorked.Text = " ";
            txtLocationOfLogs.Text = " ";
            txtNextAction.Text = " ";
            txtNextActionDue.Text = " ";
            txtOS.Text = " ";
            txtReasonForTransition.Text = " ";
            txtSrSkill.Text = " ";
            txtTurnoverTo.Text = " ";
            txtWarmTurnover.Text = " ";
            txtWebexID.Text = " ";
            txtSRNumber.Text = " ";
            txtCompanyName.Text = " ";
            txtEE.Text = " ";
            txtSeverity.Text = " ";

            return;




        }

        private void txtSeverity_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
