namespace UPVApp
{
    partial class Prog2Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prog2Form));
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButtonFile = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButtonInsert = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItemAddress = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemLetter = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButtonReport = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItemListAddress = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemListParcels = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxListing = new System.Windows.Forms.TextBox();
            this.toolStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMain
            // 
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButtonFile,
            this.toolStripDropDownButtonInsert,
            this.toolStripDropDownButtonReport});
            this.toolStripMain.Location = new System.Drawing.Point(0, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(446, 25);
            this.toolStripMain.TabIndex = 0;
            // 
            // toolStripDropDownButtonFile
            // 
            this.toolStripDropDownButtonFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButtonFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAbout,
            this.toolStripMenuItemExit});
            this.toolStripDropDownButtonFile.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonFile.Image")));
            this.toolStripDropDownButtonFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonFile.Name = "toolStripDropDownButtonFile";
            this.toolStripDropDownButtonFile.Size = new System.Drawing.Size(38, 22);
            this.toolStripDropDownButtonFile.Text = "&File";
            // 
            // toolStripMenuItemAbout
            // 
            this.toolStripMenuItemAbout.Name = "toolStripMenuItemAbout";
            this.toolStripMenuItemAbout.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemAbout.Text = "&About";
            this.toolStripMenuItemAbout.Click += new System.EventHandler(this.toolStripMenuItemAbout_Click);
            // 
            // toolStripMenuItemExit
            // 
            this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            this.toolStripMenuItemExit.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemExit.Text = "E&xit";
            this.toolStripMenuItemExit.Click += new System.EventHandler(this.toolStripMenuItemExit_Click);
            // 
            // toolStripDropDownButtonInsert
            // 
            this.toolStripDropDownButtonInsert.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButtonInsert.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAddress,
            this.toolStripMenuItemLetter});
            this.toolStripDropDownButtonInsert.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonInsert.Image")));
            this.toolStripDropDownButtonInsert.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonInsert.Name = "toolStripDropDownButtonInsert";
            this.toolStripDropDownButtonInsert.Size = new System.Drawing.Size(49, 22);
            this.toolStripDropDownButtonInsert.Text = "&Insert";
            // 
            // toolStripMenuItemAddress
            // 
            this.toolStripMenuItemAddress.Name = "toolStripMenuItemAddress";
            this.toolStripMenuItemAddress.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemAddress.Text = "&Address";
            this.toolStripMenuItemAddress.Click += new System.EventHandler(this.toolStripMenuItemAddress_Click);
            // 
            // toolStripMenuItemLetter
            // 
            this.toolStripMenuItemLetter.Name = "toolStripMenuItemLetter";
            this.toolStripMenuItemLetter.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemLetter.Text = "&Letter";
            this.toolStripMenuItemLetter.Click += new System.EventHandler(this.toolStripMenuItemLetter_Click);
            // 
            // toolStripDropDownButtonReport
            // 
            this.toolStripDropDownButtonReport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButtonReport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemListAddress,
            this.toolStripMenuItemListParcels});
            this.toolStripDropDownButtonReport.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonReport.Image")));
            this.toolStripDropDownButtonReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonReport.Name = "toolStripDropDownButtonReport";
            this.toolStripDropDownButtonReport.Size = new System.Drawing.Size(55, 22);
            this.toolStripDropDownButtonReport.Text = "&Report";
            // 
            // toolStripMenuItemListAddress
            // 
            this.toolStripMenuItemListAddress.Name = "toolStripMenuItemListAddress";
            this.toolStripMenuItemListAddress.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemListAddress.Text = "List &Addresses";
            this.toolStripMenuItemListAddress.Click += new System.EventHandler(this.toolStripMenuItemListAddress_Click);
            // 
            // toolStripMenuItemListParcels
            // 
            this.toolStripMenuItemListParcels.Name = "toolStripMenuItemListParcels";
            this.toolStripMenuItemListParcels.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemListParcels.Text = "List &Parcels";
            this.toolStripMenuItemListParcels.Click += new System.EventHandler(this.toolStripMenuItemListParcels_Click);
            // 
            // textBoxListing
            // 
            this.textBoxListing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxListing.Location = new System.Drawing.Point(0, 25);
            this.textBoxListing.Multiline = true;
            this.textBoxListing.Name = "textBoxListing";
            this.textBoxListing.ReadOnly = true;
            this.textBoxListing.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxListing.Size = new System.Drawing.Size(446, 437);
            this.textBoxListing.TabIndex = 1;
            // 
            // Prog2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 462);
            this.Controls.Add(this.textBoxListing);
            this.Controls.Add(this.toolStripMain);
            this.Name = "Prog2Form";
            this.Text = "Program 2";
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStripMain;
        private ToolStripDropDownButton toolStripDropDownButtonReport;
        private ToolStripMenuItem toolStripMenuItemListAddress;
        private ToolStripMenuItem toolStripMenuItemListParcels;
        private ToolStripDropDownButton toolStripDropDownButtonFile;
        private ToolStripMenuItem toolStripMenuItemAbout;
        private ToolStripMenuItem toolStripMenuItemExit;
        private ToolStripDropDownButton toolStripDropDownButtonInsert;
        private ToolStripMenuItem toolStripMenuItemAddress;
        private ToolStripMenuItem toolStripMenuItemLetter;
        private TextBox textBoxListing;
    }
}

