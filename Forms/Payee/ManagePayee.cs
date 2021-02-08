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

namespace ABA_Creator.Forms.Payee
{
    public partial class ManagePayee : Form
    {
        public ManagePayee()
        {
            InitializeComponent();
        }

        public int PayeeID = -1;
        private PaymentRecipient m_Payee;
        private List<PaymentRecipient> m_Payees;

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to save your changes?", "Update Payee", MessageBoxButtons.OKCancel)==DialogResult.OK)
            {
                if (PayeeID >= 0 && PayeeID <= m_Payees.Count)
                {
                    bool bsbParsed = int.TryParse($"{bsbTxt1.Text}{bsbTxt2.Text}", out int _bsb);
                    if (bsbParsed)
                    {
                        m_Payees[PayeeID] = new PaymentRecipient(_bsb, textBox4.Text, textBox1.Text);
                        Properties.Settings.Default.Payees = JsonConvert.SerializeObject(m_Payees);
                        Properties.Settings.Default.Save();
                    }
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }

        private void ManagePayee_Load(object sender, EventArgs e)
        {
            m_Payees = JsonConvert.DeserializeObject<List<PaymentRecipient>>(Properties.Settings.Default.Payees);
            if(PayeeID >=0 && PayeeID <= m_Payees.Count)
            {
                m_Payee = m_Payees[PayeeID];
                textBox1.Text = m_Payee.AccountName;
                bsbTxt1.Text = m_Payee.BSB.ToString("000000").Substring(0, 3);
                bsbTxt2.Text = m_Payee.BSB.ToString("000000").Substring(3, 3);
                textBox4.Text = m_Payee.AccountNumber;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
