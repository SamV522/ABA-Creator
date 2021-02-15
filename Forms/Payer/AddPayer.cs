using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ABA_Creator.Entities;
using Newtonsoft.Json;

namespace ABA_Creator.Forms.Payer
{
    public partial class AddPayer : Form
    {
        public AddPayer()
        {
            InitializeComponent();
        }

        private void AddPayee_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void alpha_Validation(object sender, KeyPressEventArgs e)
        {
            //// https://stackoverflow.com/questions/12607087/only-allow-specific-characters-in-textbox //
            // Check for a naughty character in the KeyDown event.
            if (e.KeyChar.ToString() == "")
            {
                e.Handled = false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"^[a-zA-Z ]"))
            {
                // Stop the character from being entered into the control since it is illegal.
                e.Handled = true;
            }
        }

        private void numeric_Validation(object sender, KeyPressEventArgs e)
        {
            //// https://stackoverflow.com/questions/12607087/only-allow-specific-characters-in-textbox //
            // Check for a naughty character in the KeyDown event.
            if (e.KeyChar.ToString() == "")
            {
                e.Handled = false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"^[0-9]"))
            {
                // Stop the character from being entered into the control since it is illegal.
                e.Handled = true;
            }
        }

        private void bsb_Validation(object sender, KeyPressEventArgs e)
        {
            Control ctrl = (Control)sender;
            if (e.KeyChar.ToString() == "-" && ctrl.Name == "bsbTxt1")
            {
                e.Handled = true;
                bsbTxt2.Focus();
            }
            else if (e.KeyChar.ToString() == "")
            {
                e.Handled = false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"^[0-9]"))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Add payee to list of payees.
            //List<PaymentRecipient> Payees = JsonMapper.ToObject(Properties.Settings.Default.Payees);
            bool bsbParsed = int.TryParse($"{bsbTxt1.Text}{bsbTxt2.Text}", out int _bsb);
            if(bsbParsed)
            {
                PaymentSender newSender = new PaymentSender(_bsb, textBox4.Text, textBox2.Text,textBox1.Text,textBox3.Text);
                List<PaymentSender> Payers;
                try
                {
                    Payers = JsonConvert.DeserializeObject<List<PaymentSender>>(Properties.Settings.Default.Payers);

                    if (Payers == null) Payers = new List<PaymentSender>();
                    Payers.Add(newSender);
                    string PayersJson = JsonConvert.SerializeObject(Payers);
                    Properties.Settings.Default.Payers = PayersJson;
                    if(MessageBox.Show($"Payer added by account name: {newSender.AccountName}","Payer Added",MessageBoxButtons.OK)==DialogResult.OK)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Properties.Settings.Default.Save();
            }
        }
    }
}
