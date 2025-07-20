using Creator.ABA.Models;
using Creator.ABA.Models.Configuration;
using Creator.ABA.Services.Interfaces;
using System;
using System.Windows.Forms;

namespace Creator.ABA.Forms.Payer
{
    public partial class SetActivePayer : Form
    {
        private readonly ISettingsProvider<AbaProfileSettings> _settingsProvider;

        private PaymentSender m_selectedPayer;

        public SetActivePayer(ISettingsProvider<AbaProfileSettings> settingsProvider)
        {
            _settingsProvider = settingsProvider;

            InitializeComponent();
        }

        private void SetActivePayer_Load(object sender, EventArgs e)
        {
            UpdatePayers();
            if(_settingsProvider.Settings.ActivePayer != null)
            {
                listBox1.SelectedIndex = _settingsProvider.Settings.Payers.IndexOf(_settingsProvider.Settings.ActivePayer);
            }
        }

        private void UpdatePayers()
        {
            foreach(PaymentSender Payer in _settingsProvider.Settings.Payers)
            {
                listBox1.Items.Add($"{Payer.AccountName.PadRight(20 - Payer.AccountName.Length)} - BSB: {Payer.BSB} - Acc: {Payer.AccountNumber}");
            }
        }

        private void Btn_OK_Click(object sender, EventArgs e)
        {
            if (m_selectedPayer == null) return;


            if (MessageBox.Show("Are you sure you want to set active payer to the following:\n\n" +
                            m_selectedPayer.AccountName +
                            $"\nBSB: {m_selectedPayer.BSB}" +
                            $"\nAcc: {m_selectedPayer.AccountNumber}", "Set Active Payer", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _settingsProvider.Settings.ActivePayer = m_selectedPayer;

                _settingsProvider.Save();
                this.Close();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0 && listBox1.SelectedIndex <= _settingsProvider.Settings.Payers.Count)
            {
                m_selectedPayer = _settingsProvider.Settings.Payers[listBox1.SelectedIndex];
            }
            else
            {
                m_selectedPayer = null;
            }
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
