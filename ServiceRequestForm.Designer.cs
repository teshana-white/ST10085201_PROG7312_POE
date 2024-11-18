namespace ST10085201_PROG7312_POE
{
    partial class ServiceRequestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceRequestForm));
            this.btnBackToMenu = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbServiceRequests = new System.Windows.Forms.ListBox();
            this.btnShowMST = new System.Windows.Forms.Button();
            this.lblServiceRequests = new System.Windows.Forms.Label();
            this.pnlGraph = new System.Windows.Forms.Panel();
            this.lbMST = new System.Windows.Forms.ListBox();
            this.lblMST = new System.Windows.Forms.Label();
            this.btnRequests = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.Location = new System.Drawing.Point(414, 449);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(169, 50);
            this.btnBackToMenu.TabIndex = 11;
            this.btnBackToMenu.Text = "Back to Main Menu";
            this.btnBackToMenu.UseVisualStyleBackColor = true;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(589, 449);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(169, 50);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbServiceRequests
            // 
            this.lbServiceRequests.FormattingEnabled = true;
            this.lbServiceRequests.ItemHeight = 20;
            this.lbServiceRequests.Location = new System.Drawing.Point(12, 31);
            this.lbServiceRequests.Name = "lbServiceRequests";
            this.lbServiceRequests.ScrollAlwaysVisible = true;
            this.lbServiceRequests.Size = new System.Drawing.Size(308, 204);
            this.lbServiceRequests.TabIndex = 16;
            this.lbServiceRequests.SelectedIndexChanged += new System.EventHandler(this.lbServiceRequests_DoubleClick);
            // 
            // btnShowMST
            // 
            this.btnShowMST.Location = new System.Drawing.Point(239, 449);
            this.btnShowMST.Name = "btnShowMST";
            this.btnShowMST.Size = new System.Drawing.Size(169, 50);
            this.btnShowMST.TabIndex = 17;
            this.btnShowMST.Text = "Show MST";
            this.btnShowMST.UseVisualStyleBackColor = true;
            this.btnShowMST.Click += new System.EventHandler(this.btnShowMST_Click);
            // 
            // lblServiceRequests
            // 
            this.lblServiceRequests.AutoSize = true;
            this.lblServiceRequests.Location = new System.Drawing.Point(12, 9);
            this.lblServiceRequests.Name = "lblServiceRequests";
            this.lblServiceRequests.Size = new System.Drawing.Size(120, 20);
            this.lblServiceRequests.TabIndex = 18;
            this.lblServiceRequests.Text = "Service Requests:";
            // 
            // pnlGraph
            // 
            this.pnlGraph.Location = new System.Drawing.Point(326, 9);
            this.pnlGraph.Name = "pnlGraph";
            this.pnlGraph.Size = new System.Drawing.Size(474, 434);
            this.pnlGraph.TabIndex = 19;
            // 
            // lbMST
            // 
            this.lbMST.FormattingEnabled = true;
            this.lbMST.ItemHeight = 20;
            this.lbMST.Location = new System.Drawing.Point(12, 259);
            this.lbMST.Name = "lbMST";
            this.lbMST.ScrollAlwaysVisible = true;
            this.lbMST.Size = new System.Drawing.Size(308, 184);
            this.lbMST.TabIndex = 20;
            // 
            // lblMST
            // 
            this.lblMST.AutoSize = true;
            this.lblMST.Location = new System.Drawing.Point(12, 238);
            this.lblMST.Name = "lblMST";
            this.lblMST.Size = new System.Drawing.Size(84, 20);
            this.lblMST.TabIndex = 21;
            this.lblMST.Text = "MST Edges:";
            this.lblMST.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnRequests
            // 
            this.btnRequests.Location = new System.Drawing.Point(64, 449);
            this.btnRequests.Name = "btnRequests";
            this.btnRequests.Size = new System.Drawing.Size(169, 50);
            this.btnRequests.TabIndex = 22;
            this.btnRequests.Text = "Show Requests";
            this.btnRequests.UseVisualStyleBackColor = true;
            this.btnRequests.Click += new System.EventHandler(this.btnRequests_Click);
            // 
            // ServiceRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(812, 511);
            this.Controls.Add(this.btnRequests);
            this.Controls.Add(this.lblMST);
            this.Controls.Add(this.lbMST);
            this.Controls.Add(this.pnlGraph);
            this.Controls.Add(this.lblServiceRequests);
            this.Controls.Add(this.btnShowMST);
            this.Controls.Add(this.lbServiceRequests);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBackToMenu);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ServiceRequestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Service Status and MST";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBackToMenu;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lbServiceRequests;
        private System.Windows.Forms.Button btnShowMST;
        private System.Windows.Forms.Label lblServiceRequests;
        private System.Windows.Forms.Panel pnlGraph;
        private System.Windows.Forms.ListBox lbMST;
        private System.Windows.Forms.Label lblMST;
        private System.Windows.Forms.Button btnRequests;
    }
}