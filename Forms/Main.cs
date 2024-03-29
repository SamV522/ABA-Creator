﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Reflection;
using ABA_Creator.Entities;
using ABA_Creator.Entities.ABA;
using ABA_Creator.Forms;
using ABA_Creator.Forms.Payee;
using ABA_Creator.Forms.Payer;
using ABA_Creator.Forms.Transactions;

namespace ABA_Creator
{
    public partial class Main : Form
    {
        private AboutBox m_aboutBox;

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
            m_aboutBox = new AboutBox();
            m_addPayeeForm = new AddPayee();
            m_managePayeesForm = new ManagePayees();
            m_addPayerForm = new AddPayer();
            m_managePayersForm = new ManagePayers();
            m_setPayersForm = new SetActivePayer();
            m_addTransactionForm = new AddTransaction();
            m_Transactions = new List<DetailRecord>();
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            saveFileDialog1.InitialDirectory = Environment.CurrentDirectory;
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
            this.Text = $"{Application.ProductName} - {Application.ProductVersion}";
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

        private void setPayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_setPayersForm.IsDisposed) m_setPayersForm = new SetActivePayer();
            m_setPayersForm.Show();
            m_setPayersForm.BringToFront();
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            m_addTransactionForm.ShowDialog(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (m_addTransactionForm.ShowDialog(this) == DialogResult.OK)
            {
                AddTransaction(m_addTransactionForm.Transaction);
            }
        }

        public void AddTransaction(DetailRecord tranRecord)
        {
            this.m_Transactions.Add(tranRecord);
            UpdateTransactions();
        }

        public void RemoveTransaction(int id)
        {
            this.m_Transactions.RemoveAt(id);
            UpdateTransactions();
        }

        private void UpdateTransactions()
        {
            dgv_DetailRecord.Rows.Clear();
            foreach (DetailRecord tranRecord in m_Transactions.ToArray())
            {
                dgv_DetailRecord.Rows.Add(tranRecord.ToArray());
            }
            if(dgv_DescriptiveRecord.Rows.Count<1)
            {
                UpdateDescriptiveRecord();
            }
            UpdateFileTotalRecord();
        }

        private void SetTransactions(List<DetailRecord> records)
        {
            m_Transactions = records;
            UpdateTransactions();
        }

        private void openABAFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenABAFile();
        }

        private void testStringConsumeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void UpdateDescriptiveRecord()
        {
            PaymentSender _payer = Utilities.GetCurrentPayer();
            if(_payer !=null)
            {
                UpdateDescriptiveRecord(new DescriptiveRecord("01",
                                        new UserSupplyingFile(_payer.FinancialInstitution,
                                                              _payer.AccountName,
                                                              _payer.UserIdentificationNumber.PadLeft(6, '0'))));
            }
            else
            {
                MessageBox.Show("No payer has been selected, please set a payer from the Payers menu.", "No Payer!",MessageBoxButtons.OK);
            }
        }

        private void UpdateDescriptiveRecord(DescriptiveRecord record)
        {
            dgv_DescriptiveRecord.Rows.Clear();
            dgv_DescriptiveRecord.Rows.Add(record.ToArray());
            m_DescriptiveRecord = record;
        }

        private void ClearDescriptiveRecord()
        {
            dgv_DescriptiveRecord.Rows.Clear();
            m_DescriptiveRecord = null;
        }

        private void UpdateFileTotalRecord(FileTotalRecord record)
        {
            dgv_FileTotalRecord.Rows.Clear();
            dgv_FileTotalRecord.Rows.Add(record.ToArray());
            m_FileTotalRecord = record;
        }

        private void ClearFileTotalRecord()
        {
            dgv_FileTotalRecord.Rows.Clear();
            m_FileTotalRecord = null;
        }

        private void UpdateFileTotalRecord()
        {
            UpdateFileTotalRecord(new FileTotalRecord(m_Transactions));
        }

        private void ClearTransactions()
        {
            m_Transactions = new List<DetailRecord>();
            UpdateTransactions();
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
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string _aba = new ABAFile(m_DescriptiveRecord, m_Transactions, m_FileTotalRecord).ToString();
                StreamWriter sW = File.CreateText(saveFileDialog1.FileName);
                sW.Write(_aba);
                sW.Close();
            }
        }

        private void NewABAFile()
        {
            ClearDescriptiveRecord();
            ClearTransactions();
            ClearFileTotalRecord();
        }

        private void saveABAFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveABAFile();
        }

        private void dgv_DetailRecord_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (m_Transactions == null || m_Transactions.Count == 0 || m_Transactions.Count < e.RowIndex) return;
            m_Transactions[e.RowIndex] = new DetailRecord(RowToArray(dgv_DetailRecord.Rows[e.RowIndex]));
            UpdateTransactions();
        }

        private void dgv_DetailRecord_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
        }

        private string[] RowToArray(DataGridViewRow row)
        {
            string[] _ = new string[row.Cells.Count];
            int i = 0;
            foreach(DataGridViewCell cell in row.Cells)
            {
                if(cell.Value!=null)
                {
                    _[i] = cell.Value.ToString();
                }
                i++;
            }
            return _;
        }

        private void dgv_DetailRecord_Sorted(object sender, EventArgs e)
        {
            m_Transactions.Clear();
            foreach (DataGridViewRow row in dgv_DetailRecord.Rows)
            {
                m_Transactions.Add(new DetailRecord(RowToArray(row)));
            }
        }

        private void newABAFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewABAFile();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is not yet available", "Feature not available");
            /*if(dgv_DetailRecord.SelectedRows.Count>0)
            {
                foreach(DataGridViewRow row in dgv_DetailRecord.SelectedRows)
                {
                    dgv_DetailRecord.Rows.AddCopy(row.Index);
                }
            }*/
        }

        private void dgv_DetailRecord_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (m_Transactions == null || m_Transactions.Count == 0 || m_Transactions.Count < e.RowIndex) return;
            m_Transactions[e.RowIndex] = new DetailRecord(RowToArray(dgv_DetailRecord.Rows[e.RowIndex]));
        }

        private void dgv_DetailRecord_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            e.Cancel = true;
            if (!DeleteRows(e.Row));
        }

        private bool DeleteRows(DataGridViewRow row)
        {
            DataGridViewRow[] rows = new DataGridViewRow[1] { row };
            return DeleteRows(rows);
        }

        private bool DeleteRows(DataGridViewSelectedRowCollection selection)
        {
            DataGridViewRow[] rows = new DataGridViewRow[selection.Count];
            selection.CopyTo(rows, 0);
            return DeleteRows(rows);
        }

        private bool DeleteRows(DataGridViewRow[] rows)
        {
            bool _deleteRows = MessageBox.Show(
                $"Are you sure you want to delete {dgv_DetailRecord.SelectedRows.Count} row(s)?",
                "Delete Rows", MessageBoxButtons.OKCancel) == DialogResult.OK;
            if(_deleteRows)
            {
                foreach (DataGridViewRow row in dgv_DetailRecord.SelectedRows)
                {
                    m_Transactions.RemoveAt(row.Index);
                    dgv_DetailRecord.Rows.RemoveAt(row.Index);
                    UpdateTransactions();
                }
            }
            return _deleteRows;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(dgv_DetailRecord.SelectedRows.Count>0)
            {
                DeleteRows(dgv_DetailRecord.SelectedRows);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_aboutBox.Show();
        }
    }
}
