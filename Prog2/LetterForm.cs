using System.ComponentModel;

namespace UPVApp;

public partial class LetterForm : Form
{
    private readonly UserParcelView _upv;

    /// <summary>
    /// Create an instance of <see cref="LetterForm"/>.
    /// </summary>
    /// <param name="upv">The instance containing addresses and parcels.</param>
    public LetterForm(UserParcelView upv)
    {
        InitializeComponent();
        _upv = upv;

        var addressArr = upv.AddressList.ToArray(); // Memoize conversion
        comboBoxOrigin.Items.AddRange(addressArr);
        comboBoxDestination.Items.AddRange(addressArr);
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

        _upv.AddLetter((Address)comboBoxOrigin.SelectedItem,
            (Address)comboBoxDestination.SelectedItem,
            decimal.Parse(textBoxFixedCost.Text));

        Close();
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
    /// Run all validators associated with input fields.
    /// </summary>
    /// <returns>Returns whether current input is valid or not.</returns>
    private bool CheckValidators()
    {
        var cancelArgs = new CancelEventArgs();

        comboBox_Validating_AddressIndex(comboBoxOrigin, cancelArgs);
        comboBox_Validating_AddressIndex(comboBoxDestination, cancelArgs);
        textBox_Validating_DecimalPositive(textBoxFixedCost, cancelArgs);

        return !cancelArgs.Cancel;
    }

    /// <summary>
    /// Validates whether the <see cref="ComboBox"/>'s SelectedIndex property is in an invalid state if user did not select an index.
    /// Indicates failure to <see cref="errorProvider"/>.
    /// </summary>
    /// <param name="sender">The calling <see cref="Control"/> to validate.</param>
    /// <param name="e">Cancellation arguments to indicate failure or success.</param>
    private void comboBox_Validating_AddressIndex(object sender, CancelEventArgs e)
    {
        var comboBox = (ComboBox)sender;

        if (comboBox.SelectedIndex != -1) return;

        errorProvider.SetError(comboBox, "Must select an address");
        e.Cancel = true;
    }

    /// <summary>
    /// Validates whether the <see cref="TextBox"/>'s Text property is in an invalid state by checking if it is positive.
    /// Indicates failure to <see cref="errorProvider"/>.
    /// </summary>
    /// <param name="sender">The calling <see cref="Control"/> to validate.</param>
    /// <param name="e">Cancellation arguments to indicate failure or success.</param>
    private void textBox_Validating_DecimalPositive(object sender, CancelEventArgs e)
    {
        var textBox = (TextBox)sender;

        if (decimal.TryParse(textBox.Text, out decimal fixedCost)
            && fixedCost >= 0M) return;

        errorProvider.SetError(textBox, "Must be a valid, positive whole number");
        e.Cancel = true;
    }
}
