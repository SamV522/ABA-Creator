
namespace Creator.ABA.Forms.Payer
{ 
    partial class AddPayer
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
            txt_AccountName = new System.Windows.Forms.TextBox();
            txt_AccountNumber = new System.Windows.Forms.TextBox();
            btn_OK = new System.Windows.Forms.Button();
            btn_Cancel = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            txt_FICode = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            txt_UserID = new System.Windows.Forms.TextBox();
            button3 = new System.Windows.Forms.Button();
            txt_Bsb = new System.Windows.Forms.MaskedTextBox();
            SuspendLayout();
            // 
            // txt_AccountName
            // 
            txt_AccountName.Location = new System.Drawing.Point(126, 14);
            txt_AccountName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txt_AccountName.MaxLength = 26;
            txt_AccountName.Name = "txt_AccountName";
            txt_AccountName.Size = new System.Drawing.Size(240, 23);
            txt_AccountName.TabIndex = 0;
            txt_AccountName.KeyPress += alpha_Validation;
            // 
            // txt_AccountNumber
            // 
            txt_AccountNumber.Location = new System.Drawing.Point(126, 134);
            txt_AccountNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txt_AccountNumber.Name = "txt_AccountNumber";
            txt_AccountNumber.Size = new System.Drawing.Size(240, 23);
            txt_AccountNumber.TabIndex = 5;
            txt_AccountNumber.KeyPress += numeric_Validation;
            // 
            // btn_OK
            // 
            btn_OK.Location = new System.Drawing.Point(184, 164);
            btn_OK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_OK.Name = "btn_OK";
            btn_OK.Size = new System.Drawing.Size(88, 27);
            btn_OK.TabIndex = 6;
            btn_OK.Text = "OK";
            btn_OK.UseVisualStyleBackColor = true;
            btn_OK.Click += button1_Click;
            // 
            // btn_Cancel
            // 
            btn_Cancel.Location = new System.Drawing.Point(279, 164);
            btn_Cancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new System.Drawing.Size(88, 27);
            btn_Cancel.TabIndex = 7;
            btn_Cancel.Text = "Cancel";
            btn_Cancel.UseVisualStyleBackColor = true;
            btn_Cancel.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(24, 17);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(90, 15);
            label1.TabIndex = 6;
            label1.Text = "Account Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(83, 47);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(30, 15);
            label2.TabIndex = 7;
            label2.Text = "BSB:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(14, 134);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(102, 15);
            label3.TabIndex = 8;
            label3.Text = "Account Number:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(55, 107);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(64, 15);
            label5.TabIndex = 10;
            label5.Text = "Institution:";
            // 
            // txt_FICode
            // 
            txt_FICode.Location = new System.Drawing.Point(126, 104);
            txt_FICode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txt_FICode.MaxLength = 3;
            txt_FICode.Name = "txt_FICode";
            txt_FICode.Size = new System.Drawing.Size(41, 23);
            txt_FICode.TabIndex = 4;
            txt_FICode.KeyPress += alpha_Validation;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(69, 77);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(47, 15);
            label6.TabIndex = 11;
            label6.Text = "User ID:";
            // 
            // txt_UserID
            // 
            txt_UserID.Location = new System.Drawing.Point(126, 74);
            txt_UserID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txt_UserID.MaxLength = 6;
            txt_UserID.Name = "txt_UserID";
            txt_UserID.Size = new System.Drawing.Size(60, 23);
            txt_UserID.TabIndex = 3;
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.cloud_done_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24;
            button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            button3.Location = new System.Drawing.Point(232, 42);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(37, 24);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txt_Bsb
            // 
            txt_Bsb.Location = new System.Drawing.Point(126, 44);
            txt_Bsb.Mask = "000-999";
            txt_Bsb.Name = "txt_Bsb";
            txt_Bsb.PromptChar = ' ';
            txt_Bsb.Size = new System.Drawing.Size(100, 23);
            txt_Bsb.TabIndex = 1;
            // 
            // AddPayer
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(383, 208);
            Controls.Add(txt_Bsb);
            Controls.Add(button3);
            Controls.Add(txt_UserID);
            Controls.Add(label6);
            Controls.Add(txt_FICode);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_Cancel);
            Controls.Add(btn_OK);
            Controls.Add(txt_AccountNumber);
            Controls.Add(txt_AccountName);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddPayer";
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            Text = "Add Payer";
            Load += AddPayee_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_AccountName;
        private System.Windows.Forms.TextBox txt_AccountNumber;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_FICode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_UserID;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MaskedTextBox txt_Bsb;
    }
}