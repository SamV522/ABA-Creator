using Creator.ABA.Models;
using Creator.ABA.Models.Configuration;
using Creator.ABA.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Creator.ABA.Forms.Payee
{
    public partial class ManagePayees : Form
    {
        private IFormFactory _formFactory;
        private ISettingsProvider<AbaProfileSettings> _settingsProvider;

        private ManagePayee m_managePayee;
        private AddPayee m_addPayee;
        private List<PaymentRecipient> Payees;

        public ManagePayees(IFormFactory formFactory, ISettingsProvider<AbaProfileSettings> settingsProvider)
        {
            _settingsProvider = settingsProvider;
            _formFactory = formFactory;

            InitializeComponent();
            m_managePayee = _formFactory.CreateManagePayeeForm();
            m_addPayee = _formFactory.CreateAddPayeeForm();
            Payees = new List<PaymentRecipient>();
        }

        private void ManagePayees_Load(object sender, EventArgs e)
        {
            UpdatePayees();
        }

        private void UpdatePayees()
        {
            foreach (PaymentRecipient payee in _settingsProvider.Settings.Payees)
            {
                lst_Payees.Items.Add(payee.AccountName.ToUpper().PadRight(20) +
                                   $" - BSB: {payee.BSB} " +
                                   $"- Acc No: {payee.AccountNumber}");
            }
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            if (m_managePayee.IsDisposed) m_managePayee = _formFactory.CreateManagePayeeForm();
            m_managePayee.PayeeID = lst_Payees.SelectedIndex;
            if (m_managePayee.ShowDialog() == DialogResult.OK)
            {
                UpdatePayees();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PaymentRecipient selectedPayee = _settingsProvider.Settings.Payees[lst_Payees.SelectedIndex];
            if(MessageBox.Show("Are you sure you want to remove this payee?\n"+
                                $"Acc Name: {selectedPayee.AccountName}\nBSB: {selectedPayee.BSB}\nAcc No: {selectedPayee.AccountNumber}",
                                "Remove Payee",MessageBoxButtons.OKCancel)==DialogResult.OK)
            {
                _settingsProvider.Settings.Payees.RemoveAt(lst_Payees.SelectedIndex);
                lst_Payees.Items.RemoveAt(lst_Payees.SelectedIndex);
                _settingsProvider.Save();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (m_addPayee.IsDisposed) m_addPayee = _formFactory.CreateAddPayeeForm();
            if (m_addPayee.ShowDialog() == DialogResult.OK)
            {
                UpdatePayees();
            }
        }
    }
}
