using Creator.ABA.Models;
using Creator.ABA.Models.ABA;
using Creator.ABA.Models.Configuration;
using Creator.ABA.Services.Interfaces;
using System;
using System.Windows.Forms;

namespace Creator.ABA.Forms.Transactions
{
    public partial class AddTransaction : Form
    {
        private ISettingsProvider<AbaProfileSettings> _settingsProvider;

        public DetailRecord Transaction { get; private set; }

        public AddTransaction(ISettingsProvider<AbaProfileSettings> settingsProvider)
        {
            _settingsProvider = settingsProvider;

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Transaction = new DetailRecord(_settingsProvider.Settings.ActivePayer,
                                                        _settingsProvider.Settings.Payees[cmbo_Payees.SelectedIndex],
                                                        " ",
                                                        (int)nmc_Amount.Value,
                                                        (int)nmc_Tax.Value,
                                                        txt_LodgementRef.Text,
                                                        txt_Remitter.Text);
            // This will fail if this form is not opened using ShowDialog
            ((Main)this.Owner).AddTransaction(Transaction);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void AddTransaction_Load(object sender, EventArgs e)
        {
            foreach (PaymentRecipient Payee in _settingsProvider.Settings.Payees)
            {
                cmbo_Payees.Items.Add(Payee.ToString());
            }
            if (cmbo_Payees.Items.Count > 0) cmbo_Payees.SelectedIndex = 0;
            cmbo_TranCode.SelectedIndex = 0;
        }
    }
}
