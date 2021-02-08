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
    public partial class ManagePayer : Form
    {
        public ManagePayer()
        {
            InitializeComponent();
        }

        public int PayerID = -1;
        private PaymentRecipient m_Payer;
        private List<PaymentSender> m_Payers;

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to save your changes?", "Update Payee", MessageBoxButtons.OKCancel)==DialogResult.OK)
            {
                if (PayerID >= 0 && PayerID <= m_Payers.Count)
                {
                    bool bsbParsed = int.TryParse($"{bsbTxt1.Text}{bsbTxt2.Text}", out int _bsb);
                    if (bsbParsed)
                    {
                        m_Payers[PayerID] = new PaymentSender(_bsb, textBox4.Text, textBox2.Text, textBox1.Text);
                        Properties.Settings.Default.Payers = JsonConvert.SerializeObject(m_Payers);
                        Properties.Settings.Default.Save();
                    }
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }

        private void ManagePayee_Load(object sender, EventArgs e)
        {
            m_Payers = JsonConvert.DeserializeObject<List<PaymentSender>>(Properties.Settings.Default.Payers);
            if(PayerID >=0 && PayerID <= m_Payers.Count)
            {
                m_Payer = m_Payers[PayerID];
                textBox1.Text = m_Payer.AccountName;
                bsbTxt1.Text = m_Payer.BSB.ToString("000000").Substring(0, 3);
                bsbTxt2.Text = m_Payer.BSB.ToString("000000").Substring(3, 3);
                textBox4.Text = m_Payer.AccountNumber;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
