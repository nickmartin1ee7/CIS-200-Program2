namespace UPVApp
{
    public partial class Prog2Form : Form
    {
        private readonly UserParcelView _upv;

        public Prog2Form()
        {
            InitializeComponent();

            _upv = CreateAndPopulateUserParcelView();
        }

        private UserParcelView CreateAndPopulateUserParcelView()
        {
            var upv = new UserParcelView();

            upv.AddAddress("Test 1", "123 Test Rd.", "Louisville", "KY", 40220);
            upv.AddAddress("Test 2", "234 Test Rd.", "Louisville", "KY", 40221);
            upv.AddAddress("Test 3", "567 Unit Ln.", "Huston", "TX", 77001);
            upv.AddAddress("Test 4", "890 Unit Ln.", "Huston", "TX", 77002);
            upv.AddAddress("Test 5", "1010 Binary Blv.", "Tampa", "FL", 33602);
            upv.AddAddress("Test 6", "0101 Binary Blv.", "Tampa", "FL", 33603);

            return upv;
        }

        /// <summary>
        /// Cleanly exits the application when invoked.
        /// </summary>
        /// <param name="sender">The invoking <see cref="Form"/>.</param>
        /// <param name="e">The boxed Event Args.</param>
        private void toolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItemAbout_Click(object sender, EventArgs e)
        {
            var aboutForm = new AboutForm("5111752",
                "CIS-200-75",
                "Program 2",
                new DateTime(2022, 10, 24));

            aboutForm.Show(this);
        }
    }
}
