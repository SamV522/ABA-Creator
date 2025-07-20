
namespace Creator.ABA
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_AddTransaction = new System.Windows.Forms.Button();
            btn_CopyTransaction = new System.Windows.Forms.Button();
            btn_DeleteTransaction = new System.Windows.Forms.Button();
            dgv_DescriptiveRecord = new System.Windows.Forms.DataGridView();
            RecordType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ReelSequenceNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            FinancialInstitution = new System.Windows.Forms.DataGridViewTextBoxColumn();
            UserPreferredSpecification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            UserBSB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ProcessDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgv_DetailRecord = new System.Windows.Forms.DataGridView();
            dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            BSB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Indicator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TransactionCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TitleofAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            LodgementReference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TraceRecord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            AccountNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Remitter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            AmountofWithholdingTax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgv_FileTotalRecord = new System.Windows.Forms.DataGridView();
            dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            BSBFormatFiller = new System.Windows.Forms.DataGridViewTextBoxColumn();
            NetTotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CreditTotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DebitTotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            NumRecords = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dlg_OpenAbaFile = new System.Windows.Forms.OpenFileDialog();
            dlg_SaveAbaFile = new System.Windows.Forms.SaveFileDialog();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            newABAFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            openABAFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saveABAFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            payeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            payersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            managePayersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            newPayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            setPayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            paymentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            importFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            searchBSBsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            aBAFileSpecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            importSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            exportSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            dlg_OpenSettingsFile = new System.Windows.Forms.OpenFileDialog();
            dlg_SaveSettingsFile = new System.Windows.Forms.SaveFileDialog();
            button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgv_DescriptiveRecord).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_DetailRecord).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_FileTotalRecord).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_AddTransaction
            // 
            btn_AddTransaction.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btn_AddTransaction.Enabled = false;
            btn_AddTransaction.Location = new System.Drawing.Point(273, 479);
            btn_AddTransaction.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_AddTransaction.Name = "btn_AddTransaction";
            btn_AddTransaction.Size = new System.Drawing.Size(122, 27);
            btn_AddTransaction.TabIndex = 1;
            btn_AddTransaction.Text = "Add Transaction";
            btn_AddTransaction.UseVisualStyleBackColor = true;
            btn_AddTransaction.Click += Btn_AddTransaction_Click;
            // 
            // btn_CopyTransaction
            // 
            btn_CopyTransaction.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btn_CopyTransaction.Enabled = false;
            btn_CopyTransaction.Location = new System.Drawing.Point(144, 479);
            btn_CopyTransaction.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_CopyTransaction.Name = "btn_CopyTransaction";
            btn_CopyTransaction.Size = new System.Drawing.Size(122, 27);
            btn_CopyTransaction.TabIndex = 2;
            btn_CopyTransaction.Text = "Copy Transaction";
            btn_CopyTransaction.UseVisualStyleBackColor = true;
            btn_CopyTransaction.Click += Btn_CopyTransaction_Click;
            // 
            // btn_DeleteTransaction
            // 
            btn_DeleteTransaction.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btn_DeleteTransaction.Location = new System.Drawing.Point(14, 479);
            btn_DeleteTransaction.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_DeleteTransaction.Name = "btn_DeleteTransaction";
            btn_DeleteTransaction.Size = new System.Drawing.Size(122, 27);
            btn_DeleteTransaction.TabIndex = 4;
            btn_DeleteTransaction.Text = "Delete Transaction";
            btn_DeleteTransaction.UseVisualStyleBackColor = true;
            btn_DeleteTransaction.Click += Btn_DeleteTransaction_Click;
            // 
            // dgv_DescriptiveRecord
            // 
            dgv_DescriptiveRecord.AllowUserToAddRows = false;
            dgv_DescriptiveRecord.AllowUserToDeleteRows = false;
            dgv_DescriptiveRecord.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dgv_DescriptiveRecord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgv_DescriptiveRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_DescriptiveRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { RecordType, ReelSequenceNumber, FinancialInstitution, UserPreferredSpecification, UserBSB, Description, ProcessDate });
            dgv_DescriptiveRecord.Location = new System.Drawing.Point(14, 31);
            dgv_DescriptiveRecord.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dgv_DescriptiveRecord.Name = "dgv_DescriptiveRecord";
            dgv_DescriptiveRecord.ReadOnly = true;
            dgv_DescriptiveRecord.RowHeadersVisible = false;
            dgv_DescriptiveRecord.RowHeadersWidth = 51;
            dgv_DescriptiveRecord.Size = new System.Drawing.Size(905, 75);
            dgv_DescriptiveRecord.TabIndex = 7;
            // 
            // RecordType
            // 
            RecordType.FillWeight = 53.2995F;
            RecordType.HeaderText = "Record Type";
            RecordType.MaxInputLength = 1;
            RecordType.MinimumWidth = 6;
            RecordType.Name = "RecordType";
            RecordType.ReadOnly = true;
            RecordType.Visible = false;
            // 
            // ReelSequenceNumber
            // 
            ReelSequenceNumber.FillWeight = 109.1018F;
            ReelSequenceNumber.HeaderText = "Reel Sequence Number";
            ReelSequenceNumber.MinimumWidth = 6;
            ReelSequenceNumber.Name = "ReelSequenceNumber";
            ReelSequenceNumber.ReadOnly = true;
            // 
            // FinancialInstitution
            // 
            FinancialInstitution.FillWeight = 109.1018F;
            FinancialInstitution.HeaderText = "Financial Insititution";
            FinancialInstitution.MinimumWidth = 6;
            FinancialInstitution.Name = "FinancialInstitution";
            FinancialInstitution.ReadOnly = true;
            // 
            // UserPreferredSpecification
            // 
            UserPreferredSpecification.FillWeight = 109.1018F;
            UserPreferredSpecification.HeaderText = "User Preferred Specification";
            UserPreferredSpecification.MinimumWidth = 6;
            UserPreferredSpecification.Name = "UserPreferredSpecification";
            UserPreferredSpecification.ReadOnly = true;
            // 
            // UserBSB
            // 
            UserBSB.FillWeight = 109.1018F;
            UserBSB.HeaderText = "User ID";
            UserBSB.MinimumWidth = 6;
            UserBSB.Name = "UserBSB";
            UserBSB.ReadOnly = true;
            // 
            // Description
            // 
            Description.FillWeight = 109.1018F;
            Description.HeaderText = "Description";
            Description.MinimumWidth = 6;
            Description.Name = "Description";
            Description.ReadOnly = true;
            // 
            // ProcessDate
            // 
            ProcessDate.FillWeight = 101.1914F;
            ProcessDate.HeaderText = "Process Date";
            ProcessDate.MinimumWidth = 6;
            ProcessDate.Name = "ProcessDate";
            ProcessDate.ReadOnly = true;
            // 
            // dgv_DetailRecord
            // 
            dgv_DetailRecord.AllowUserToAddRows = false;
            dgv_DetailRecord.AllowUserToOrderColumns = true;
            dgv_DetailRecord.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dgv_DetailRecord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgv_DetailRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_DetailRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dataGridViewTextBoxColumn1, BSB, Account, Indicator, TransactionCode, Amount, TitleofAccount, LodgementReference, TraceRecord, AccountNumber, Remitter, AmountofWithholdingTax });
            dgv_DetailRecord.Location = new System.Drawing.Point(14, 113);
            dgv_DetailRecord.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dgv_DetailRecord.Name = "dgv_DetailRecord";
            dgv_DetailRecord.RowHeadersWidth = 15;
            dgv_DetailRecord.Size = new System.Drawing.Size(905, 277);
            dgv_DetailRecord.TabIndex = 9;
            dgv_DetailRecord.CellValueChanged += Dgv_DetailRecord_CellValueChanged;
            dgv_DetailRecord.RowsAdded += Dgv_DetailRecord_RowsAdded;
            dgv_DetailRecord.Sorted += Dgv_DetailRecord_Sorted;
            dgv_DetailRecord.UserDeletedRow += Dgv_DetailRecord_UserDeletedRow;
            dgv_DetailRecord.UserDeletingRow += Dgv_DetailRecord_UserDeletingRow;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.FillWeight = 77.95612F;
            dataGridViewTextBoxColumn1.HeaderText = "Record Type";
            dataGridViewTextBoxColumn1.MaxInputLength = 1;
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            dataGridViewTextBoxColumn1.Visible = false;
            // 
            // BSB
            // 
            BSB.FillWeight = 97.5109F;
            BSB.HeaderText = "Payee BSB";
            BSB.MinimumWidth = 6;
            BSB.Name = "BSB";
            // 
            // Account
            // 
            Account.FillWeight = 120.9926F;
            Account.HeaderText = "Payee Account";
            Account.MinimumWidth = 6;
            Account.Name = "Account";
            // 
            // Indicator
            // 
            Indicator.FillWeight = 55.41993F;
            Indicator.HeaderText = "Indicator";
            Indicator.MinimumWidth = 6;
            Indicator.Name = "Indicator";
            Indicator.Visible = false;
            // 
            // TransactionCode
            // 
            TransactionCode.FillWeight = 51.49573F;
            TransactionCode.HeaderText = "Tran Code";
            TransactionCode.MinimumWidth = 6;
            TransactionCode.Name = "TransactionCode";
            // 
            // Amount
            // 
            Amount.FillWeight = 106.129F;
            Amount.HeaderText = "Amount";
            Amount.MinimumWidth = 6;
            Amount.Name = "Amount";
            // 
            // TitleofAccount
            // 
            TitleofAccount.FillWeight = 178.5404F;
            TitleofAccount.HeaderText = "Title of Account";
            TitleofAccount.MinimumWidth = 6;
            TitleofAccount.Name = "TitleofAccount";
            // 
            // LodgementReference
            // 
            LodgementReference.FillWeight = 150.1348F;
            LodgementReference.HeaderText = "Lodgement Reference";
            LodgementReference.MinimumWidth = 6;
            LodgementReference.Name = "LodgementReference";
            // 
            // TraceRecord
            // 
            TraceRecord.FillWeight = 78.23891F;
            TraceRecord.HeaderText = "Payer BSB";
            TraceRecord.MinimumWidth = 6;
            TraceRecord.Name = "TraceRecord";
            // 
            // AccountNumber
            // 
            AccountNumber.FillWeight = 100.0804F;
            AccountNumber.HeaderText = "Payer Acc. No.";
            AccountNumber.MinimumWidth = 6;
            AccountNumber.Name = "AccountNumber";
            // 
            // Remitter
            // 
            Remitter.FillWeight = 92.91916F;
            Remitter.HeaderText = "Remitter";
            Remitter.Name = "Remitter";
            // 
            // AmountofWithholdingTax
            // 
            AmountofWithholdingTax.FillWeight = 51.49573F;
            AmountofWithholdingTax.HeaderText = "Tax";
            AmountofWithholdingTax.MinimumWidth = 6;
            AmountofWithholdingTax.Name = "AmountofWithholdingTax";
            // 
            // dgv_FileTotalRecord
            // 
            dgv_FileTotalRecord.AllowUserToAddRows = false;
            dgv_FileTotalRecord.AllowUserToDeleteRows = false;
            dgv_FileTotalRecord.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dgv_FileTotalRecord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgv_FileTotalRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_FileTotalRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dataGridViewTextBoxColumn2, BSBFormatFiller, NetTotalAmount, CreditTotalAmount, DebitTotalAmount, NumRecords });
            dgv_FileTotalRecord.Location = new System.Drawing.Point(14, 397);
            dgv_FileTotalRecord.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dgv_FileTotalRecord.Name = "dgv_FileTotalRecord";
            dgv_FileTotalRecord.ReadOnly = true;
            dgv_FileTotalRecord.RowHeadersVisible = false;
            dgv_FileTotalRecord.RowHeadersWidth = 51;
            dgv_FileTotalRecord.Size = new System.Drawing.Size(905, 75);
            dgv_FileTotalRecord.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.FillWeight = 53.2995F;
            dataGridViewTextBoxColumn2.HeaderText = "Record Type";
            dataGridViewTextBoxColumn2.MaxInputLength = 1;
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Visible = false;
            // 
            // BSBFormatFiller
            // 
            BSBFormatFiller.HeaderText = "BSB Format Filler";
            BSBFormatFiller.MinimumWidth = 6;
            BSBFormatFiller.Name = "BSBFormatFiller";
            BSBFormatFiller.ReadOnly = true;
            BSBFormatFiller.Visible = false;
            // 
            // NetTotalAmount
            // 
            NetTotalAmount.HeaderText = "Net Total Amount";
            NetTotalAmount.MinimumWidth = 6;
            NetTotalAmount.Name = "NetTotalAmount";
            NetTotalAmount.ReadOnly = true;
            // 
            // CreditTotalAmount
            // 
            CreditTotalAmount.HeaderText = "Credit Total Amount";
            CreditTotalAmount.MinimumWidth = 6;
            CreditTotalAmount.Name = "CreditTotalAmount";
            CreditTotalAmount.ReadOnly = true;
            // 
            // DebitTotalAmount
            // 
            DebitTotalAmount.HeaderText = "Debit Total Amount";
            DebitTotalAmount.MinimumWidth = 6;
            DebitTotalAmount.Name = "DebitTotalAmount";
            DebitTotalAmount.ReadOnly = true;
            // 
            // NumRecords
            // 
            NumRecords.HeaderText = "# Records";
            NumRecords.MinimumWidth = 6;
            NumRecords.Name = "NumRecords";
            NumRecords.ReadOnly = true;
            // 
            // dlg_OpenAbaFile
            // 
            dlg_OpenAbaFile.DefaultExt = "*.aba";
            dlg_OpenAbaFile.Filter = "ABA Files|*.aba|Text Files|*.txt";
            // 
            // dlg_SaveAbaFile
            // 
            dlg_SaveAbaFile.DefaultExt = "aba";
            dlg_SaveAbaFile.Filter = "ABA Files|*.aba|Text Files|*.txt";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { newABAFileToolStripMenuItem, openABAFileToolStripMenuItem, saveABAFileToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // newABAFileToolStripMenuItem
            // 
            newABAFileToolStripMenuItem.Name = "newABAFileToolStripMenuItem";
            newABAFileToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            newABAFileToolStripMenuItem.Text = "New ABA file";
            newABAFileToolStripMenuItem.Click += NewABAFileToolStripMenuItem_Click;
            // 
            // openABAFileToolStripMenuItem
            // 
            openABAFileToolStripMenuItem.Name = "openABAFileToolStripMenuItem";
            openABAFileToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            openABAFileToolStripMenuItem.Text = "Open ABA File";
            openABAFileToolStripMenuItem.Click += OpenABAFileToolStripMenuItem_Click;
            // 
            // saveABAFileToolStripMenuItem
            // 
            saveABAFileToolStripMenuItem.Name = "saveABAFileToolStripMenuItem";
            saveABAFileToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            saveABAFileToolStripMenuItem.Text = "Save ABA File";
            saveABAFileToolStripMenuItem.Click += SaveABAFileToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            // 
            // payeesToolStripMenuItem
            // 
            payeesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { manageToolStripMenuItem, addToolStripMenuItem });
            payeesToolStripMenuItem.Name = "payeesToolStripMenuItem";
            payeesToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            payeesToolStripMenuItem.Text = "Payees";
            // 
            // manageToolStripMenuItem
            // 
            manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            manageToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            manageToolStripMenuItem.Text = "Manage";
            manageToolStripMenuItem.Click += ManageToolStripMenuItem_Click;
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            addToolStripMenuItem.Text = "New Payee";
            addToolStripMenuItem.Click += AddToolStripMenuItem_Click;
            // 
            // payersToolStripMenuItem
            // 
            payersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { managePayersToolStripMenuItem, newPayerToolStripMenuItem, setPayerToolStripMenuItem });
            payersToolStripMenuItem.Name = "payersToolStripMenuItem";
            payersToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            payersToolStripMenuItem.Text = "Payers";
            // 
            // managePayersToolStripMenuItem
            // 
            managePayersToolStripMenuItem.Name = "managePayersToolStripMenuItem";
            managePayersToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            managePayersToolStripMenuItem.Text = "Manage Payers";
            managePayersToolStripMenuItem.Click += ManagePayersToolStripMenuItem_Click;
            // 
            // newPayerToolStripMenuItem
            // 
            newPayerToolStripMenuItem.Name = "newPayerToolStripMenuItem";
            newPayerToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            newPayerToolStripMenuItem.Text = "New Payer";
            newPayerToolStripMenuItem.Click += NewPayerToolStripMenuItem_Click;
            // 
            // setPayerToolStripMenuItem
            // 
            setPayerToolStripMenuItem.Name = "setPayerToolStripMenuItem";
            setPayerToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            setPayerToolStripMenuItem.Text = "Set Payer";
            setPayerToolStripMenuItem.Click += SetPayerToolStripMenuItem_Click;
            // 
            // paymentsToolStripMenuItem
            // 
            paymentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { addToolStripMenuItem1, importFromFileToolStripMenuItem });
            paymentsToolStripMenuItem.Name = "paymentsToolStripMenuItem";
            paymentsToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            paymentsToolStripMenuItem.Text = "Transactions";
            // 
            // addToolStripMenuItem1
            // 
            addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            addToolStripMenuItem1.Size = new System.Drawing.Size(162, 22);
            addToolStripMenuItem1.Text = "Add New";
            addToolStripMenuItem1.Click += AddToolStripMenuItem1_Click;
            // 
            // importFromFileToolStripMenuItem
            // 
            importFromFileToolStripMenuItem.Name = "importFromFileToolStripMenuItem";
            importFromFileToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            importFromFileToolStripMenuItem.Text = "Import From File";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { searchBSBsToolStripMenuItem, aBAFileSpecToolStripMenuItem, aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // searchBSBsToolStripMenuItem
            // 
            searchBSBsToolStripMenuItem.Name = "searchBSBsToolStripMenuItem";
            searchBSBsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            searchBSBsToolStripMenuItem.Text = "Search BSBs...";
            searchBSBsToolStripMenuItem.Click += SearchBSBsToolStripMenuItem_Click;
            // 
            // aBAFileSpecToolStripMenuItem
            // 
            aBAFileSpecToolStripMenuItem.Name = "aBAFileSpecToolStripMenuItem";
            aBAFileSpecToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            aBAFileSpecToolStripMenuItem.Text = "ABA File Spec";
            aBAFileSpecToolStripMenuItem.Click += ABAFileSpecToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += AboutToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem, payeesToolStripMenuItem, payersToolStripMenuItem, paymentsToolStripMenuItem, helpToolStripMenuItem, settingsToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            menuStrip1.Size = new System.Drawing.Size(933, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { importSettingsToolStripMenuItem, exportSettingsToolStripMenuItem });
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // importSettingsToolStripMenuItem
            // 
            importSettingsToolStripMenuItem.Name = "importSettingsToolStripMenuItem";
            importSettingsToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            importSettingsToolStripMenuItem.Text = "Import";
            importSettingsToolStripMenuItem.Click += ImportSettingsToolStripMenuItem_Click;
            // 
            // exportSettingsToolStripMenuItem
            // 
            exportSettingsToolStripMenuItem.Name = "exportSettingsToolStripMenuItem";
            exportSettingsToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            exportSettingsToolStripMenuItem.Text = "Export";
            exportSettingsToolStripMenuItem.Click += ExportSettingsToolStripMenuItem_Click;
            // 
            // dlg_OpenSettingsFile
            // 
            dlg_OpenSettingsFile.FileName = "usersettings.json";
            dlg_OpenSettingsFile.Filter = "ABA Creator Settings File|usersettings.json|JSON File|*.json";
            // 
            // dlg_SaveSettingsFile
            // 
            dlg_SaveSettingsFile.FileName = "usersettings.json";
            dlg_SaveSettingsFile.Filter = "ABA Creator Settings File|usersettings.json|All Files|*.*";
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.cloud_done_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24;
            button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            button1.Location = new System.Drawing.Point(402, 478);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 28);
            button1.TabIndex = 11;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(933, 519);
            Controls.Add(button1);
            Controls.Add(dgv_FileTotalRecord);
            Controls.Add(dgv_DetailRecord);
            Controls.Add(dgv_DescriptiveRecord);
            Controls.Add(btn_DeleteTransaction);
            Controls.Add(btn_CopyTransaction);
            Controls.Add(btn_AddTransaction);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Main";
            Text = "ABA Creator";
            Load += Main_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_DescriptiveRecord).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_DetailRecord).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_FileTotalRecord).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_AddTransaction;
        private System.Windows.Forms.Button btn_CopyTransaction;
        private System.Windows.Forms.Button btn_DeleteTransaction;
        private System.Windows.Forms.DataGridView dgv_DescriptiveRecord;
        private System.Windows.Forms.DataGridView dgv_DetailRecord;
        private System.Windows.Forms.DataGridView dgv_FileTotalRecord;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn BSBFormatFiller;
        private System.Windows.Forms.DataGridViewTextBoxColumn NetTotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreditTotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn DebitTotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumRecords;
        private System.Windows.Forms.OpenFileDialog dlg_OpenAbaFile;
        private System.Windows.Forms.SaveFileDialog dlg_SaveAbaFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecordType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReelSequenceNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinancialInstitution;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserPreferredSpecification;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserBSB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcessDate;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newABAFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openABAFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveABAFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managePayersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setPayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem importFromFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchBSBsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importSettingsToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog dlg_OpenSettingsFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportSettingsToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog dlg_SaveSettingsFile;
        private System.Windows.Forms.ToolStripMenuItem aBAFileSpecToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BSB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Account;
        private System.Windows.Forms.DataGridViewTextBoxColumn Indicator;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleofAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn LodgementReference;
        private System.Windows.Forms.DataGridViewTextBoxColumn TraceRecord;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remitter;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountofWithholdingTax;
        private System.Windows.Forms.Button button1;
    }
}

