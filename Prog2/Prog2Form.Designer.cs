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
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButtonInsert = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButtonReport = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItemAddress = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemLetter = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.toolStripDropDownButtonFile.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonFile.Image")));
            this.toolStripDropDownButtonFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonFile.Name = "toolStripDropDownButtonFile";
            this.toolStripDropDownButtonFile.Size = new System.Drawing.Size(38, 22);
            this.toolStripDropDownButtonFile.Text = "File";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem3.Text = "About";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem4.Text = "Exit";
            // 
            // toolStripDropDownButtonInsert
            // 
            this.toolStripDropDownButtonInsert.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButtonInsert.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.toolStripDropDownButtonInsert.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonInsert.Image")));
            this.toolStripDropDownButtonInsert.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonInsert.Name = "toolStripDropDownButtonInsert";
            this.toolStripDropDownButtonInsert.Size = new System.Drawing.Size(49, 22);
            this.toolStripDropDownButtonInsert.Text = "Insert";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "Address";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "Letter";
            // 
            // toolStripDropDownButtonReport
            // 
            this.toolStripDropDownButtonReport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButtonReport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAddress,
            this.toolStripMenuItemLetter});
            this.toolStripDropDownButtonReport.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonReport.Image")));
            this.toolStripDropDownButtonReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonReport.Name = "toolStripDropDownButtonReport";
            this.toolStripDropDownButtonReport.Size = new System.Drawing.Size(55, 22);
            this.toolStripDropDownButtonReport.Text = "Report";
            // 
            // toolStripMenuItemAddress
            // 
            this.toolStripMenuItemAddress.Name = "toolStripMenuItemAddress";
            this.toolStripMenuItemAddress.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemAddress.Text = "List Addresses";
            // 
            // toolStripMenuItemLetter
            // 
            this.toolStripMenuItemLetter.Name = "toolStripMenuItemLetter";
            this.toolStripMenuItemLetter.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemLetter.Text = "List Parcels";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 25);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(446, 437);
            this.textBox1.TabIndex = 1;
            // 
            // Prog2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 462);
            this.Controls.Add(this.textBox1);
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
        private ToolStripMenuItem toolStripMenuItemAddress;
        private ToolStripMenuItem toolStripMenuItemLetter;
        private ToolStripDropDownButton toolStripDropDownButtonFile;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripDropDownButton toolStripDropDownButtonInsert;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private TextBox textBox1;
    }
}

