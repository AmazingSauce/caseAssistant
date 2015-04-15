namespace closing_email_templete
{
    partial class HowToOrderPart
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
            this.btnCreateEmailTemp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCompanyname
            // 
            this.txtCompanyname.Location = new System.Drawing.Point(91, 81);
            this.txtCompanyname.Name = "txtCompanyname";
            this.txtCompanyname.Size = new System.Drawing.Size(356, 20);
            this.txtCompanyname.TabIndex = 7;
            // 
            // lblCustomerCompany
            // 
            this.lblCustomerCompany.AutoSize = true;
            this.lblCustomerCompany.Location = new System.Drawing.Point(1, 81);
            this.lblCustomerCompany.Name = "lblCustomerCompany";
            this.lblCustomerCompany.Size = new System.Drawing.Size(82, 13);
            this.lblCustomerCompany.TabIndex = 6;
            this.lblCustomerCompany.Text = "Company Name";
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(91, 55);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(356, 20);
            this.txtEmailAddress.TabIndex = 5;
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Location = new System.Drawing.Point(1, 55);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(73, 13);
            this.lblEmailAddress.TabIndex = 4;
            this.lblEmailAddress.Text = "Email Address";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(91, 6);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(356, 20);
            this.txtCustomerName.TabIndex = 1;
            this.txtCustomerName.TextChanged += new System.EventHandler(this.txtCustomerName_TextChanged);
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(1, 9);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(80, 13);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "Customer name";
            this.lblCustomerName.Click += new System.EventHandler(this.lblCustomerName_Click);
            // 
            // lblSRNumber
            // 
            this.lblSRNumber.AutoSize = true;
            this.lblSRNumber.Location = new System.Drawing.Point(1, 35);
            this.lblSRNumber.Name = "lblSRNumber";
            this.lblSRNumber.Size = new System.Drawing.Size(62, 13);
            this.lblSRNumber.TabIndex = 2;
            this.lblSRNumber.Text = "SR Number";
            // 
            // txtSRNumber
            // 
            this.txtSRNumber.Location = new System.Drawing.Point(91, 32);
            this.txtSRNumber.Name = "txtSRNumber";
            this.txtSRNumber.Size = new System.Drawing.Size(356, 20);
            this.txtSRNumber.TabIndex = 3;
            // 
            // btnCreateEmailTemp
            // 
            this.btnCreateEmailTemp.Location = new System.Drawing.Point(159, 122);
            this.btnCreateEmailTemp.Name = "btnCreateEmailTemp";
            this.btnCreateEmailTemp.Size = new System.Drawing.Size(118, 23);
            this.btnCreateEmailTemp.TabIndex = 8;
            this.btnCreateEmailTemp.Text = "Create Email";
            this.btnCreateEmailTemp.UseVisualStyleBackColor = true;
            this.btnCreateEmailTemp.Click += new System.EventHandler(this.button1_Click);
            // 
            // HowToOrderPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 160);
            this.Controls.Add(this.btnCreateEmailTemp);
            this.Controls.Add(this.txtCompanyname);
            this.Controls.Add(this.lblCustomerCompany);
            this.Controls.Add(this.txtEmailAddress);
            this.Controls.Add(this.lblEmailAddress);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lblSRNumber);
            this.Controls.Add(this.txtSRNumber);
            this.Name = "HowToOrderPart";
            this.Text = "HowToOrderPart";
            this.Load += new System.EventHandler(this.HowToOrderPart_Load);
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
        private System.Windows.Forms.Button btnCreateEmailTemp;

    }
}