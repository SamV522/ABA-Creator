using ABA_Creator.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;
using ABA_Creator.Forms.Payee;

namespace ABA_Creator.Forms.Payee
{
    public partial class ManagePayees : Form
    {
        private ManagePayee m_managePayee;
        private AddPayee m_addPayee;
        private List<PaymentRecipient> Payees;

        public ManagePayees()
        {
            InitializeComponent();
            m_managePayee = new ManagePayee();
            m_addPayee = new AddPayee();
            Payees = new List<PaymentRecipient>();
        }

        private void ManagePayees_Load(object sender, EventArgs e)
        {
            UpdatePayees();
        }

        private void UpdatePayees()
        {
            listBox1.Items.Clear();
            string SettingsPayee = Properties.Settings.Default.Payees;
            if (SettingsPayee.Length <= 0) return;
            Payees = JsonConvert.DeserializeObject<List<PaymentRecipient>>(Properties.Settings.Default.Payees);
            foreach (PaymentRecipient payee in Payees)
            {
                listBox1.Items.Add(payee.AccountName.ToUpper().PadRight(20 - payee.AccountName.Length) +
                                   $" - BSB: {payee.BSB} " +
                                   $"- Acc No: {payee.AccountNumber}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (m_managePayee.IsDisposed) m_managePayee = new ManagePayee();
            m_managePayee.PayeeID = listBox1.SelectedIndex;
            if (m_managePayee.ShowDialog() == DialogResult.OK)
            {
                UpdatePayees();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PaymentRecipient selectedPayee = Payees[listBox1.SelectedIndex];
            if(MessageBox.Show("Are you sure you want to remove this payee?\n"+
                                $"Acc Name: {selectedPayee.AccountName}\nBSB: {selectedPayee.BSB}\nAcc No: {selectedPayee.AccountNumber}",
                                "Remove Payee",MessageBoxButtons.OKCancel)==DialogResult.OK)
            {
                Payees.RemoveAt(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                Properties.Settings.Default.Payees = JsonConvert.SerializeObject(Payees);
                Properties.Settings.Default.Save();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (m_addPayee.IsDisposed) m_addPayee = new AddPayee();
            if (m_addPayee.ShowDialog() == DialogResult.OK)
            {
                UpdatePayees();
            }
        }
    }
}
