
namespace Creator.ABA.Forms.Payee
{
    partial class ManagePayee
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
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            btn_Cancel = new System.Windows.Forms.Button();
            btn_OK = new System.Windows.Forms.Button();
            txt_AccountNumber = new System.Windows.Forms.TextBox();
            txt_AccountName = new System.Windows.Forms.TextBox();
            txt_Bsb = new System.Windows.Forms.MaskedTextBox();
            btn_ValidateBsb = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(15, 77);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(102, 15);
            label3.TabIndex = 18;
            label3.Text = "Account Number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(84, 47);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(30, 15);
            label2.TabIndex = 17;
            label2.Text = "BSB:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(26, 17);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(90, 15);
            label1.TabIndex = 16;
            label1.Text = "Account Name:";
            // 
            // btn_Cancel
            // 
            btn_Cancel.Location = new System.Drawing.Point(280, 104);
            btn_Cancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new System.Drawing.Size(88, 27);
            btn_Cancel.TabIndex = 5;
            btn_Cancel.Text = "Cancel";
            btn_Cancel.UseVisualStyleBackColor = true;
            btn_Cancel.Click += Btn_Cancel_Click;
            // 
            // btn_OK
            // 
            btn_OK.Location = new System.Drawing.Point(186, 104);
            btn_OK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_OK.Name = "btn_OK";
            btn_OK.Size = new System.Drawing.Size(88, 27);
            btn_OK.TabIndex = 4;
            btn_OK.Text = "OK";
            btn_OK.UseVisualStyleBackColor = true;
            btn_OK.Click += Btn_SavePayee_Click;
            // 
            // txt_AccountNumber
            // 
            txt_AccountNumber.Location = new System.Drawing.Point(127, 74);
            txt_AccountNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txt_AccountNumber.Name = "txt_AccountNumber";
            txt_AccountNumber.Size = new System.Drawing.Size(240, 23);
            txt_AccountNumber.TabIndex = 3;
            // 
            // txt_AccountName
            // 
            txt_AccountName.Location = new System.Drawing.Point(127, 14);
            txt_AccountName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txt_AccountName.MaxLength = 32;
            txt_AccountName.Name = "txt_AccountName";
            txt_AccountName.Size = new System.Drawing.Size(240, 23);
            txt_AccountName.TabIndex = 10;
            // 
            // txt_Bsb
            // 
            txt_Bsb.Location = new System.Drawing.Point(127, 45);
            txt_Bsb.Mask = "000-999";
            txt_Bsb.Name = "txt_Bsb";
            txt_Bsb.PromptChar = ' ';
            txt_Bsb.Size = new System.Drawing.Size(100, 23);
            txt_Bsb.TabIndex = 1;
            // 
            // btn_ValidateBsb
            // 
            btn_ValidateBsb.BackgroundImage = Properties.Resources.cloud_done_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24;
            btn_ValidateBsb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            btn_ValidateBsb.Location = new System.Drawing.Point(233, 42);
            btn_ValidateBsb.Name = "btn_ValidateBsb";
            btn_ValidateBsb.Size = new System.Drawing.Size(37, 25);
            btn_ValidateBsb.TabIndex = 2;
            btn_ValidateBsb.UseVisualStyleBackColor = true;
            btn_ValidateBsb.Click += btn_ValidateBsb_Click;
            // 
            // ManagePayee
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(383, 152);
            Controls.Add(btn_ValidateBsb);
            Controls.Add(txt_Bsb);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_Cancel);
            Controls.Add(btn_OK);
            Controls.Add(txt_AccountNumber);
            Controls.Add(txt_AccountName);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "ManagePayee";
            Text = "Manage Payee";
            Load += ManagePayee_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.TextBox txt_AccountNumber;
        private System.Windows.Forms.TextBox txt_AccountName;
        private System.Windows.Forms.MaskedTextBox txt_Bsb;
        private System.Windows.Forms.Button btn_ValidateBsb;
    }
}