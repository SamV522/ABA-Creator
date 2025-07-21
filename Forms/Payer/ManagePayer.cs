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
    public partial class ManagePayer : Form
    {
        private ISettingsProvider<AbaProfileSettings> _settingsProvider;
        private readonly IBsbValidationHelper _bsbValidationHelper;

        public int PayerID = -1;
        private PaymentRecipient m_Payer;
        private List<PaymentSender> m_Payers;

        public ManagePayer(ISettingsProvider<AbaProfileSettings> settingsProvider, IBsbValidationHelper bsbValidationHelper)
        {
            _settingsProvider = settingsProvider;
            _bsbValidationHelper = bsbValidationHelper;

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to save your changes?", "Update Payee", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (PayerID >= 0 && PayerID <= m_Payers.Count)
                {
                    bool bsbParsed = int.TryParse($"{txt_Bsb.Text}", out int _bsb);
                    if (bsbParsed)
                    {
                        _settingsProvider.Settings.Payers[PayerID] = new PaymentSender(_bsb, txt_AccountNumber.Text, txt_FICode.Text, txt_AccountName.Text);

                        _settingsProvider.Save();
                    }
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }

        private void ManagePayee_Load(object sender, EventArgs e)
        {
            if (_settingsProvider.Settings.Payers[PayerID] != null)
            {
                m_Payer = _settingsProvider.Settings.Payers[PayerID];
                txt_AccountName.Text = m_Payer.AccountName;
                txt_Bsb.Text = m_Payer.BSB.ToString("000-000");
                txt_AccountNumber.Text = m_Payer.AccountNumber;
            }
            else
            {
                MessageBox.Show(
                    "Something went wrong and the payer could not be found.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void Btn_ValidateBsb_Click(object sender, EventArgs e)
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
