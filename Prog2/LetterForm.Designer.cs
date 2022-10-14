namespace UPVApp
{
    partial class LetterForm
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
            this.components = new System.ComponentModel.Container();
            this.labelOrigin = new System.Windows.Forms.Label();
            this.comboBoxOrigin = new System.Windows.Forms.ComboBox();
            this.labelDestination = new System.Windows.Forms.Label();
            this.labelFixedCost = new System.Windows.Forms.Label();
            this.comboBoxDestination = new System.Windows.Forms.ComboBox();
            this.textBoxFixedCost = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // labelOrigin
            // 
            this.labelOrigin.AutoSize = true;
            this.labelOrigin.Location = new System.Drawing.Point(39, 9);
            this.labelOrigin.Name = "labelOrigin";
            this.labelOrigin.Size = new System.Drawing.Size(85, 15);
            this.labelOrigin.TabIndex = 0;
            this.labelOrigin.Text = "Origin Address";
            // 
            // comboBoxOrigin
            // 
            this.comboBoxOrigin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOrigin.FormattingEnabled = true;
            this.comboBoxOrigin.Location = new System.Drawing.Point(130, 6);
            this.comboBoxOrigin.Name = "comboBoxOrigin";
            this.comboBoxOrigin.Size = new System.Drawing.Size(142, 23);
            this.comboBoxOrigin.TabIndex = 1;
            this.comboBoxOrigin.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox_Validating_AddressIndex);
            this.comboBoxOrigin.Validated += new System.EventHandler(this.control_Validated);
            // 
            // labelDestination
            // 
            this.labelDestination.AutoSize = true;
            this.labelDestination.Location = new System.Drawing.Point(12, 38);
            this.labelDestination.Name = "labelDestination";
            this.labelDestination.Size = new System.Drawing.Size(112, 15);
            this.labelDestination.TabIndex = 2;
            this.labelDestination.Text = "Destination Address";
            // 
            // labelFixedCost
            // 
            this.labelFixedCost.AutoSize = true;
            this.labelFixedCost.Location = new System.Drawing.Point(62, 67);
            this.labelFixedCost.Name = "labelFixedCost";
            this.labelFixedCost.Size = new System.Drawing.Size(62, 15);
            this.labelFixedCost.TabIndex = 3;
            this.labelFixedCost.Text = "Fixed Cost";
            // 
            // comboBoxDestination
            // 
            this.comboBoxDestination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDestination.FormattingEnabled = true;
            this.comboBoxDestination.Location = new System.Drawing.Point(130, 35);
            this.comboBoxDestination.Name = "comboBoxDestination";
            this.comboBoxDestination.Size = new System.Drawing.Size(142, 23);
            this.comboBoxDestination.TabIndex = 4;
            this.comboBoxDestination.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox_Validating_AddressIndex);
            this.comboBoxDestination.Validated += new System.EventHandler(this.control_Validated);
            // 
            // textBoxFixedCost
            // 
            this.textBoxFixedCost.Location = new System.Drawing.Point(130, 64);
            this.textBoxFixedCost.Name = "textBoxFixedCost";
            this.textBoxFixedCost.Size = new System.Drawing.Size(142, 23);
            this.textBoxFixedCost.TabIndex = 5;
            this.textBoxFixedCost.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Validating_IntegerPositive);
            this.textBoxFixedCost.Validated += new System.EventHandler(this.control_Validated);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(233, 102);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 6;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(21, 102);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // LetterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 137);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxFixedCost);
            this.Controls.Add(this.comboBoxDestination);
            this.Controls.Add(this.labelFixedCost);
            this.Controls.Add(this.labelDestination);
            this.Controls.Add(this.comboBoxOrigin);
            this.Controls.Add(this.labelOrigin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "LetterForm";
            this.Text = "Add Letter";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelOrigin;
        private ComboBox comboBoxOrigin;
        private Label labelDestination;
        private Label labelFixedCost;
        private ComboBox comboBoxDestination;
        private TextBox textBoxFixedCost;
        private Button buttonOk;
        private Button buttonCancel;
        private ErrorProvider errorProvider;
    }
}