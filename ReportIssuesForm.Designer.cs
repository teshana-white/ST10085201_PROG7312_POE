namespace ST10085201_PROG7312_POE
{
    partial class ReportIssuesForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportIssuesForm));
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.lblAttachments = new System.Windows.Forms.Label();
            this.btnAttachFile = new System.Windows.Forms.Button();
            this.listBoxAttachments = new System.Windows.Forms.ListBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnBackToMenu = new System.Windows.Forms.Button();
            this.btnViewIssues = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(18, 35);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(63, 20);
            this.lblLocation.TabIndex = 7;
            this.lblLocation.Text = "Location:";
            this.lblLocation.Click += new System.EventHandler(this.lblLocation_Click);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(19, 79);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(67, 20);
            this.lblCategory.TabIndex = 8;
            this.lblCategory.Text = "Category:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(19, 127);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(80, 20);
            this.lblDescription.TabIndex = 9;
            this.lblDescription.Text = "Description:";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(105, 35);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(657, 26);
            this.txtLocation.TabIndex = 0;
            this.txtLocation.TextChanged += new System.EventHandler(this.txtLocation_TextChanged);
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Sanitation",
            "Health",
            "Refuse",
            "Storm Water Drainage",
            "Housing",
            "Roads",
            "Water",
            "Electricity",
            "Weather",
            "Safety",
            "Fire",
            "Other"});
            this.cmbCategory.Location = new System.Drawing.Point(105, 79);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(402, 28);
            this.cmbCategory.TabIndex = 1;
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(105, 127);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(657, 100);
            this.rtbDescription.TabIndex = 2;
            this.rtbDescription.Text = "";
            this.rtbDescription.TextChanged += new System.EventHandler(this.rtbDescription_TextChanged);
            // 
            // lblAttachments
            // 
            this.lblAttachments.AutoSize = true;
            this.lblAttachments.Location = new System.Drawing.Point(18, 249);
            this.lblAttachments.Name = "lblAttachments";
            this.lblAttachments.Size = new System.Drawing.Size(85, 20);
            this.lblAttachments.TabIndex = 10;
            this.lblAttachments.Text = "Attachments:";
            // 
            // btnAttachFile
            // 
            this.btnAttachFile.Location = new System.Drawing.Point(105, 249);
            this.btnAttachFile.Name = "btnAttachFile";
            this.btnAttachFile.Size = new System.Drawing.Size(158, 40);
            this.btnAttachFile.TabIndex = 3;
            this.btnAttachFile.Text = "Attach File";
            this.btnAttachFile.UseVisualStyleBackColor = true;
            this.btnAttachFile.Click += new System.EventHandler(this.btnAttachFile_Click);
            // 
            // listBoxAttachments
            // 
            this.listBoxAttachments.FormattingEnabled = true;
            this.listBoxAttachments.ItemHeight = 20;
            this.listBoxAttachments.Location = new System.Drawing.Point(323, 249);
            this.listBoxAttachments.Name = "listBoxAttachments";
            this.listBoxAttachments.Size = new System.Drawing.Size(439, 164);
            this.listBoxAttachments.TabIndex = 4;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(68, 449);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(169, 50);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.Location = new System.Drawing.Point(418, 449);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(169, 50);
            this.btnBackToMenu.TabIndex = 6;
            this.btnBackToMenu.Text = "Back to Main Menu";
            this.btnBackToMenu.UseVisualStyleBackColor = true;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // btnViewIssues
            // 
            this.btnViewIssues.Location = new System.Drawing.Point(243, 449);
            this.btnViewIssues.Name = "btnViewIssues";
            this.btnViewIssues.Size = new System.Drawing.Size(169, 50);
            this.btnViewIssues.TabIndex = 7;
            this.btnViewIssues.Text = "View Issues";
            this.btnViewIssues.UseVisualStyleBackColor = true;
            this.btnViewIssues.Click += new System.EventHandler(this.btnViewIssues_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(593, 449);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(169, 50);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ReportIssuesForm
            // 
            this.ClientSize = new System.Drawing.Size(812, 511);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblAttachments);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.listBoxAttachments);
            this.Controls.Add(this.btnAttachFile);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnBackToMenu);
            this.Controls.Add(this.btnViewIssues);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportIssuesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report Issues";
            this.Load += new System.EventHandler(this.ReportIssuesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Label lblAttachments;
        private System.Windows.Forms.Button btnAttachFile;
        private System.Windows.Forms.ListBox listBoxAttachments;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnBackToMenu;
        private System.Windows.Forms.Button btnViewIssues;
        private System.Windows.Forms.Button btnExit;
    }
}