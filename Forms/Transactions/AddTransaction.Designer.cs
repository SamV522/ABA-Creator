
namespace ABA_Creator.Forms.Transactions
{
    partial class AddTransaction
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
            this.cmbo_TranCode = new System.Windows.Forms.ComboBox();
            this.txt_LodgementRef = new System.Windows.Forms.TextBox();
            this.txt_Remitter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nmc_Amount = new System.Windows.Forms.NumericUpDown();
            this.nmc_Tax = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbo_Payees = new System.Windows.Forms.ComboBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmc_Amount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmc_Tax)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbo_TranCode
            // 
            this.cmbo_TranCode.FormattingEnabled = true;
            this.cmbo_TranCode.Items.AddRange(new object[] {
            "13 - Externally initiated debit items",
            "50 - Externally initiated credit items with the exception of those bearing Transa" +
                "ction Codes",
            "51 - Australian Government Security Interest",
            "52 - Family Allowance",
            "53 - Pay",
            "54 - Pension",
            "55 - Allotment",
            "56 - Dividend",
            "57 - Debenture/Note Interest"});
            this.cmbo_TranCode.Location = new System.Drawing.Point(112, 43);
            this.cmbo_TranCode.Name = "cmbo_TranCode";
            this.cmbo_TranCode.Size = new System.Drawing.Size(246, 21);
            this.cmbo_TranCode.TabIndex = 2;
            // 
            // txt_LodgementRef
            // 
            this.txt_LodgementRef.Location = new System.Drawing.Point(112, 122);
            this.txt_LodgementRef.MaxLength = 18;
            this.txt_LodgementRef.Name = "txt_LodgementRef";
            this.txt_LodgementRef.Size = new System.Drawing.Size(246, 20);
            this.txt_LodgementRef.TabIndex = 4;
            // 
            // txt_Remitter
            // 
            this.txt_Remitter.Location = new System.Drawing.Point(112, 148);
            this.txt_Remitter.MaxLength = 16;
            this.txt_Remitter.Name = "txt_Remitter";
            this.txt_Remitter.Size = new System.Drawing.Size(246, 20);
            this.txt_Remitter.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Transaction Code:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Amount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Lodgement Ref:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Name Of Remitter:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tax:";
            // 
            // nmc_Amount
            // 
            this.nmc_Amount.DecimalPlaces = 2;
            this.nmc_Amount.Location = new System.Drawing.Point(112, 70);
            this.nmc_Amount.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nmc_Amount.Name = "nmc_Amount";
            this.nmc_Amount.Size = new System.Drawing.Size(121, 20);
            this.nmc_Amount.TabIndex = 11;
            // 
            // nmc_Tax
            // 
            this.nmc_Tax.DecimalPlaces = 2;
            this.nmc_Tax.Location = new System.Drawing.Point(112, 96);
            this.nmc_Tax.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nmc_Tax.Name = "nmc_Tax";
            this.nmc_Tax.Size = new System.Drawing.Size(121, 20);
            this.nmc_Tax.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Payee:";
            // 
            // cmbo_Payees
            // 
            this.cmbo_Payees.FormattingEnabled = true;
            this.cmbo_Payees.Location = new System.Drawing.Point(112, 16);
            this.cmbo_Payees.Name = "cmbo_Payees";
            this.cmbo_Payees.Size = new System.Drawing.Size(246, 21);
            this.cmbo_Payees.TabIndex = 14;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.Location = new System.Drawing.Point(283, 193);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 15;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Add.Location = new System.Drawing.Point(202, 193);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 16;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 228);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.cmbo_Payees);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nmc_Tax);
            this.Controls.Add(this.nmc_Amount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Remitter);
            this.Controls.Add(this.txt_LodgementRef);
            this.Controls.Add(this.cmbo_TranCode);
            this.Name = "AddTransaction";
            this.Text = "AddTransaction";
            this.Load += new System.EventHandler(this.AddTransaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmc_Amount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmc_Tax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbo_TranCode;
        private System.Windows.Forms.TextBox txt_LodgementRef;
        private System.Windows.Forms.TextBox txt_Remitter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nmc_Amount;
        private System.Windows.Forms.NumericUpDown nmc_Tax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbo_Payees;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Add;
    }
}