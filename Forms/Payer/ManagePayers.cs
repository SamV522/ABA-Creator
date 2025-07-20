using Creator.ABA.Models;
using Creator.ABA.Models.Configuration;
using Creator.ABA.Services.Interfaces;
using System;
using System.Windows.Forms;

namespace Creator.ABA.Forms.Payer
{
    public partial class ManagePayers : Form
    {
        private IFormFactory _formFactory;
        private ISettingsProvider<AbaProfileSettings> _settingsProvider;

        private ManagePayer m_managePayer;
        private AddPayer m_addPayer;

        public ManagePayers(IFormFactory formFactory, ISettingsProvider<AbaProfileSettings> settingsProvider)
        {
            _formFactory = formFactory;
            _settingsProvider = settingsProvider;

            InitializeComponent();

            m_managePayer = _formFactory.CreateManagePayerForm();
            m_addPayer = _formFactory.CreateAddPayerForm();
        }

        private void ManagePayees_Load(object sender, EventArgs e)
        {
            UpdatePayers();
        }

        private void UpdatePayers()
        {
            listBox1.Items.Clear();
            
            if (_settingsProvider.Settings.Payers.Count <= 0) return;

            foreach (PaymentSender payer in _settingsProvider.Settings.Payers)
            {
                listBox1.Items.Add(payer.AccountName.ToUpper().PadRight(20 - payer.AccountName.Length) +
                                   $" - BSB: {payer.BSB} " +
                                   $"- Acc No: {payer.AccountNumber}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (m_managePayer.IsDisposed) m_managePayer = _formFactory.CreateManagePayerForm();
            m_managePayer.PayerID = listBox1.SelectedIndex;
            if (m_managePayer.ShowDialog() == DialogResult.OK)
            {
                UpdatePayers();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PaymentRecipient selectedPayer = _settingsProvider.Settings.Payers[listBox1.SelectedIndex];
            if(MessageBox.Show("Are you sure you want to remove this payer?\n"+
                                $"Acc Name: {selectedPayer.AccountName}\nBSB: {selectedPayer.BSB}\nAcc No: {selectedPayer.AccountNumber}",
                                "Remove Payer",MessageBoxButtons.OKCancel)==DialogResult.OK)
            {
                _settingsProvider.Settings.Payers.RemoveAt(listBox1.SelectedIndex);
                _settingsProvider.Save();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (m_addPayer.IsDisposed) m_addPayer = _formFactory.CreateAddPayerForm();
            if (m_addPayer.ShowDialog() == DialogResult.OK)
            {
                UpdatePayers();
            }
        }
    }
}
