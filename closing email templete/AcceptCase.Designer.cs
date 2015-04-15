namespace closing_email_templete
{
    partial class AcceptCase
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
            this.txtCompanyname = new System.Windows.Forms.TextBox();
            this.lblCustomerCompany = new System.Windows.Forms.Label();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblSRNumber = new System.Windows.Forms.Label();
            this.txtSRNumber = new System.Windows.Forms.TextBox();
            this.btnAcceptCase = new System.Windows.Forms.Button();
            this.txtAgentName = new System.Windows.Forms.TextBox();
            this.lblAgentName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCompanyname
            // 
            this.txtCompanyname.Location = new System.Drawing.Point(102, 81);
            this.txtCompanyname.Name = "txtCompanyname";
            this.txtCompanyname.Size = new System.Drawing.Size(356, 20);
            this.txtCompanyname.TabIndex = 7;
            // 
            // lblCustomerCompany
            // 
            this.lblCustomerCompany.AutoSize = true;
            this.lblCustomerCompany.Location = new System.Drawing.Point(12, 81);
            this.lblCustomerCompany.Name = "lblCustomerCompany";
            this.lblCustomerCompany.Size = new System.Drawing.Size(82, 13);
            this.lblCustomerCompany.TabIndex = 6;
            this.lblCustomerCompany.Text = "Company Name";
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(102, 55);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(356, 20);
            this.txtEmailAddress.TabIndex = 5;
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Location = new System.Drawing.Point(12, 55);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(73, 13);
            this.lblEmailAddress.TabIndex = 4;
            this.lblEmailAddress.Text = "Email Address";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(102, 6);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(356, 20);
            this.txtCustomerName.TabIndex = 1;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(12, 9);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(80, 13);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "Customer name";
            // 
            // lblSRNumber
            // 
            this.lblSRNumber.AutoSize = true;
            this.lblSRNumber.Location = new System.Drawing.Point(12, 35);
            this.lblSRNumber.Name = "lblSRNumber";
            this.lblSRNumber.Size = new System.Drawing.Size(62, 13);
            this.lblSRNumber.TabIndex = 2;
            this.lblSRNumber.Text = "SR Number";
            // 
            // txtSRNumber
            // 
            this.txtSRNumber.Location = new System.Drawing.Point(102, 32);
            this.txtSRNumber.Name = "txtSRNumber";
            this.txtSRNumber.Size = new System.Drawing.Size(356, 20);
            this.txtSRNumber.TabIndex = 3;
            // 
            // btnAcceptCase
            // 
            this.btnAcceptCase.Location = new System.Drawing.Point(205, 139);
            this.btnAcceptCase.Name = "btnAcceptCase";
            this.btnAcceptCase.Size = new System.Drawing.Size(75, 23);
            this.btnAcceptCase.TabIndex = 10;
            this.btnAcceptCase.Text = "Create Email";
            this.btnAcceptCase.UseVisualStyleBackColor = true;
            this.btnAcceptCase.Click += new System.EventHandler(this.btnAcceptCase_Click);
            // 
            // txtAgentName
            // 
            this.txtAgentName.Location = new System.Drawing.Point(102, 113);
            this.txtAgentName.Name = "txtAgentName";
            this.txtAgentName.Size = new System.Drawing.Size(356, 20);
            this.txtAgentName.TabIndex = 9;
            // 
            // lblAgentName
            // 
            this.lblAgentName.AutoSize = true;
            this.lblAgentName.Location = new System.Drawing.Point(12, 113);
            this.lblAgentName.Name = "lblAgentName";
            this.lblAgentName.Size = new System.Drawing.Size(66, 13);
            this.lblAgentName.TabIndex = 8;
            this.lblAgentName.Text = "Agent Name";
            // 
            // AcceptCase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 174);
            this.Controls.Add(this.txtAgentName);
            this.Controls.Add(this.lblAgentName);
            this.Controls.Add(this.btnAcceptCase);
            this.Controls.Add(this.txtCompanyname);
            this.Controls.Add(this.lblCustomerCompany);
            this.Controls.Add(this.txtEmailAddress);
            this.Controls.Add(this.lblEmailAddress);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lblSRNumber);
            this.Controls.Add(this.txtSRNumber);
            this.Name = "AcceptCase";
            this.Text = "AcceptCase";
            this.Load += new System.EventHandler(this.AcceptCase_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCompanyname;
        private System.Windows.Forms.Label lblCustomerCompany;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblSRNumber;
        private System.Windows.Forms.TextBox txtSRNumber;
        private System.Windows.Forms.Button btnAcceptCase;
        private System.Windows.Forms.TextBox txtAgentName;
        private System.Windows.Forms.Label lblAgentName;

    }
}