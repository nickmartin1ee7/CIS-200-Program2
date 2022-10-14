namespace UPVApp
{
    public partial class AboutForm : Form
    {
        public AboutForm(string gradingId, string course, string assignment, DateTime dueDate)
        {
            InitializeComponent();

            textBoxGradingId.Text = gradingId;
            textBoxCourse.Text = course;
            textBoxAssignment.Text = assignment;
            textBoxDueDate.Text = dueDate.ToShortDateString();
        }
    }
}
