
namespace Creator.ABA.Forms.Payee
{
    partial class ManagePayees
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
            lst_Payees = new System.Windows.Forms.ListBox();
            btn_Delete = new System.Windows.Forms.Button();
            btn_Edit = new System.Windows.Forms.Button();
            btn_New = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lst_Payees
            // 
            lst_Payees.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lst_Payees.FormattingEnabled = true;
            lst_Payees.ItemHeight = 15;
            lst_Payees.Location = new System.Drawing.Point(14, 14);
            lst_Payees.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lst_Payees.Name = "lst_Payees";
            lst_Payees.Size = new System.Drawing.Size(380, 454);
            lst_Payees.TabIndex = 0;
            // 
            // btn_Delete
            // 
            btn_Delete.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btn_Delete.Location = new System.Drawing.Point(14, 479);
            btn_Delete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new System.Drawing.Size(88, 27);
            btn_Delete.TabIndex = 1;
            btn_Delete.Text = "Delete";
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += button1_Click;
            // 
            // btn_Edit
            // 
            btn_Edit.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btn_Edit.Location = new System.Drawing.Point(108, 479);
            btn_Edit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_Edit.Name = "btn_Edit";
            btn_Edit.Size = new System.Drawing.Size(88, 27);
            btn_Edit.TabIndex = 2;
            btn_Edit.Text = "Edit";
            btn_Edit.UseVisualStyleBackColor = true;
            btn_Edit.Click += Btn_Edit_Click;
            // 
            // btn_New
            // 
            btn_New.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btn_New.Location = new System.Drawing.Point(307, 479);
            btn_New.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_New.Name = "btn_New";
            btn_New.Size = new System.Drawing.Size(88, 27);
            btn_New.TabIndex = 3;
            btn_New.Text = "New";
            btn_New.UseVisualStyleBackColor = true;
            btn_New.Click += button3_Click;
            // 
            // ManagePayees
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(408, 519);
            Controls.Add(btn_New);
            Controls.Add(btn_Edit);
            Controls.Add(btn_Delete);
            Controls.Add(lst_Payees);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "ManagePayees";
            Text = "ManagePayees";
            Load += ManagePayees_Load;
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lst_Payees;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_New;
    }
}