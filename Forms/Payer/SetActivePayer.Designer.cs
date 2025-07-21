
namespace Creator.ABA.Forms.Payer
{
    partial class SetActivePayer
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
            btn_OK = new System.Windows.Forms.Button();
            btn_Cancel = new System.Windows.Forms.Button();
            lst_ActivePayers = new System.Windows.Forms.ListBox();
            SuspendLayout();
            // 
            // btn_OK
            // 
            btn_OK.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btn_OK.Location = new System.Drawing.Point(737, 479);
            btn_OK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_OK.Name = "btn_OK";
            btn_OK.Size = new System.Drawing.Size(88, 27);
            btn_OK.TabIndex = 0;
            btn_OK.Text = "OK";
            btn_OK.UseVisualStyleBackColor = true;
            btn_OK.Click += Btn_OK_Click;
            // 
            // btn_Cancel
            // 
            btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btn_Cancel.Location = new System.Drawing.Point(832, 479);
            btn_Cancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new System.Drawing.Size(88, 27);
            btn_Cancel.TabIndex = 1;
            btn_Cancel.Text = "Cancel";
            btn_Cancel.UseVisualStyleBackColor = true;
            btn_Cancel.Click += Btn_Cancel_Click;
            // 
            // lst_ActivePayers
            // 
            lst_ActivePayers.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lst_ActivePayers.FormattingEnabled = true;
            lst_ActivePayers.ItemHeight = 15;
            lst_ActivePayers.Location = new System.Drawing.Point(14, 14);
            lst_ActivePayers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lst_ActivePayers.Name = "lst_ActivePayers";
            lst_ActivePayers.Size = new System.Drawing.Size(905, 454);
            lst_ActivePayers.TabIndex = 2;
            lst_ActivePayers.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // SetActivePayer
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(933, 519);
            Controls.Add(lst_ActivePayers);
            Controls.Add(btn_Cancel);
            Controls.Add(btn_OK);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "SetActivePayer";
            Text = "SetActivePayer";
            Load += SetActivePayer_Load;
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.ListBox lst_ActivePayers;
    }
}