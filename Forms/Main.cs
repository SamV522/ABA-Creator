using Creator.ABA.Extensions;
using Creator.ABA.Forms;
using Creator.ABA.Forms.Payee;
using Creator.ABA.Forms.Payer;
using Creator.ABA.Forms.Transactions;
using Creator.ABA.Helpers;
using Creator.ABA.Helpers.Interfaces;
using Creator.ABA.Models;
using Creator.ABA.Models.ABA;
using Creator.ABA.Models.Configuration;
using Creator.ABA.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Creator.ABA
{
    public partial class Main : Form
    {
        private readonly ISettingsProvider<AbaProfileSettings> _settingsProvider;
        private readonly IFormFactory _formFactory;
        private readonly IBsbValidationHelper _bsbValidationHelper;

        private readonly AboutBox m_aboutBox;

        private AddPayee m_addPayeeForm;
        private ManagePayees m_managePayeesForm;

        private AddPayer m_addPayerForm;
        private ManagePayers m_managePayersForm;
        private SetActivePayer m_setPayersForm;

        private readonly AddTransaction m_addTransactionForm;

        public DescriptiveRecord m_DescriptiveRecord;
        public List<DetailRecord> m_Transactions;
        public FileTotalRecord m_FileTotalRecord;

        public Main(IFormFactory formFactory, 
            ISettingsProvider<AbaProfileSettings> settingsProvider, 
            IBsbValidationHelper bsbValidationHelper)
        {
            _settingsProvider = settingsProvider;
            _formFactory = formFactory;
            _bsbValidationHelper = bsbValidationHelper;

            InitializeComponent();

            m_aboutBox = new AboutBox();
            m_addPayeeForm = _formFactory.CreateAddPayeeForm();
            m_managePayeesForm = _formFactory.CreateManagePayeesForm();
            m_addPayerForm = _formFactory.CreateAddPayerForm();
            m_managePayersForm = _formFactory.CreateManagePayersForm();
            m_setPayersForm = _formFactory.CreateSetActivePayerForm();
            m_addTransactionForm = _formFactory.CreateAddTransactionForm();

            m_Transactions = new List<DetailRecord>();

            dlg_OpenAbaFile.InitialDirectory = Environment.CurrentDirectory;
            dlg_SaveAbaFile.InitialDirectory = Environment.CurrentDirectory;
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_addPayeeForm.IsDisposed) m_addPayeeForm = _formFactory.CreateAddPayeeForm();
            m_addPayeeForm.Show();
            m_addPayeeForm.BringToFront();
        }

        private void ManageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_managePayeesForm.IsDisposed) m_managePayeesForm = _formFactory.CreateManagePayeesForm();
            m_managePayeesForm.Show();
            m_managePayeesForm.BringToFront();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }

        private void LoadSettings(string filePath = null)
        {
            // Load settings
            try
            {
                _settingsProvider.Settings.PropertyChanged -= Settings_PropertyChanged; // Unsubscribe to avoid duplicate events

                _settingsProvider.Load(filePath);

                // Susbcribe to settings property changed event
                _settingsProvider.Settings.PropertyChanged += Settings_PropertyChanged;
            }
            catch (FileNotFoundException)
            {
                // If the settings file is not found, prompt the user to configure the payer(s)
                var result = MessageBox.Show("Settings file not found. You will need to configure your payer(s) and set your active payer.", "Settings Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (AggregateValidationException ex)
            {
                // If the settings file is not valid, show validation errors
                MessageBox.Show("Failed to validate settings file, if you wish to load settings please correct the below errors and load the file again.\n\n" +
                    string.Join("\n", ex.ValidationResults.Select(error => error.ErrorMessage)),
                    "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Text = $"{Application.ProductName} - {Application.ProductVersion}";
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Save settings on exit
            _settingsProvider.Save();

            // Unsubscribe from settings property changed event
            _settingsProvider.Settings.PropertyChanged -= Settings_PropertyChanged;
        }

        private void Settings_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(_settingsProvider.Settings.ActivePayer))
            {
                UpdateDescriptiveRecord();
                btn_AddTransaction.Enabled = _settingsProvider.Settings.ActivePayer != null;
            }
        }

        private void SearchBSBsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://bsb.auspaynet.com.au",
                UseShellExecute = true
            });
        }

        private void ManagePayersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_managePayersForm.IsDisposed) m_managePayersForm = _formFactory.CreateManagePayersForm();
            m_managePayersForm.Show();
            m_managePayersForm.BringToFront();
        }

        private void NewPayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_addPayerForm.IsDisposed) m_addPayerForm = _formFactory.CreateAddPayerForm();
            m_addPayerForm.Show();
            m_addPayerForm.BringToFront();
        }

        private void SetPayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_setPayersForm.IsDisposed) m_setPayersForm = _formFactory.CreateSetActivePayerForm();
            m_setPayersForm.ShowDialog();
            UpdateDescriptiveRecord();
        }

        private void AddToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            m_addTransactionForm.ShowDialog(this);
        }

        private void Btn_AddTransaction_Click(object sender, EventArgs e)
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

            UpdateFileTotalRecord();
        }

        private void SetTransactions(List<DetailRecord> records)
        {
            m_Transactions = records;
            UpdateTransactions();
        }

        private void OpenABAFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenABAFile();
        }

        private void UpdateDescriptiveRecord()
        {
            PaymentSender _payer = _settingsProvider.Settings.ActivePayer;
            if (_payer != null)
            {
                UpdateDescriptiveRecord(new DescriptiveRecord("01",
                                        new UserSupplyingFile(_payer.FinancialInstitution,
                                                              _payer.AccountName,
                                                              _payer.UserIdentificationNumber.PadLeft(6, '0'))));
            }
            else
            {
                MessageBox.Show("No payer has been selected, please set a payer from the Payers menu.", "No Payer!", MessageBoxButtons.OK);
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
            if (dlg_OpenAbaFile.ShowDialog() == DialogResult.OK)
            {
                ClearTransactions();
                //MessageBox.Show(openFileDialog1.FileName);
                ABAFile _aba = new ABAFile(dlg_OpenAbaFile.FileName);
                UpdateDescriptiveRecord(_aba.descriptiveRecord);
                SetTransactions(_aba.detailRecords);
                UpdateFileTotalRecord(_aba.fileTotalRecord);
            }
        }

        private void SaveABAFile()
        {
            if (dlg_SaveAbaFile.ShowDialog() == DialogResult.OK)
            {
                string _aba = new ABAFile(m_DescriptiveRecord, m_Transactions, m_FileTotalRecord).ToString();
                StreamWriter stream = File.CreateText(dlg_SaveAbaFile.FileName);
                stream.Write(_aba);
                stream.Close();
            }
        }

        private void NewABAFile()
        {
            ClearDescriptiveRecord();
            ClearTransactions();
            ClearFileTotalRecord();
        }

        private void SaveABAFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveABAFile();
        }

        private void Dgv_DetailRecord_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (m_Transactions == null || m_Transactions.Count == 0 || m_Transactions.Count < e.RowIndex) return;
            m_Transactions[e.RowIndex] = new DetailRecord(RowToArray(dgv_DetailRecord.Rows[e.RowIndex]));
            UpdateTransactions();
        }

        private void Dgv_DetailRecord_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
        }

        private static string[] RowToArray(DataGridViewRow row)
        {
            string[] _ = new string[row.Cells.Count];
            int i = 0;
            foreach (DataGridViewCell cell in row.Cells)
            {
                if (cell.Value != null)
                {
                    _[i] = cell.Value.ToString();
                }
                i++;
            }
            return _;
        }

        private void Dgv_DetailRecord_Sorted(object sender, EventArgs e)
        {
            m_Transactions.Clear();
            foreach (DataGridViewRow row in dgv_DetailRecord.Rows)
            {
                m_Transactions.Add(new DetailRecord(RowToArray(row)));
            }
        }

        private void NewABAFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewABAFile();
        }

        private void Btn_CopyTransaction_Click(object sender, EventArgs e)
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

        private void Dgv_DetailRecord_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (m_Transactions == null || m_Transactions.Count == 0 || m_Transactions.Count < e.RowIndex) return;
            m_Transactions[e.RowIndex] = new DetailRecord(RowToArray(dgv_DetailRecord.Rows[e.RowIndex]));
        }

        private void Dgv_DetailRecord_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            // Cancel the default delete behaviour
            e.Cancel = true;

            // Defer to controlled method of deleting rows
            DeleteSelectedRows();
        }

        private bool DeleteSelectedRows()
        {
            bool _deleteRows = MessageBox.Show(
                $"Are you sure you want to delete {dgv_DetailRecord.SelectedRows.Count} row(s)?",
                "Delete Rows", MessageBoxButtons.OKCancel) == DialogResult.OK;

            if (_deleteRows)
            {
                foreach (DataGridViewRow row in dgv_DetailRecord.SelectedRows)
                {
                    // Remove the transaction from the list
                    m_Transactions.RemoveAt(row.Index);
                    // Remove the row from the DataGridView
                    dgv_DetailRecord.Rows.RemoveAt(row.Index);
                    UpdateTransactions();
                }
            }
            return _deleteRows;
        }

        private void Btn_DeleteTransaction_Click(object sender, EventArgs e)
        {
            if (dgv_DetailRecord.SelectedRows.Count > 0)
            {
                DeleteSelectedRows();
            }
            else
            {
                MessageBox.Show("Please select at least one row to delete.", "No Rows Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_aboutBox.Show();
        }

        private void ImportSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dlg_OpenSettingsFile.InitialDirectory = Environment.CurrentDirectory;
            var result = dlg_OpenSettingsFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                LoadSettings(dlg_OpenSettingsFile.FileName);
                MessageBox.Show("Settings imported successfully!", "Imported Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _settingsProvider.Save(); // Save the settings after importing
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Prompt the user to confirm exit
            var result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ExportSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = dlg_SaveSettingsFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    _settingsProvider.Save(dlg_SaveSettingsFile.FileName);
                    MessageBox.Show("Settings exported successfully.", "Export Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to export settings: {ex.Message}", "Export Settings Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ABAFileSpecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.cemtexaba.com/aba-format/cemtex-aba-file-format-details/",
                UseShellExecute = true
            });
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var payeeBsbs = m_Transactions.Select(transaction => transaction.PayeeBSB);
            var payerBsbs = m_Transactions.Select(transaction => transaction.PayerBSB);

            var validationResults = new List<BsbValidationResult>();
            Task.WaitAll(
                Task.Run(() => { MessageBox.Show("Validating BSBs, this may take a while...", "BSB Validation", MessageBoxButtons.OK, MessageBoxIcon.Information); }),
                Task.Run(async () =>
                {

                    foreach (var bsb in payeeBsbs.Concat(payerBsbs).Distinct())
                    {
                        validationResults.Add(await _bsbValidationHelper.IsValidBsb(bsb));
                    }
                }
                ));

            if (validationResults.Any(result => result.ResultType != BsbValidationResultType.SingleMatch))
            {
                var validationErrors = validationResults.Where(result => result.ResultType != BsbValidationResultType.SingleMatch);

                foreach(DataGridViewRow row in dgv_DetailRecord.Rows)
                {
                    var bsb = row.Cells["BSB"].Value?.ToString();
                    var traceRecord = row.Cells["TraceRecord"].Value?.ToString();
                    var matches = validationErrors.Where(result => result.Bsb == bsb || result.Bsb == traceRecord).ToList();
                    if (matches.Count > 0 )
                    {
                        row.DefaultCellStyle.BackColor = System.Drawing.Color.LightCoral;
                    } else
                    {
                        row.DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;
                    }
                }
                MessageBox.Show("Some BSBs are invalid or have multiple matches. Please check the results.", "BSB Validation Results", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("All BSBs are valid and have single matches.", "BSB Validation Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
