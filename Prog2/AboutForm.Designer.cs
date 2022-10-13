namespace UPVApp
{
    partial class AboutForm
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
            this.labelGradingId = new System.Windows.Forms.Label();
            this.labelAssignment = new System.Windows.Forms.Label();
            this.labelCourse = new System.Windows.Forms.Label();
            this.labelDueDate = new System.Windows.Forms.Label();
            this.textBoxGradingId = new System.Windows.Forms.TextBox();
            this.textBoxCourse = new System.Windows.Forms.TextBox();
            this.textBoxAssignment = new System.Windows.Forms.TextBox();
            this.textBoxDueDate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelGradingId
            // 
            this.labelGradingId.AutoSize = true;
            this.labelGradingId.Location = new System.Drawing.Point(19, 9);
            this.labelGradingId.Name = "labelGradingId";
            this.labelGradingId.Size = new System.Drawing.Size(63, 15);
            this.labelGradingId.TabIndex = 0;
            this.labelGradingId.Text = "Grading ID";
            // 
            // labelAssignment
            // 
            this.labelAssignment.AutoSize = true;
            this.labelAssignment.Location = new System.Drawing.Point(12, 80);
            this.labelAssignment.Name = "labelAssignment";
            this.labelAssignment.Size = new System.Drawing.Size(70, 15);
            this.labelAssignment.TabIndex = 1;
            this.labelAssignment.Text = "Assignment";
            // 
            // labelCourse
            // 
            this.labelCourse.AutoSize = true;
            this.labelCourse.Location = new System.Drawing.Point(38, 47);
            this.labelCourse.Name = "labelCourse";
            this.labelCourse.Size = new System.Drawing.Size(44, 15);
            this.labelCourse.TabIndex = 2;
            this.labelCourse.Text = "Course";
            // 
            // labelDueDate
            // 
            this.labelDueDate.AutoSize = true;
            this.labelDueDate.Location = new System.Drawing.Point(27, 122);
            this.labelDueDate.Name = "labelDueDate";
            this.labelDueDate.Size = new System.Drawing.Size(55, 15);
            this.labelDueDate.TabIndex = 3;
            this.labelDueDate.Text = "Due Date";
            // 
            // textBoxGradingId
            // 
            this.textBoxGradingId.Location = new System.Drawing.Point(88, 6);
            this.textBoxGradingId.Name = "textBoxGradingId";
            this.textBoxGradingId.ReadOnly = true;
            this.textBoxGradingId.Size = new System.Drawing.Size(138, 23);
            this.textBoxGradingId.TabIndex = 4;
            // 
            // textBoxCourse
            // 
            this.textBoxCourse.Location = new System.Drawing.Point(88, 44);
            this.textBoxCourse.Name = "textBoxCourse";
            this.textBoxCourse.ReadOnly = true;
            this.textBoxCourse.Size = new System.Drawing.Size(138, 23);
            this.textBoxCourse.TabIndex = 5;
            // 
            // textBoxAssignment
            // 
            this.textBoxAssignment.Location = new System.Drawing.Point(88, 77);
            this.textBoxAssignment.Name = "textBoxAssignment";
            this.textBoxAssignment.ReadOnly = true;
            this.textBoxAssignment.Size = new System.Drawing.Size(138, 23);
            this.textBoxAssignment.TabIndex = 6;
            // 
            // textBoxDueDate
            // 
            this.textBoxDueDate.Location = new System.Drawing.Point(88, 114);
            this.textBoxDueDate.Name = "textBoxDueDate";
            this.textBoxDueDate.ReadOnly = true;
            this.textBoxDueDate.Size = new System.Drawing.Size(138, 23);
            this.textBoxDueDate.TabIndex = 7;
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 170);
            this.Controls.Add(this.textBoxDueDate);
            this.Controls.Add(this.textBoxAssignment);
            this.Controls.Add(this.textBoxCourse);
            this.Controls.Add(this.textBoxGradingId);
            this.Controls.Add(this.labelDueDate);
            this.Controls.Add(this.labelCourse);
            this.Controls.Add(this.labelAssignment);
            this.Controls.Add(this.labelGradingId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AboutForm";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelGradingId;
        private Label labelAssignment;
        private Label labelCourse;
        private Label labelDueDate;
        private TextBox textBoxGradingId;
        private TextBox textBoxCourse;
        private TextBox textBoxAssignment;
        private TextBox textBoxDueDate;
    }
}