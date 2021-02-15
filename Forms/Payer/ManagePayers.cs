using ABA_Creator.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ABA_Creator.Forms.Payer
{
    public partial class ManagePayers : Form
    {
        private ManagePayer m_managePayer;
        private AddPayer m_addPayer;
        private List<PaymentSender> Payers;

        public ManagePayers()
        {
            InitializeComponent();
            m_managePayer = new ManagePayer();
            m_addPayer = new AddPayer();
            Payers = new List<PaymentSender>();
        }

        private void ManagePayees_Load(object sender, EventArgs e)
        {
            UpdatePayers();
        }

        private void UpdatePayers()
        {
            listBox1.Items.Clear();
            string SettingsPayee = Properties.Settings.Default.Payers;
            if (SettingsPayee.Length <= 0) return;
            Payers = JsonConvert.DeserializeObject<List<PaymentSender>>(Properties.Settings.Default.Payers);
            foreach (PaymentSender payer in Payers)
            {
                listBox1.Items.Add(payer.AccountName.ToUpper().PadRight(20 - payer.AccountName.Length) +
                                   $" - BSB: {payer.BSB} " +
                                   $"- Acc No: {payer.AccountNumber}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (m_managePayer.IsDisposed) m_managePayer = new ManagePayer();
            m_managePayer.PayerID = listBox1.SelectedIndex;
            if (m_managePayer.ShowDialog() == DialogResult.OK)
            {
                UpdatePayers();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PaymentRecipient selectedPayer = Payers[listBox1.SelectedIndex];
            if(MessageBox.Show("Are you sure you want to remove this payer?\n"+
                                $"Acc Name: {selectedPayer.AccountName}\nBSB: {selectedPayer.BSB}\nAcc No: {selectedPayer.AccountNumber}",
                                "Remove Payer",MessageBoxButtons.OKCancel)==DialogResult.OK)
            {
                Payers.RemoveAt(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                Properties.Settings.Default.Payers = JsonConvert.SerializeObject(Payers);
                Properties.Settings.Default.Save();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (m_addPayer.IsDisposed) m_addPayer = new AddPayer();
            if (m_addPayer.ShowDialog() == DialogResult.OK)
            {
                UpdatePayers();
            }
        }
    }
}
