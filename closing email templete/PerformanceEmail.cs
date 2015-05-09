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
// to use Menu and Toolbars
using System.IO; // needed for the signature email to be grabbed





namespace closing_email_templete
{
    public partial class PerformanceEmail : Form
    {
        public PerformanceEmail()
        {
            InitializeComponent();
        }

        private void PerformanceEmail_Load(object sender, EventArgs e)
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




        private void btnPerformanceEmail_Click(object sender, EventArgs e)
        {



            DateTime currentDate = DateTime.Now;

            string displayMessage = "Hi " + txtCustomerName.Text + ",\n" + "To troubleshoot the VNXe and the performance problem we will need some information from your environment and the VNXe, if you can go ahead and answer the questions below. \n\nWhat is the performance being seen and what is expected?  Measurements/numbers \n\nHow are the performance issues being measured/results collected? \n\nWhen does the issue occur? \n\nIs the issue on slow reads, slow writes or both? \n\nDoes it happen intermittently or is there a pattern to it? \n\nCan we reproduce the slow performance at will, and how would we do so? \n\nHave there been any recent changes made to host, server application or network (routing/ip address change, group policy, virus scanning or firmware upgrades for example)? \n\nWhat is the level of impact and why? \n\nCode version on the VNXe: \n\nStorage configuration: \n\nPool name: \n\tRAID: \n\tDisk type: \n\tAmount of disks: \n\nProtocol being used: ex. CIFS, iSCSi \n\nLink aggregation on the VNXe? \n\nMTU size: \n\tAll devices on network \n\nNetwork topology between the VNXe and affected host/clients \n\nFile system naming having issues:\n\nAre you using \n\n\tSnapshots: \n\tThin provisioning: \n\tDe-duplication: \n\tReplication: \n\tCAVA: \n\nInformation about hosts/clients having issues: ex vmware, thin provisioning and network configuration: \n\nAny host side information: \n\nfor further trouble shooting we may need to recreate the issue and capture the performance with network traces during the slow performance. \n\nWe will also need to gather a new data collect from the VNXe \n\nThis can be done from unisphere by going to settings> service system> collect service information> execute\n\nOn the first screen please select “NO” so that the system will gather new logs\n\nPlease upload them to the service request \n\nThis can be done by going to support.emc.com> selecting view and mange service requests> then select " + txtSRNumber.Text + "> at the top of the screen there should be a paperclip that you can select and upload the logs to. \n\nThank you very much \n\nHave a wonderful day!";
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


                string kbarticle = "000166363 , 000013752 , 000034570 , 000007034 ";

                Clipboard.SetText(kbarticle);

                MessageBox.Show("kb articles have been copied to your clipbaord " + kbarticle);


                //set all fields in the Form to blank again
                txtCustomerName.Text = " ";
                txtSRNumber.Text = " ";
                txtEmailAddress.Text = " ";
                txtCompanyname.Text = " ";
               




        }
    }
}
