namespace UPVApp
{
    partial class AddressForm
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
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.comboBoxState = new System.Windows.Forms.ComboBox();
            this.textBoxAddress1 = new System.Windows.Forms.TextBox();
            this.labelAddress1 = new System.Windows.Forms.Label();
            this.textBoxAddress2 = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelState = new System.Windows.Forms.Label();
            this.textBoxZip = new System.Windows.Forms.TextBox();
            this.labelZip = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(143, 212);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(7, 212);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(17, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(39, 15);
            this.labelName.TabIndex = 8;
            this.labelName.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(81, 6);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(137, 23);
            this.textBoxName.TabIndex = 2;
            this.textBoxName.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Validating_NotNullOrWhiteSpace);
            this.textBoxName.Validated += new System.EventHandler(this.control_Validated);
            // 
            // comboBoxState
            // 
            this.comboBoxState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxState.FormattingEnabled = true;
            this.comboBoxState.Items.AddRange(new object[] {
            "KY",
            "TX",
            "FL",
            "MA"});
            this.comboBoxState.Location = new System.Drawing.Point(81, 124);
            this.comboBoxState.Name = "comboBoxState";
            this.comboBoxState.Size = new System.Drawing.Size(137, 23);
            this.comboBoxState.TabIndex = 6;
            this.comboBoxState.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxState_Validating);
            this.comboBoxState.Validated += new System.EventHandler(this.control_Validated);
            // 
            // textBoxAddress1
            // 
            this.textBoxAddress1.Location = new System.Drawing.Point(81, 35);
            this.textBoxAddress1.Name = "textBoxAddress1";
            this.textBoxAddress1.Size = new System.Drawing.Size(137, 23);
            this.textBoxAddress1.TabIndex = 3;
            this.textBoxAddress1.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Validating_NotNullOrWhiteSpace);
            this.textBoxAddress1.Validated += new System.EventHandler(this.control_Validated);
            // 
            // labelAddress1
            // 
            this.labelAddress1.AutoSize = true;
            this.labelAddress1.Location = new System.Drawing.Point(7, 38);
            this.labelAddress1.Name = "labelAddress1";
            this.labelAddress1.Size = new System.Drawing.Size(49, 15);
            this.labelAddress1.TabIndex = 9;
            this.labelAddress1.Text = "Address";
            // 
            // textBoxAddress2
            // 
            this.textBoxAddress2.Location = new System.Drawing.Point(81, 64);
            this.textBoxAddress2.Name = "textBoxAddress2";
            this.textBoxAddress2.Size = new System.Drawing.Size(137, 23);
            this.textBoxAddress2.TabIndex = 4;
            this.textBoxAddress2.Validated += new System.EventHandler(this.control_Validated);
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(81, 95);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(137, 23);
            this.textBoxCity.TabIndex = 5;
            this.textBoxCity.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Validating_NotNullOrWhiteSpace);
            this.textBoxCity.Validated += new System.EventHandler(this.control_Validated);
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(28, 95);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(28, 15);
            this.labelCity.TabIndex = 10;
            this.labelCity.Text = "City";
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Location = new System.Drawing.Point(23, 127);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(33, 15);
            this.labelState.TabIndex = 11;
            this.labelState.Text = "State";
            // 
            // textBoxZip
            // 
            this.textBoxZip.Location = new System.Drawing.Point(81, 153);
            this.textBoxZip.Name = "textBoxZip";
            this.textBoxZip.Size = new System.Drawing.Size(137, 23);
            this.textBoxZip.TabIndex = 7;
            this.textBoxZip.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxZip_Validating);
            this.textBoxZip.Validated += new System.EventHandler(this.control_Validated);
            // 
            // labelZip
            // 
            this.labelZip.AutoSize = true;
            this.labelZip.Location = new System.Drawing.Point(6, 156);
            this.labelZip.Name = "labelZip";
            this.labelZip.Size = new System.Drawing.Size(50, 15);
            this.labelZip.TabIndex = 12;
            this.labelZip.Text = "Zipcode";
            // 
            // AddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(248, 248);
            this.Controls.Add(this.textBoxZip);
            this.Controls.Add(this.labelZip);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.textBoxAddress2);
            this.Controls.Add(this.textBoxAddress1);
            this.Controls.Add(this.labelAddress1);
            this.Controls.Add(this.comboBoxState);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddressForm";
            this.Text = "New Address";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ErrorProvider errorProvider;
        private Button buttonCancel;
        private Button buttonOk;
        private ComboBox comboBoxState;
        private TextBox textBoxName;
        private Label labelName;
        private Label labelState;
        private TextBox textBoxCity;
        private Label labelCity;
        private TextBox textBoxAddress2;
        private TextBox textBoxAddress1;
        private Label labelAddress1;
        private TextBox textBoxZip;
        private Label labelZip;
    }
}