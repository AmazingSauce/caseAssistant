namespace closing_email_templete
{
    partial class ClosureEmail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtSRNumber = new System.Windows.Forms.TextBox();
            this.txtCompanyname = new System.Windows.Forms.TextBox();
            this.lblTroubleshooting = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.txtCustomerIssue = new System.Windows.Forms.TextBox();
            this.lblCustomerCompany = new System.Windows.Forms.Label();
            this.lblSRNumber = new System.Windows.Forms.Label();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.btnDisplayTemplate = new System.Windows.Forms.Button();
            this.txtTroubleshootingSteps = new System.Windows.Forms.TextBox();
            this.lblResolution = new System.Windows.Forms.Label();
            this.txtResolution = new System.Windows.Forms.TextBox();
            this.lblCustomerIssue = new System.Windows.Forms.Label();
            this.lblRootCause = new System.Windows.Forms.Label();
            this.txtRootCause = new System.Windows.Forms.TextBox();
            this.txtManagerInfo = new System.Windows.Forms.TextBox();
            this.lblManagerInfo = new System.Windows.Forms.Label();
            this.lblManagerFormat = new System.Windows.Forms.Label();
            this.lblManagerFormateExample = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(102, 12);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(356, 20);
            this.txtCustomerName.TabIndex = 1;
            this.txtCustomerName.TextChanged += new System.EventHandler(this.txtCustomerName_TextChanged);
            // 
            // txtSRNumber
            // 
            this.txtSRNumber.Location = new System.Drawing.Point(102, 38);
            this.txtSRNumber.Name = "txtSRNumber";
            this.txtSRNumber.Size = new System.Drawing.Size(356, 20);
            this.txtSRNumber.TabIndex = 3;
            this.txtSRNumber.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtCompanyname
            // 
            this.txtCompanyname.Location = new System.Drawing.Point(102, 87);
            this.txtCompanyname.Name = "txtCompanyname";
            this.txtCompanyname.Size = new System.Drawing.Size(356, 20);
            this.txtCompanyname.TabIndex = 7;
            // 
            // lblTroubleshooting
            // 
            this.lblTroubleshooting.AutoSize = true;
            this.lblTroubleshooting.Location = new System.Drawing.Point(12, 163);
            this.lblTroubleshooting.Name = "lblTroubleshooting";
            this.lblTroubleshooting.Size = new System.Drawing.Size(83, 13);
            this.lblTroubleshooting.TabIndex = 10;
            this.lblTroubleshooting.Text = "Troubleshooting";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(12, 15);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(80, 13);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "Customer name";
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Location = new System.Drawing.Point(12, 61);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(73, 13);
            this.lblEmailAddress.TabIndex = 4;
            this.lblEmailAddress.Text = "Email Address";
            // 
            // txtCustomerIssue
            // 
            this.txtCustomerIssue.Location = new System.Drawing.Point(102, 113);
            this.txtCustomerIssue.Multiline = true;
            this.txtCustomerIssue.Name = "txtCustomerIssue";
            this.txtCustomerIssue.Size = new System.Drawing.Size(356, 44);
            this.txtCustomerIssue.TabIndex = 9;
            this.txtCustomerIssue.TextChanged += new System.EventHandler(this.txtCustomerIssue_TextChanged);
            // 
            // lblCustomerCompany
            // 
            this.lblCustomerCompany.AutoSize = true;
            this.lblCustomerCompany.Location = new System.Drawing.Point(12, 87);
            this.lblCustomerCompany.Name = "lblCustomerCompany";
            this.lblCustomerCompany.Size = new System.Drawing.Size(82, 13);
            this.lblCustomerCompany.TabIndex = 6;
            this.lblCustomerCompany.Text = "Company Name";
            // 
            // lblSRNumber
            // 
            this.lblSRNumber.AutoSize = true;
            this.lblSRNumber.Location = new System.Drawing.Point(12, 41);
            this.lblSRNumber.Name = "lblSRNumber";
            this.lblSRNumber.Size = new System.Drawing.Size(62, 13);
            this.lblSRNumber.TabIndex = 2;
            this.lblSRNumber.Text = "SR Number";
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(102, 61);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(356, 20);
            this.txtEmailAddress.TabIndex = 5;
            // 
            // btnDisplayTemplate
            // 
            this.btnDisplayTemplate.Location = new System.Drawing.Point(169, 427);
            this.btnDisplayTemplate.Name = "btnDisplayTemplate";
            this.btnDisplayTemplate.Size = new System.Drawing.Size(121, 23);
            this.btnDisplayTemplate.TabIndex = 20;
            this.btnDisplayTemplate.Text = "Display Template";
            this.btnDisplayTemplate.UseVisualStyleBackColor = false;
            this.btnDisplayTemplate.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtTroubleshootingSteps
            // 
            this.txtTroubleshootingSteps.Location = new System.Drawing.Point(102, 163);
            this.txtTroubleshootingSteps.Multiline = true;
            this.txtTroubleshootingSteps.Name = "txtTroubleshootingSteps";
            this.txtTroubleshootingSteps.Size = new System.Drawing.Size(356, 73);
            this.txtTroubleshootingSteps.TabIndex = 11;
            this.txtTroubleshootingSteps.TextChanged += new System.EventHandler(this.txtTroubleshootingSteps_TextChanged);
            // 
            // lblResolution
            // 
            this.lblResolution.AutoSize = true;
            this.lblResolution.Location = new System.Drawing.Point(12, 281);
            this.lblResolution.Name = "lblResolution";
            this.lblResolution.Size = new System.Drawing.Size(57, 13);
            this.lblResolution.TabIndex = 14;
            this.lblResolution.Text = "Resolution";
            this.lblResolution.Click += new System.EventHandler(this.lblResolution_Click);
            // 
            // txtResolution
            // 
            this.txtResolution.Location = new System.Drawing.Point(102, 281);
            this.txtResolution.Multiline = true;
            this.txtResolution.Name = "txtResolution";
            this.txtResolution.Size = new System.Drawing.Size(356, 72);
            this.txtResolution.TabIndex = 15;
            this.txtResolution.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // lblCustomerIssue
            // 
            this.lblCustomerIssue.AutoSize = true;
            this.lblCustomerIssue.Location = new System.Drawing.Point(12, 113);
            this.lblCustomerIssue.Name = "lblCustomerIssue";
            this.lblCustomerIssue.Size = new System.Drawing.Size(32, 13);
            this.lblCustomerIssue.TabIndex = 8;
            this.lblCustomerIssue.Text = "Issue";
            // 
            // lblRootCause
            // 
            this.lblRootCause.AutoSize = true;
            this.lblRootCause.Location = new System.Drawing.Point(12, 251);
            this.lblRootCause.Name = "lblRootCause";
            this.lblRootCause.Size = new System.Drawing.Size(63, 13);
            this.lblRootCause.TabIndex = 12;
            this.lblRootCause.Text = "Root Cause";
            this.lblRootCause.Click += new System.EventHandler(this.lblRootCause_Click);
            // 
            // txtRootCause
            // 
            this.txtRootCause.Location = new System.Drawing.Point(102, 251);
            this.txtRootCause.Name = "txtRootCause";
            this.txtRootCause.Size = new System.Drawing.Size(356, 20);
            this.txtRootCause.TabIndex = 13;
            this.txtRootCause.TextChanged += new System.EventHandler(this.txtRootCause_TextChanged_1);
            // 
            // txtManagerInfo
            // 
            this.txtManagerInfo.Location = new System.Drawing.Point(102, 359);
            this.txtManagerInfo.Name = "txtManagerInfo";
            this.txtManagerInfo.Size = new System.Drawing.Size(356, 20);
            this.txtManagerInfo.TabIndex = 17;
            this.txtManagerInfo.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // lblManagerInfo
            // 
            this.lblManagerInfo.AutoSize = true;
            this.lblManagerInfo.Location = new System.Drawing.Point(12, 359);
            this.lblManagerInfo.Name = "lblManagerInfo";
            this.lblManagerInfo.Size = new System.Drawing.Size(70, 13);
            this.lblManagerInfo.TabIndex = 16;
            this.lblManagerInfo.Text = "Manager Info";
            // 
            // lblManagerFormat
            // 
            this.lblManagerFormat.AutoSize = true;
            this.lblManagerFormat.Location = new System.Drawing.Point(124, 382);
            this.lblManagerFormat.Name = "lblManagerFormat";
            this.lblManagerFormat.Size = new System.Drawing.Size(296, 13);
            this.lblManagerFormat.TabIndex = 18;
            this.lblManagerFormat.Text = "Manager format should be manager full name (manager email)";
            // 
            // lblManagerFormateExample
            // 
            this.lblManagerFormateExample.AutoSize = true;
            this.lblManagerFormateExample.Location = new System.Drawing.Point(124, 395);
            this.lblManagerFormateExample.Name = "lblManagerFormateExample";
            this.lblManagerFormateExample.Size = new System.Drawing.Size(290, 13);
            this.lblManagerFormateExample.TabIndex = 19;
            this.lblManagerFormateExample.Text = "Example: Robert Anderson (Robert.W.Anderson@emc.com)";
            // 
            // ClosureEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 462);
            this.Controls.Add(this.lblManagerFormateExample);
            this.Controls.Add(this.lblManagerFormat);
            this.Controls.Add(this.txtManagerInfo);
            this.Controls.Add(this.lblManagerInfo);
            this.Controls.Add(this.txtRootCause);
            this.Controls.Add(this.lblRootCause);
            this.Controls.Add(this.txtCompanyname);
            this.Controls.Add(this.lblCustomerCompany);
            this.Controls.Add(this.txtEmailAddress);
            this.Controls.Add(this.lblEmailAddress);
            this.Controls.Add(this.lblResolution);
            this.Controls.Add(this.txtResolution);
            this.Controls.Add(this.btnDisplayTemplate);
            this.Controls.Add(this.lblTroubleshooting);
            this.Controls.Add(this.txtTroubleshootingSteps);
            this.Controls.Add(this.txtCustomerIssue);
            this.Controls.Add(this.lblCustomerIssue);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lblSRNumber);
            this.Controls.Add(this.txtSRNumber);
            this.Name = "ClosureEmail";
            this.Text = "Closure email templete";
            this.Load += new System.EventHandler(this.ClosureEmail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtSRNumber;
        private System.Windows.Forms.TextBox txtCompanyname;
        private System.Windows.Forms.Label lblTroubleshooting;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.TextBox txtCustomerIssue;
        private System.Windows.Forms.Label lblCustomerCompany;
        private System.Windows.Forms.Label lblSRNumber;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.Button btnDisplayTemplate;
        private System.Windows.Forms.TextBox txtTroubleshootingSteps;
        private System.Windows.Forms.Label lblResolution;
        private System.Windows.Forms.TextBox txtResolution;
        private System.Windows.Forms.Label lblCustomerIssue;
        private System.Windows.Forms.Label lblRootCause;
        private System.Windows.Forms.TextBox txtRootCause;
        private System.Windows.Forms.TextBox txtManagerInfo;
        private System.Windows.Forms.Label lblManagerInfo;
        private System.Windows.Forms.Label lblManagerFormat;
        private System.Windows.Forms.Label lblManagerFormateExample;

    }
}

