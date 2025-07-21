using Creator.ABA.Helpers;
using Creator.ABA.Helpers.Interfaces;
using Creator.ABA.Models;
using Creator.ABA.Models.Configuration;
using Creator.ABA.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Creator.ABA.Forms.Payee
{
    public partial class ManagePayee : Form
    {
        private ISettingsProvider<AbaProfileSettings> _settingsProvider;
        private IBsbValidationHelper _bsbValidationHelper;

        public ManagePayee(ISettingsProvider<AbaProfileSettings> settingsProvider, IBsbValidationHelper bsbValidationHelper)
        {
            _settingsProvider = settingsProvider;
            _bsbValidationHelper = bsbValidationHelper;

            InitializeComponent();
        }

        public int PayeeID = -1;
        private PaymentRecipient m_Payee;
        private List<PaymentRecipient> m_Payees;

        private void Btn_SavePayee_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to save your changes?", "Update Payee", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (PayeeID >= 0 && PayeeID <= m_Payees.Count)
                {
                    bool bsbParsed = int.TryParse($"{txt_Bsb.Text}", out int _bsb);
                    if (bsbParsed)
                    {
                        // Update existing payee
                        _settingsProvider.Settings.Payees[PayeeID] = new PaymentRecipient(_bsb, txt_AccountNumber.Text, txt_AccountName.Text);

                        _settingsProvider.Save();
                    }
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }

        private void ManagePayee_Load(object sender, EventArgs e)
        {
            if (_settingsProvider.Settings.Payees[PayeeID] != null)
            {
                m_Payee = _settingsProvider.Settings.Payees[PayeeID];
                txt_AccountName.Text = m_Payee.AccountName;
                txt_Bsb.Text = m_Payee.BSB.ToString("000-000");
                txt_AccountNumber.Text = m_Payee.AccountNumber;
            }
            else
            {
                MessageBox.Show(
                    "Something went wrong and the payee could not be found.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                this.Close();
            }
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btn_ValidateBsb_Click(object sender, EventArgs e)
        {
            var validationResult = await _bsbValidationHelper.IsValidBsb($"{txt_Bsb.Text}");

            switch (validationResult.ResultType)
            {
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
                    MessageBox.Show("BSB has been validated successfully.", "BSB Validated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }
    }
}
