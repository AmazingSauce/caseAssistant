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
    public partial class CodeRed : Form
    {
        public CodeRed()
        {
            InitializeComponent();
        }

        private void CodeRed_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }





        private void button1_Click(object sender, EventArgs e)
        {

            DateTime currentDate = DateTime.Now;

            string displayMessage = "Code Red Update\n " + currentDate.ToString("H:mm:ss") + "        " + currentDate.ToString("M/dd/yyyy") + "\nINTERNAL USE ONLY -- DO NOT RELEASE TO CUSTOMER\n\nCOMPANY = " + txtCompanyName.Text + "\nLOCATION (Country/State/City) = " + txtLocation.Text + "\nCUSTTEMP = " + txtCustTemp.Text + "\nPRODUCT = " + txtProduct.Text + "\nSERIAL # = " + txtSerial.Text + "\nCODE LEVEL = " + txtCodeLevel.Text + "\nSERVICE REQUEST # =" + txtSRNumber.Text + "\nENGINEERING INFO =  " + txtEEInfo.Text + "\nDU /DL (hrs)  = " + txtDUDL.Text + "\nPROBLEM = " + txtProblem.Text + "\n\nAll updates for Code Reds should be made as a Reply ALL to the original Code Red alert.\nAlso, upon sending a Code Red update, the subject line\n\nshould change to include,\n\"UPDATE: CODE RED [Product] [Customer Name] - SR xxxxxxxx\"";
            string emailSubject = "CODE RED FOR VNXe - " +  txtCompanyName.Text + " - SR" + txtSRNumber.Text;





                Outlook.Application outlookApp = new Outlook.Application();
                Outlook._MailItem mailItem = (Outlook._MailItem)outlookApp.CreateItem(Outlook.OlItemType.olMailItem);
                mailItem.To = "CSS-WWTS VNXe CR Approval Team <CSSWWTSVNXeCRApprovalTeam@emc.com>";
                mailItem.Subject = emailSubject;
                mailItem.Body = displayMessage;              
                mailItem.Display(true);



                Clipboard.SetText("Email sent at \n" + currentDate.ToString("H:mm:ss") + "        " + currentDate.ToString("M/dd/yyyy") + "\n***********************************************\n\n" + displayMessage); //this sets the clipboard to exactly what is in that string

                string emailTemplateCopiedToClipBoard = "Your email message has been copied to your clipboard so you can add it to your notes\n***********************************************\n\n" + "Email sent at \n" + currentDate.ToString("H:mm:ss") + "        " + currentDate.ToString("M/dd/yyyy") +"\n***********************************************\n\n" + displayMessage;

                MessageBox.Show(emailTemplateCopiedToClipBoard);





              



                //set all fields in the Form to blank again
                txtSRNumber.Text = " ";
                txtCompanyName.Text = " ";
                txtCodeLevel.Text = " ";
                txtCustTemp.Text = " ";
                txtDUDL.Text = " ";
                txtEEInfo.Text = " ";
                txtLocation.Text = " ";
                txtProblem.Text = " ";
                txtProduct.Text = " ";
                txtSerial.Text = " ";
                
               
                

            return;


        }
    }
}
