namespace closing_email_templete
{
    partial class CreateTemplate
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
            this.bCreateTemplate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bCreateTemplate
            // 
            this.bCreateTemplate.Location = new System.Drawing.Point(199, 304);
            this.bCreateTemplate.Name = "bCreateTemplate";
            this.bCreateTemplate.Size = new System.Drawing.Size(149, 23);
            this.bCreateTemplate.TabIndex = 0;
            this.bCreateTemplate.Text = "Create Template";
            this.bCreateTemplate.UseVisualStyleBackColor = true;
            // 
            // CreateTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 339);
            this.Controls.Add(this.bCreateTemplate);
            this.Name = "CreateTemplate";
            this.Text = "templates and information ";
            this.Load += new System.EventHandler(this.CreateTemplate_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bCreateTemplate;
    }
}