using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ABA_Creator.Entities;
using ABA_Creator.Entities.ABA;
using ABA_Creator.Forms.Payee;
using ABA_Creator.Forms.Payer;
using ABA_Creator.Forms.Transactions;

namespace ABA_Creator
{
    public partial class Main : Form
    {
        private AddPayee m_addPayeeForm;
        private ManagePayees m_managePayeesForm;

        private AddPayer m_addPayerForm;
        private ManagePayers m_managePayersForm;
        private SetActivePayer m_setPayersForm;

        private AddTransaction m_addTransactionForm;

        public DescriptiveRecord m_DescriptiveRecord;
        public List<DetailRecord> m_Transactions;
        public FileTotalRecord m_FileTotalRecord;

        public Main()
        {
            InitializeComponent();
            m_addPayeeForm = new AddPayee();
            m_managePayeesForm = new ManagePayees();
            m_addPayerForm = new AddPayer();
            m_managePayersForm = new ManagePayers();
            m_setPayersForm = new SetActivePayer();
            m_addTransactionForm = new AddTransaction();
            m_Transactions = new List<DetailRecord>();
            openFileDialog1.InitialDirectory = System.Environment.CurrentDirectory;
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_addPayeeForm.IsDisposed) m_addPayeeForm = new AddPayee();
            m_addPayeeForm.Show();
            m_addPayeeForm.BringToFront();
        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_managePayeesForm.IsDisposed) m_managePayeesForm = new ManagePayees();
            m_managePayeesForm.Show();
            m_managePayeesForm.BringToFront();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void searchBSBsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://bsb.apca.com.au/");
        }

        private void managePayersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_managePayersForm.IsDisposed) m_managePayersForm = new ManagePayers();
            m_managePayersForm.Show();
            m_managePayersForm.BringToFront();
        }

        private void newPayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_addPayerForm.IsDisposed) m_addPayerForm = new AddPayer();
            m_addPayerForm.Show();
            m_addPayerForm.BringToFront();
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void setPayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_setPayersForm.IsDisposed) m_setPayersForm = new SetActivePayer();
            m_setPayersForm.Show();
            m_setPayersForm.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            m_addTransactionForm.ShowDialog(this);
        }

        public void AddTransaction(DetailRecord tranRecord)
        {
            this.m_Transactions.Add(tranRecord);
            UpdateTransactionListBox();
        }

        public void RemoveTransaction(int id)
        {
            this.m_Transactions.RemoveAt(id);
            UpdateTransactionListBox();
        }

        private void UpdateTransactionListBox()
        {
            dgv_DetailRecord.Rows.Clear();
            foreach(DetailRecord tranRecord in m_Transactions)
            {
                dgv_DetailRecord.Rows.Add(tranRecord.ToArray());
            }
        }

        private void SetTransactions(List<DetailRecord> records)
        {
            m_Transactions = records;
            UpdateTransactionListBox();
        }
        
        private void UpdateDescriptiveRecord(DescriptiveRecord record)
        {
            dgv_DescriptiveRecord.Rows.Clear();
            dgv_DescriptiveRecord.Rows.Add(record.ToArray());
            m_DescriptiveRecord = record;
        }

        private void openABAFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenABAFile();
        }

        private void testStringConsumeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void UpdateFileTotalRecord(FileTotalRecord record)
        {
            dgv_FileTotalRecord.Rows.Clear();
            dgv_FileTotalRecord.Rows.Add(record.ToArray());
            m_FileTotalRecord = record;
        }

        private void UpdateFileTotalRecord()
        {
            UpdateFileTotalRecord(new FileTotalRecord(m_Transactions));
        }

        private void ClearTransactions()
        {
            m_Transactions = new List<DetailRecord>();
            UpdateTransactionListBox();
        }

        private void OpenABAFile()
        {
            ClearTransactions();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show(openFileDialog1.FileName);
                ABAFile _aba = new ABAFile(openFileDialog1.FileName);
                UpdateDescriptiveRecord(_aba.descriptiveRecord);
                SetTransactions(_aba.detailRecords);
                UpdateFileTotalRecord(_aba.fileTotalRecord);
            }
        }

        private void SaveABAFile()
        {
            MessageBox.Show(new ABAFile(m_DescriptiveRecord, m_Transactions, m_FileTotalRecord).ToString());

        }

        private void saveABAFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveABAFile();
        }
    }
}
