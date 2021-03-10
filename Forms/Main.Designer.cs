
namespace ABA_Creator
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newABAFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openABAFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveABAFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managePayersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setPayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.importFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchBSBsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dgv_DescriptiveRecord = new System.Windows.Forms.DataGridView();
            this.RecordType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReelSequenceNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinancialInstitution = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserPreferredSpecification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserBSB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcessDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_DetailRecord = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BSB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Indicator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitleofAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LodgementReference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TraceRecord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remitter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountofWithholdingTax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_FileTotalRecord = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BSBFormatFiller = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NetTotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreditTotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DebitTotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumRecords = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DescriptiveRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DetailRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_FileTotalRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.payeesToolStripMenuItem,
            this.payersToolStripMenuItem,
            this.paymentsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newABAFileToolStripMenuItem,
            this.openABAFileToolStripMenuItem,
            this.saveABAFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newABAFileToolStripMenuItem
            // 
            this.newABAFileToolStripMenuItem.Name = "newABAFileToolStripMenuItem";
            this.newABAFileToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.newABAFileToolStripMenuItem.Text = "New ABA file";
            this.newABAFileToolStripMenuItem.Click += new System.EventHandler(this.newABAFileToolStripMenuItem_Click);
            // 
            // openABAFileToolStripMenuItem
            // 
            this.openABAFileToolStripMenuItem.Name = "openABAFileToolStripMenuItem";
            this.openABAFileToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.openABAFileToolStripMenuItem.Text = "Open ABA File";
            this.openABAFileToolStripMenuItem.Click += new System.EventHandler(this.openABAFileToolStripMenuItem_Click);
            // 
            // saveABAFileToolStripMenuItem
            // 
            this.saveABAFileToolStripMenuItem.Name = "saveABAFileToolStripMenuItem";
            this.saveABAFileToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.saveABAFileToolStripMenuItem.Text = "Save ABA File";
            this.saveABAFileToolStripMenuItem.Click += new System.EventHandler(this.saveABAFileToolStripMenuItem_Click);
            // 
            // payeesToolStripMenuItem
            // 
            this.payeesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageToolStripMenuItem,
            this.addToolStripMenuItem});
            this.payeesToolStripMenuItem.Name = "payeesToolStripMenuItem";
            this.payeesToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.payeesToolStripMenuItem.Text = "Payees";
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.manageToolStripMenuItem.Text = "Manage";
            this.manageToolStripMenuItem.Click += new System.EventHandler(this.manageToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.addToolStripMenuItem.Text = "New Payee";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // payersToolStripMenuItem
            // 
            this.payersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.managePayersToolStripMenuItem,
            this.newPayerToolStripMenuItem,
            this.setPayerToolStripMenuItem});
            this.payersToolStripMenuItem.Name = "payersToolStripMenuItem";
            this.payersToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.payersToolStripMenuItem.Text = "Payers";
            // 
            // managePayersToolStripMenuItem
            // 
            this.managePayersToolStripMenuItem.Name = "managePayersToolStripMenuItem";
            this.managePayersToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.managePayersToolStripMenuItem.Text = "Manage Payers";
            this.managePayersToolStripMenuItem.Click += new System.EventHandler(this.managePayersToolStripMenuItem_Click);
            // 
            // newPayerToolStripMenuItem
            // 
            this.newPayerToolStripMenuItem.Name = "newPayerToolStripMenuItem";
            this.newPayerToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.newPayerToolStripMenuItem.Text = "New Payer";
            this.newPayerToolStripMenuItem.Click += new System.EventHandler(this.newPayerToolStripMenuItem_Click);
            // 
            // setPayerToolStripMenuItem
            // 
            this.setPayerToolStripMenuItem.Name = "setPayerToolStripMenuItem";
            this.setPayerToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.setPayerToolStripMenuItem.Text = "Set Payer";
            this.setPayerToolStripMenuItem.Click += new System.EventHandler(this.setPayerToolStripMenuItem_Click);
            // 
            // paymentsToolStripMenuItem
            // 
            this.paymentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem1,
            this.importFromFileToolStripMenuItem});
            this.paymentsToolStripMenuItem.Name = "paymentsToolStripMenuItem";
            this.paymentsToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.paymentsToolStripMenuItem.Text = "Transactions";
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(162, 22);
            this.addToolStripMenuItem1.Text = "Add New";
            this.addToolStripMenuItem1.Click += new System.EventHandler(this.addToolStripMenuItem1_Click);
            // 
            // importFromFileToolStripMenuItem
            // 
            this.importFromFileToolStripMenuItem.Name = "importFromFileToolStripMenuItem";
            this.importFromFileToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.importFromFileToolStripMenuItem.Text = "Import From File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchBSBsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // searchBSBsToolStripMenuItem
            // 
            this.searchBSBsToolStripMenuItem.Name = "searchBSBsToolStripMenuItem";
            this.searchBSBsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.searchBSBsToolStripMenuItem.Text = "Search BSBs...";
            this.searchBSBsToolStripMenuItem.Click += new System.EventHandler(this.searchBSBsToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(234, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add Transaction";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(123, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Copy Transaction";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button4.Location = new System.Drawing.Point(12, 415);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Delete Transaction";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dgv_DescriptiveRecord
            // 
            this.dgv_DescriptiveRecord.AllowUserToAddRows = false;
            this.dgv_DescriptiveRecord.AllowUserToDeleteRows = false;
            this.dgv_DescriptiveRecord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_DescriptiveRecord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DescriptiveRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DescriptiveRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RecordType,
            this.ReelSequenceNumber,
            this.FinancialInstitution,
            this.UserPreferredSpecification,
            this.UserBSB,
            this.Description,
            this.ProcessDate});
            this.dgv_DescriptiveRecord.Location = new System.Drawing.Point(12, 27);
            this.dgv_DescriptiveRecord.Name = "dgv_DescriptiveRecord";
            this.dgv_DescriptiveRecord.ReadOnly = true;
            this.dgv_DescriptiveRecord.RowHeadersVisible = false;
            this.dgv_DescriptiveRecord.RowHeadersWidth = 51;
            this.dgv_DescriptiveRecord.Size = new System.Drawing.Size(776, 65);
            this.dgv_DescriptiveRecord.TabIndex = 7;
            // 
            // RecordType
            // 
            this.RecordType.FillWeight = 53.2995F;
            this.RecordType.HeaderText = "Record Type";
            this.RecordType.MaxInputLength = 1;
            this.RecordType.MinimumWidth = 6;
            this.RecordType.Name = "RecordType";
            this.RecordType.ReadOnly = true;
            this.RecordType.Visible = false;
            // 
            // ReelSequenceNumber
            // 
            this.ReelSequenceNumber.FillWeight = 109.1018F;
            this.ReelSequenceNumber.HeaderText = "Reel Sequence Number";
            this.ReelSequenceNumber.MinimumWidth = 6;
            this.ReelSequenceNumber.Name = "ReelSequenceNumber";
            this.ReelSequenceNumber.ReadOnly = true;
            // 
            // FinancialInstitution
            // 
            this.FinancialInstitution.FillWeight = 109.1018F;
            this.FinancialInstitution.HeaderText = "Financial Insititution";
            this.FinancialInstitution.MinimumWidth = 6;
            this.FinancialInstitution.Name = "FinancialInstitution";
            this.FinancialInstitution.ReadOnly = true;
            // 
            // UserPreferredSpecification
            // 
            this.UserPreferredSpecification.FillWeight = 109.1018F;
            this.UserPreferredSpecification.HeaderText = "User Preferred Specification";
            this.UserPreferredSpecification.MinimumWidth = 6;
            this.UserPreferredSpecification.Name = "UserPreferredSpecification";
            this.UserPreferredSpecification.ReadOnly = true;
            // 
            // UserBSB
            // 
            this.UserBSB.FillWeight = 109.1018F;
            this.UserBSB.HeaderText = "User ID";
            this.UserBSB.MinimumWidth = 6;
            this.UserBSB.Name = "UserBSB";
            this.UserBSB.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.FillWeight = 109.1018F;
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // ProcessDate
            // 
            this.ProcessDate.FillWeight = 101.1914F;
            this.ProcessDate.HeaderText = "Process Date";
            this.ProcessDate.MinimumWidth = 6;
            this.ProcessDate.Name = "ProcessDate";
            this.ProcessDate.ReadOnly = true;
            // 
            // dgv_DetailRecord
            // 
            this.dgv_DetailRecord.AllowUserToAddRows = false;
            this.dgv_DetailRecord.AllowUserToOrderColumns = true;
            this.dgv_DetailRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_DetailRecord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DetailRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DetailRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.BSB,
            this.Account,
            this.Indicator,
            this.TransactionCode,
            this.Amount,
            this.TitleofAccount,
            this.LodgementReference,
            this.TraceRecord,
            this.AccountNumber,
            this.Remitter,
            this.AmountofWithholdingTax});
            this.dgv_DetailRecord.Location = new System.Drawing.Point(12, 98);
            this.dgv_DetailRecord.Name = "dgv_DetailRecord";
            this.dgv_DetailRecord.RowHeadersWidth = 15;
            this.dgv_DetailRecord.Size = new System.Drawing.Size(776, 240);
            this.dgv_DetailRecord.TabIndex = 9;
            this.dgv_DetailRecord.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DetailRecord_CellValueChanged);
            this.dgv_DetailRecord.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgv_DetailRecord_RowsAdded);
            this.dgv_DetailRecord.Sorted += new System.EventHandler(this.dgv_DetailRecord_Sorted);
            this.dgv_DetailRecord.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgv_DetailRecord_UserDeletedRow);
            this.dgv_DetailRecord.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgv_DetailRecord_UserDeletingRow);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 77.95612F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Record Type";
            this.dataGridViewTextBoxColumn1.MaxInputLength = 1;
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // BSB
            // 
            this.BSB.FillWeight = 97.5109F;
            this.BSB.HeaderText = "Payee BSB";
            this.BSB.MinimumWidth = 6;
            this.BSB.Name = "BSB";
            // 
            // Account
            // 
            this.Account.FillWeight = 120.9926F;
            this.Account.HeaderText = "Payee Account";
            this.Account.MinimumWidth = 6;
            this.Account.Name = "Account";
            // 
            // Indicator
            // 
            this.Indicator.FillWeight = 55.41993F;
            this.Indicator.HeaderText = "Indicator";
            this.Indicator.MinimumWidth = 6;
            this.Indicator.Name = "Indicator";
            this.Indicator.Visible = false;
            // 
            // TransactionCode
            // 
            this.TransactionCode.FillWeight = 51.49573F;
            this.TransactionCode.HeaderText = "Code";
            this.TransactionCode.MinimumWidth = 6;
            this.TransactionCode.Name = "TransactionCode";
            // 
            // Amount
            // 
            this.Amount.FillWeight = 106.129F;
            this.Amount.HeaderText = "Amount";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            // 
            // TitleofAccount
            // 
            this.TitleofAccount.FillWeight = 178.5404F;
            this.TitleofAccount.HeaderText = "Title of Account";
            this.TitleofAccount.MinimumWidth = 6;
            this.TitleofAccount.Name = "TitleofAccount";
            // 
            // LodgementReference
            // 
            this.LodgementReference.FillWeight = 150.1348F;
            this.LodgementReference.HeaderText = "Lodgement Reference";
            this.LodgementReference.MinimumWidth = 6;
            this.LodgementReference.Name = "LodgementReference";
            // 
            // TraceRecord
            // 
            this.TraceRecord.FillWeight = 78.23891F;
            this.TraceRecord.HeaderText = "Payer BSB";
            this.TraceRecord.MinimumWidth = 6;
            this.TraceRecord.Name = "TraceRecord";
            // 
            // AccountNumber
            // 
            this.AccountNumber.FillWeight = 100.0804F;
            this.AccountNumber.HeaderText = "Payer Acc. No.";
            this.AccountNumber.MinimumWidth = 6;
            this.AccountNumber.Name = "AccountNumber";
            // 
            // Remitter
            // 
            this.Remitter.FillWeight = 92.91916F;
            this.Remitter.HeaderText = "Remitter";
            this.Remitter.Name = "Remitter";
            // 
            // AmountofWithholdingTax
            // 
            this.AmountofWithholdingTax.FillWeight = 51.49573F;
            this.AmountofWithholdingTax.HeaderText = "Tax";
            this.AmountofWithholdingTax.MinimumWidth = 6;
            this.AmountofWithholdingTax.Name = "AmountofWithholdingTax";
            // 
            // dgv_FileTotalRecord
            // 
            this.dgv_FileTotalRecord.AllowUserToAddRows = false;
            this.dgv_FileTotalRecord.AllowUserToDeleteRows = false;
            this.dgv_FileTotalRecord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_FileTotalRecord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_FileTotalRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_FileTotalRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.BSBFormatFiller,
            this.NetTotalAmount,
            this.CreditTotalAmount,
            this.DebitTotalAmount,
            this.NumRecords});
            this.dgv_FileTotalRecord.Location = new System.Drawing.Point(12, 344);
            this.dgv_FileTotalRecord.Name = "dgv_FileTotalRecord";
            this.dgv_FileTotalRecord.ReadOnly = true;
            this.dgv_FileTotalRecord.RowHeadersVisible = false;
            this.dgv_FileTotalRecord.RowHeadersWidth = 51;
            this.dgv_FileTotalRecord.Size = new System.Drawing.Size(776, 65);
            this.dgv_FileTotalRecord.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 53.2995F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Record Type";
            this.dataGridViewTextBoxColumn2.MaxInputLength = 1;
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // BSBFormatFiller
            // 
            this.BSBFormatFiller.HeaderText = "BSB Format Filler";
            this.BSBFormatFiller.MinimumWidth = 6;
            this.BSBFormatFiller.Name = "BSBFormatFiller";
            this.BSBFormatFiller.ReadOnly = true;
            this.BSBFormatFiller.Visible = false;
            // 
            // NetTotalAmount
            // 
            this.NetTotalAmount.HeaderText = "Net Total Amount";
            this.NetTotalAmount.MinimumWidth = 6;
            this.NetTotalAmount.Name = "NetTotalAmount";
            this.NetTotalAmount.ReadOnly = true;
            // 
            // CreditTotalAmount
            // 
            this.CreditTotalAmount.HeaderText = "Credit Total Amount";
            this.CreditTotalAmount.MinimumWidth = 6;
            this.CreditTotalAmount.Name = "CreditTotalAmount";
            this.CreditTotalAmount.ReadOnly = true;
            // 
            // DebitTotalAmount
            // 
            this.DebitTotalAmount.HeaderText = "Debit Total Amount";
            this.DebitTotalAmount.MinimumWidth = 6;
            this.DebitTotalAmount.Name = "DebitTotalAmount";
            this.DebitTotalAmount.ReadOnly = true;
            // 
            // NumRecords
            // 
            this.NumRecords.HeaderText = "# Records";
            this.NumRecords.MinimumWidth = 6;
            this.NumRecords.Name = "NumRecords";
            this.NumRecords.ReadOnly = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Text Files|*.txt";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.Filter = "Text Files|*.txt";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_FileTotalRecord);
            this.Controls.Add(this.dgv_DetailRecord);
            this.Controls.Add(this.dgv_DescriptiveRecord);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "ABA Creator";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DescriptiveRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DetailRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_FileTotalRecord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managePayersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchBSBsToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolStripMenuItem paymentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem importFromFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openABAFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveABAFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setPayerToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgv_DescriptiveRecord;
        private System.Windows.Forms.DataGridView dgv_DetailRecord;
        private System.Windows.Forms.DataGridView dgv_FileTotalRecord;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn BSBFormatFiller;
        private System.Windows.Forms.DataGridViewTextBoxColumn NetTotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreditTotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn DebitTotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumRecords;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem newABAFileToolStripMenuItem;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn RecordType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReelSequenceNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinancialInstitution;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserPreferredSpecification;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserBSB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcessDate;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

