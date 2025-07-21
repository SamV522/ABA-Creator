using Creator.ABA.Helpers;
using Creator.ABA.Helpers.Interfaces;
using Creator.ABA.Models;
using Creator.ABA.Models.Configuration;
using Creator.ABA.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Creator.ABA.Forms.Payer
{
    public partial class AddPayer : Form
    {
        ISettingsProvider<AbaProfileSettings> _settingsProvider;
        IBsbValidationHelper _bsbValidationHelper;

        public AddPayer(ISettingsProvider<AbaProfileSettings> settingsProvider, IBsbValidationHelper bsbValidationHelper)
        {
            _settingsProvider = settingsProvider;
            _bsbValidationHelper = bsbValidationHelper;

            InitializeComponent();
        }

        private void AddPayee_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void alpha_Validation(object sender, KeyPressEventArgs e)
        {
            //// https://stackoverflow.com/questions/12607087/only-allow-specific-characters-in-textbox //
            // Check for a naughty character in the KeyDown event.
            if (e.KeyChar.ToString() == "")
            {
                e.Handled = false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"^[a-zA-Z ]"))
            {
                // Stop the character from being entered into the control since it is illegal.
                e.Handled = true;
            }
        }

        private void numeric_Validation(object sender, KeyPressEventArgs e)
        {
            //// https://stackoverflow.com/questions/12607087/only-allow-specific-characters-in-textbox //
            // Check for a naughty character in the KeyDown event.
            if (e.KeyChar.ToString() == "")
            {
                e.Handled = false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"^[0-9]"))
            {
                // Stop the character from being entered into the control since it is illegal.
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Add payee to list of payees.
            //List<PaymentRecipient> Payees = JsonMapper.ToObject(Properties.Settings.Default.Payees);
            bool bsbParsed = int.TryParse($"{txt_Bsb.Text}", out int _bsb);
            if (bsbParsed)
            {
                PaymentSender newSender = new PaymentSender(_bsb, txt_AccountNumber.Text, txt_FICode.Text, txt_AccountName.Text, txt_UserID.Text);
                List<PaymentSender> Payers;
                try
                {
                    if (_settingsProvider.Settings.Payers == null)
                    {
                        _settingsProvider.Settings.Payers = new List<PaymentSender>() { newSender };
                    }
                    else
                    {
                        if (_settingsProvider.Settings.Payers.Contains(newSender))
                        {
                            MessageBox.Show("Payer already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            _settingsProvider.Settings.Payers.Add(newSender);
                        }
                    }

                    _settingsProvider.Save();

                    if (MessageBox.Show($"Payer added by account name: {newSender.AccountName}", "Payer Added", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            var validationResult = await _bsbValidationHelper.IsValidBsb($"{txt_Bsb.Text}");

            switch (validationResult.ResultType)
            {
                case BsbValidationResultType.UnableToValidate:
                    MessageBox.Show("Unable to validate BSB at this time. Please try again later.", "Unable to Validate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case BsbValidationResultType.InvalidFormat:
                    MessageBox.Show("BSB is not in a valid format. Please enter a 6-digit BSB.", "Invalid BSB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case BsbValidationResultType.NoMatch:
                    MessageBox.Show("BSB does not match any known financial institutions. Please check the BSB and try again.", "No Match", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case BsbValidationResultType.MultipleMatches:
                    MessageBox.Show("BSB matches multiple financial institutions. Please check the bsb and try again.", "Multiple Matches", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case BsbValidationResultType.SingleMatch:
                    txt_FICode.Text = validationResult.Matches[0].FiMnemonic;
                    MessageBox.Show("BSB has been validated successfully.", "BSB Validated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }
    }
}
