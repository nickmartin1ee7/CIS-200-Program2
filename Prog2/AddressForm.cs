using System.ComponentModel;

namespace UPVApp;

public partial class AddressForm : Form
{
    private readonly UserParcelView _upv;

    /// <summary>
    /// Create an instance of <see cref="AddressForm"/>.
    /// </summary>
    /// <param name="upv">The instance containing addresses and parcels.</param>
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
        if (!CheckValidators()) return; // Return on failed validation

        _upv.AddAddress(textBoxName.Text,
            textBoxAddress1.Text,
            textBoxCity.Text,
            comboBoxState.SelectedItem.ToString()!,
            int.Parse(textBoxZip.Text));

        Close();
    }

    /// <summary>
    /// Run all validators associated with input fields.
    /// </summary>
    /// <returns>Returns whether current input is valid or not.</returns>
    private bool CheckValidators()
    {
        var cancelArgs = new CancelEventArgs(); // Supplied to all validators

        textBox_Validating_NotNullOrWhiteSpace(textBoxName, cancelArgs);
        textBox_Validating_NotNullOrWhiteSpace(textBoxAddress1, cancelArgs);
        textBox_Validating_NotNullOrWhiteSpace(textBoxAddress2, cancelArgs);
        textBox_Validating_NotNullOrWhiteSpace(textBoxCity, cancelArgs);
        comboBoxState_Validating(comboBoxState, cancelArgs);
        textBoxZip_Validating(textBoxZip, cancelArgs);

        return !cancelArgs.Cancel; // Negate to better represent whether we should continue
    }

    /// <summary>
    /// Resets an error on a supplied control.
    /// </summary>
    /// <param name="control">The control to reset the error for.</param>
    private void ResetErrorProvider(Control control)
    {
        errorProvider.SetError(control, string.Empty);
    }

    /// <summary>
    /// The default validated event for any <see cref="Control"/>.
    /// </summary>
    /// <param name="sender">The calling <see cref="Control"/>.</param>
    /// <param name="e">Additional arguments.</param>
    private void control_Validated(object sender, EventArgs e)
    {
        ResetErrorProvider((Control)sender);
    }

    /// <summary>
    /// Validates whether the <see cref="TextBox"/>'s Text property is in an invalid state if user did not provide input or only whitespace.
    /// Indicates failure to <see cref="errorProvider"/>.
    /// </summary>
    /// <param name="sender">The calling <see cref="Control"/> to validate.</param>
    /// <param name="e">Cancellation arguments to indicate failure or success.</param>
    private void textBox_Validating_NotNullOrWhiteSpace(object sender, CancelEventArgs e)
    {
        var textBox = (TextBox)sender;
        if (!string.IsNullOrWhiteSpace(textBox.Text)) return;

        errorProvider.SetError(textBox, "Textbox cannot be empty");
        e.Cancel = true;
    }
    /// <summary>
    /// Validates whether the <see cref="ComboBox"/>'s SelectedIndex property is in an invalid state if user did not select an index.
    /// Indicates failure to <see cref="errorProvider"/>.
    /// </summary>
    /// <param name="sender">The calling <see cref="Control"/> to validate.</param>
    /// <param name="e">Cancellation arguments to indicate failure or success.</param>
    private void comboBoxState_Validating(object sender, CancelEventArgs e)
    {
        if (comboBoxState.SelectedIndex != -1) return;

        errorProvider.SetError(comboBoxState, "Must select a state");
        e.Cancel = true;
    }

    /// <summary>
    /// Validates whether the <see cref="textBoxZip"/>'s Text property is in an invalid state by checking if it is positive and within a max constraint.
    /// Indicates failure to <see cref="errorProvider"/>.
    /// </summary>
    /// <param name="sender">The calling <see cref="Control"/> to validate.</param>
    /// <param name="e">Cancellation arguments to indicate failure or success.</param>
    private void textBoxZip_Validating(object sender, CancelEventArgs e)
    {
        const int MAX_ZIP_CODE = 99_999;

        if (int.TryParse(textBoxZip.Text, out int zipCode)
            && zipCode >= 0
            && zipCode <= MAX_ZIP_CODE) return;

        errorProvider.SetError(textBoxZip, $"{labelZip.Text} must be a valid, positive whole number");
        e.Cancel = true;
    }
}
