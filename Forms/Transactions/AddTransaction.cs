using ABA_Creator.Entities;
using ABA_Creator.Entities.ABA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABA_Creator.Forms.Transactions
{
    public partial class AddTransaction : Form
    {
        public DetailRecord Transaction { get; private set; }

        public AddTransaction()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Transaction = new DetailRecord(Utilities.GetCurrentPayer(),
                                                        Utilities.GetPayeeFromID(cmbo_Payees.SelectedIndex),
                                                        " ",
                                                        (int)nmc_Amount.Value,
                                                        (int)nmc_Tax.Value,
                                                        txt_LodgementRef.Text,
                                                        txt_Remitter.Text);
            // This will fail if this form is not opened using ShowDialog
            //((Main)this.Owner).AddTransaction(TranRecord);
            //((Main)this.Owner).m_Transactions.Add(TranRecord);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void AddTransaction_Load(object sender, EventArgs e)
        {
            List<PaymentRecipient> _Payees = Utilities.GetPayees();
            foreach (PaymentRecipient Payee in _Payees)
            {
                cmbo_Payees.Items.Add(Payee.ToString());
            }
            if (cmbo_Payees.Items.Count > 0) cmbo_Payees.SelectedIndex = 0;
            cmbo_TranCode.SelectedIndex = 0;
        }
    }
}
