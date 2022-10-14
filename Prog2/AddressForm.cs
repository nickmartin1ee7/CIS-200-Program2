using System.ComponentModel;

namespace UPVApp
{
    public partial class AddressForm : Form
    {
        private readonly UserParcelView _upv;

        public AddressForm(UserParcelView upv)
        {
            InitializeComponent();
            _upv = upv;
        }

        /// <summary>
        /// Gracefully close form.
        /// </summary>
        /// <param name="sender">The invoking <see cref="Form"/>.</param>
        /// <param name="e">The boxed Event Args.</param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Assigns user-supplied information into <see cref="UserParcelView"/>, and gracefully closes.
        /// </summary>
        /// <param name="sender">The invoking <see cref="Form"/>.</param>
        /// <param name="e">The boxed Event Args.</param>
        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (!CheckValidators()) return; // Failed validation

            _upv.AddAddress(textBoxName.Text,
                textBoxAddress1.Text,
                textBoxCity.Text,
                comboBoxState.SelectedItem.ToString(),
                int.Parse(textBoxZip.Text));

            Close();
        }

        /// <summary>
        /// Run all validators associated with input fields.
        /// </summary>
        /// <returns>Returns whether current input is valid or not.</returns>
        private bool CheckValidators()
        {
            var cancelArgs = new CancelEventArgs();

            textBox_Validating_NotNullOrWhiteSpace(textBoxName, cancelArgs);
            textBox_Validating_NotNullOrWhiteSpace(textBoxAddress1, cancelArgs);
            textBox_Validating_NotNullOrWhiteSpace(textBoxAddress2, cancelArgs);
            textBox_Validating_NotNullOrWhiteSpace(textBoxCity, cancelArgs);
            comboBoxState_Validating(comboBoxState, cancelArgs);
            textBoxZip_Validating(textBoxZip, cancelArgs);

            return !cancelArgs.Cancel;
        }

        private void ResetErrorProvider(Control control)
        {
            errorProvider.SetError(control, string.Empty);
        }

        private void control_Validated(object sender, EventArgs e)
        {
            ResetErrorProvider((Control)sender);
        }

        private void textBox_Validating_NotNullOrWhiteSpace(object sender, CancelEventArgs e)
        {
            var textBox = (TextBox)sender;
            if (!string.IsNullOrWhiteSpace(textBox.Text)) return;

            errorProvider.SetError(textBox, "Textbox cannot be empty");
            e.Cancel = true;
        }

        private void comboBoxState_Validating(object sender, CancelEventArgs e)
        {
            if (comboBoxState.SelectedIndex != -1) return;

            errorProvider.SetError(comboBoxState, "Must select a state");
            e.Cancel = true;
        }

        private void textBoxZip_Validating(object sender, CancelEventArgs e)
        {
            const int MAX_ZIP_CODE = 99999;

            if (int.TryParse(textBoxZip.Text, out int zipCode)
                && zipCode >= 0
                && zipCode <= MAX_ZIP_CODE) return;

            errorProvider.SetError(textBoxZip, $"{labelZip.Text} must be a valid, positive whole number");
            e.Cancel = true;

        }
    }
}
