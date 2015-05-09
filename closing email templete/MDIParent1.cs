using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;


namespace closing_email_templete
{
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {

        }

        private void closureEmailTemplete_Click(object sender, EventArgs e)
        {
            Application.Run(new ClosureEmail());
        }

        

        private void closureEmail_Click(object sender, EventArgs e)
        {


           
                    ClosureEmail obj = new ClosureEmail();// creates object of form
                    obj.MdiParent = this;
                    obj.Show(); // invokes the form  

         
        /*
         *      // trying to figure out how to make it only open one form at a time.
                string templeteOpenAlready = "A Templete is already open";
                MessageBox.Show(templeteOpenAlready);
        */
           
                return;
          


        }

        private void orderPartToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
                HowToOrderPart obj = new HowToOrderPart();
                obj.MdiParent = this;
                obj.Show();
            
              
                return;
           


        }

        private void chooseTemplete_Click(object sender, EventArgs e)
        {

        }

        

        private void performanceEmailToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            PerformanceEmail obj = new PerformanceEmail();
            obj.MdiParent = this;
            obj.Show();


            return;

        }

        private void acceptCaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcceptCase obj = new AcceptCase();
            obj.MdiParent = this;
            obj.Show();


            return;
        }

        private void gatherNewLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GatherNewLogs obj = new GatherNewLogs();
            obj.MdiParent = this;
            obj.Show();


            return;
        }

        private void dialHomeTempleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialHome obj = new DialHome();
            obj.MdiParent = this;
            obj.Show();


            return;
        

        }

        private void codeRedToolStripMenuItem_Click(object sender, EventArgs e)
        {


            CodeRed obj = new CodeRed();
            obj.MdiParent = this;
            obj.Show();


            return;
        


        }

        private void ownerChangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OwnerChange obj = new OwnerChange();
            obj.MdiParent = this;
            obj.Show();


            return;
        }

        private void howToUpgradeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HowToUpgrade obj = new HowToUpgrade();
            obj.MdiParent = this;
            obj.Show();

        }

        private void breakFixIssuesDoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BreakFixIssuesCompleted obj = new BreakFixIssuesCompleted();
            obj.MdiParent = this;
            obj.Show();
        }

        private void sPPanicToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SPPanic obj = new SPPanic();
            obj.MdiParent = this;
            obj.Show();

        }

        private void createTemplateToolStripMenuItem_Click(object sender, EventArgs e)
        {

            CreateTemplate obj = new CreateTemplate();
            obj.MdiParent = this;
            obj.Show();

        }

        private void surgeSiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://10.244.66.67/surge/login.php?originalURL=/surge/index.php");

        }

        private void bTPhoneSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://nyws00.ngcc.bt.com/usgcs/");
        }

        private void injectRootToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://portal.usd.lab.emc.com/utilities/keygen_tool.cgi");
        }

        private void chatSystemMoxieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://chat2.emc.com/NetAgent/jac/JavaAgent.jnlp.aspx");
        }

        private void channelEMCEmployeePortalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://channelemc.corp.emc.com/");
        }

        private void cSIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://crm.emc.com/OA_HTML/AppsLocalLogin.jsp");
        }

        private void qtoolQueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://qtool-vnxe.lss.emc.com/wfm/unassigned/");
        }

        private void searchARsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           System.Diagnostics.Process.Start("http://10.64.27.115:4664/");
           System.Diagnostics.Process.Start("http://birtarsearch.rtp.lab.emc.com/remedy.html");
        }

        private void temporaryFTPSiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ftpaccreq.emc.com/");
        }

        private void eSRSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://esrs.emc.com/portal/");
        }

        private void partCompatabilityDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://alliance.emc.com/Pages/PcdHome.aspx");
        }

        private void vNXeFAQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://support.emc.com/docu43879_Frequently-Asked-Questions---EMC-VNXe-Upgrades.pdf?language=en_US");
        }

        private void emailLinksToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aDPTimesheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://adpeet2.adp.com/81q92p/logon/");
        }

        private void rCMEntitlmentCheckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://corpeustar1/star/RCM_Weighting/PG_submission_shareplex/contract_check_for_support.php");
        }

        private void salesforceKnowledgeBaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://emc.my.salesforce.com/knowledge/knowledgeHome.apexp");
        }

        private void unifiedScheduleRosterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://pld-statuni02.lss.emc.com/gss/");
        }

        private void teamCollaborationChatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://internalchat.corp.emc.com/internalchat/Default2.aspx?pId=2");
        }

        private void vNXeServiciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://supportinfo.lss.emc.com/VNXe/VNXe_Serviceability");
        }

        private void webexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://emccorp.webex.com/cmp0307l/webcomponents/widget/detect.do?siteurl=emccorp&LID=1&RID=2&TID=11&rnd=3410437823&DT=-360&DL=en-us&isDetected=true&backUrl=%2Fmw0307l%2Fmywebex%2Fdefault.do%3Fsiteurl%3Demccorp");
        }

        private void eMCSupportSiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://support.emc.com/");
        }

        private void createAnEmailLinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void vNXeWIKIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://10.241.171.170/VNXe");
        }

        private void replaceFaultedPartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://emc--c.na5.visual.force.com/apex/KB_HowTo?id=kA0700000004JHV");
        }

        private void iOPSInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://emc--c.na5.visual.force.com/apex/KB_HowTo?id=kA0700000004Orw");
        }

        private void howToGatherLogsForDifferenctDevices86236ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://emc--c.na5.visual.force.com/apex/KB_BreakFix_1?id=kA1700000000Pr8");

        }

        private void settingUpCifsFailoverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://community.emc.com/docs/DOC-23767");

        }

        private void gatherLogsAndDumpsOnTheVNXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://emc--c.na5.visual.force.com/apex/KB_HowTo?id=kA0700000004Jid");
            System.Diagnostics.Process.Start("https://emc--c.na5.visual.force.com/apex/KB_BreakFix_1?id=kA1700000000PoY&sid=00D70000000JrBz%21ARUAQLIk9vr5rNqQnAhB4DmsTsep_miTr6U4FHx.eCUecIbkHSa8qQbMZ3gmhEhDctg.8DERqxCqsj7SLSVLfjtW0_ySxkhy&inst=7&logouturl=http%3A%2F%2Femc.force.com%2FSSOLogout&cshc=0000002HB2T0000000JrBz");

        }

        private void upgradeVNXeThroughCliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://emc--c.na5.visual.force.com/apex/KB_BreakFix_1?id=kA1700000000PkE ");
        }

        private void certificateErrorAccessingUnisphereEmc262726ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://emc--c.na5.visual.force.com/apex/KB_BreakFix_1?id=kA1700000000N5l");
        }

        private void replicationHungTasksAndTroubleshootingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://emc--c.na5.visual.force.com/apex/KB_BreakFix_1?id=kA1700000000Pxv");
        }

        private void eSXiHostNotFoundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://emc--c.na5.visual.force.com/apex/KB_BreakFix_1?id=kA1700000000QFg");
        }

        private void createTemplateToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            //could be a usefull way to allow users to create a template
            //https://www.add-in-express.com/creating-addins-blog/2013/09/06/working-with-word-templates/

            CreateTemplate obj = new CreateTemplate();
            obj.MdiParent = this;
            obj.Show();
        }

        private void hotfixsForVNXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://kore.eng.emc.com/");
        }

        private void enableRootOnVNXeAndURToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://emc--c.na5.visual.force.com/apex/KB_HowTo?id=kA0700000004Tze");
        }

        private void increaseTheSizeOfReplicatedFilesystemshareNFSCIFSOnVNXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://emc--c.na5.visual.force.com/apex/KB_HowTo?id=kA0700000004ObP");
        }

        private void vMFSDatastoreDoesNotGetAutomountedOnESXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://emc--c.na5.visual.force.com/apex/KB_BreakFix_1?id=kA1700000000k35");
            System.Diagnostics.Process.Start("https://emc--c.na5.visual.force.com/apex/KB_BreakFix_1?id=kA1700000000Pkz");
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://emc--c.na5.visual.force.com/apex/KB_HowTo?id=kA0700000004Jfz");
        }

        private void nFSDatastoreWillNotAutoMountOnESXHostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://emc--c.na5.visual.force.com/apex/KB_BreakFix_1?id=kA1700000000Pkz");
        }

        private void collectVMWarePerformanceStatistics000017152ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://emc--c.na5.visual.force.com/apex/KB_HowTo?id=kA0700000004K0H");
        }

        private void unmaskAndRemaskAnIscsiLUNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://emc--c.na5.visual.force.com/apex/KB_BreakFix_1?id=kA1700000000Q18");
        }

        private void vNXePerformanceTroubleshootingEmc249375ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://emc--c.na5.visual.force.com/apex/KB_HowTo?id=kA0700000004J7R");
            System.Diagnostics.Process.Start("https://emc--c.na5.visual.force.com/apex/KB_HowTo?id=kA0700000004OSN");
            System.Diagnostics.Process.Start("https://emc--c.na5.visual.force.com/apex/KB_BreakFix_1?id=kA1700000000CPg");
            System.Diagnostics.Process.Start("https://emc--c.na5.visual.force.com/apex/KB_HowTo?id=kA0700000004HN5");
        }

        private void dispatchPartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dispatchPart obj = new dispatchPart();
            obj.MdiParent = this;
            obj.Show();
        }

        private void svctcpdumpHowToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://emc--c.na5.visual.force.com/apex/KB_HowTo?id=kA0700000004Jv6");
        }

        private void guruLiveTemplateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuruLiveTemplete obj = new GuruLiveTemplete();
            obj.MdiParent = this;
            obj.Show();
        }

        private void howToIncreaseISCSIVMFSDatastoreForVMwareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://support.emc.com/kb/15894");
        }

        private void closingSRForUnresponsiveCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closingSRForUnresponsiveCustomer obj = new closingSRForUnresponsiveCustomer();
            obj.MdiParent = this;
            obj.Show();
        }

        private void strikeEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _3_Strike_Email obj = new _3_Strike_Email();
            obj.MdiParent = this;
            obj.Show();
        }

        private void svctcpdumpHowTo000016831ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://emc--c.na5.visual.force.com/apex/KB_HowTo?id=kA0700000004Jv6");
        }

        private void fileMenu_Click(object sender, EventArgs e)
        {

        }

        private void ronsUSDLinksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://10.241.183.5/");
        }

        private void dPEFault3200ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DPEFault obj = new DPEFault();
            obj.MdiParent = this;
            obj.Show();
        }

        private void eSRSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ESRSOutage obj = new ESRSOutage();
            obj.MdiParent = this;
            obj.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {   
            //Idea for this text box is to allow the user to search for kb article number, search for kbs by keywords, open ARs, and open SRs
          
                //this almost works to take what is in the clipboard and put it in the text box, however it only puts it in there when I click in the box and do anything
                //http://stackoverflow.com/questions/20416037/check-if-clipboard-has-data-has-into-textbox
                    
            
                    if (Clipboard.ContainsText(TextDataFormat.Text))
                    {
                        txtSearchBox.Text = Clipboard.GetText();
                        Clipboard.Clear();
                    }

                 
                

        }

        private void sRsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://support.emc.com/servicecenter/srManagement/" + txtSearchBox.Text); 
        }

        private void aRsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://remedytools.rtp.lab.emc.com/nsgview.pl?entry=" + txtSearchBox.Text); 
        }

        private void kBsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://support.emc.com/kb/" + txtSearchBox.Text);
        }

        
    }
}
