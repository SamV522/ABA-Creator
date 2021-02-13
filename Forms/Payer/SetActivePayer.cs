using ABA_Creator.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABA_Creator.Forms.Payer
{
    public partial class SetActivePayer : Form
    {
        private List<PaymentSender> m_Payers;
        private PaymentSender m_selectedPayer;
        private int m_selectedPayerID = -1;

        public SetActivePayer()
        {
            InitializeComponent();
        }

        private void SetActivePayer_Load(object sender, EventArgs e)
        {
            UpdatePayers();
            if(Properties.Settings.Default.ActivePayer>=0 && Properties.Settings.Default.ActivePayer <= m_Payers.Count)
            {
                listBox1.SelectedIndex = Properties.Settings.Default.ActivePayer;
            }
        }

        private void UpdatePayers()
        {
            m_Payers = JsonConvert.DeserializeObject<List<PaymentSender>>(Properties.Settings.Default.Payers);
            m_Payers = (m_Payers == null ? new List<PaymentSender>() : m_Payers);
            foreach(PaymentSender Payer in m_Payers)
            {
                listBox1.Items.Add($"{Payer.AccountName.PadRight(20 - Payer.AccountName.Length)} - BSB: {Payer.BSB} - Acc: {Payer.AccountNumber}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            if(m_selectedPayer !=null && m_selectedPayerID != Properties.Settings.Default.ActivePayer)
            {
                if (MessageBox.Show("Are you sure you want to set active payer to:\n" +
                                m_selectedPayer.AccountName +
                                $"\nBSB: {m_selectedPayer.BSB}" +
                                $"\nAcc: {m_selectedPayer.AccountNumber}", "Set Active Payer", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    Properties.Settings.Default.ActivePayer = m_selectedPayerID;
                    Properties.Settings.Default.Save();
                    this.Close();
                }
                else
                {
                    m_selectedPayerID = Properties.Settings.Default.ActivePayer;
                    listBox1.SelectedIndex = Properties.Settings.Default.ActivePayer;
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0 && listBox1.SelectedIndex <= m_Payers.Count)
            {
                m_selectedPayer = m_Payers[listBox1.SelectedIndex];
                m_selectedPayerID = listBox1.SelectedIndex;
            }
            else
            {
                m_selectedPayer = null;
                m_selectedPayerID = -1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
