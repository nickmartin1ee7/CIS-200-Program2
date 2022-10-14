namespace UPVApp
{
    public partial class AboutForm : Form
    {
        /// <summary>
        /// Create a new instance of <see cref="AboutForm"/> with supplied arguments being set to controls' text.
        /// </summary>
        /// <param name="gradingId">Set to <see cref="textBoxGradingId"/>.Text.</param>
        /// <param name="course">Set to <see cref="textBoxCourse"/>.Text.</param>
        /// <param name="assignment">Set to <see cref="textBoxAssignment"/>.Text.</param>
        /// <param name="dueDate">Set only the date to <see cref="textBoxDueDate"/>.Text.</param>
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
