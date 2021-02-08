using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ABA_Creator.Entities;
using Newtonsoft.Json;

namespace ABA_Creator.Forms.Payee
{
    public partial class AddPayee : Form
    {
        public AddPayee()
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
                PaymentRecipient newRecipient = new PaymentRecipient(_bsb, textBox4.Text, textBox1.Text);
                List<PaymentRecipient> Payees;
                try
                {
                    Payees = JsonConvert.DeserializeObject<List<PaymentRecipient>>(Properties.Settings.Default.Payees);

                    if (Payees == null) Payees = new List<PaymentRecipient>();
                    Payees.Add(newRecipient);
                    string PayeesJson = JsonConvert.SerializeObject(Payees);
                    Properties.Settings.Default.Payees = PayeesJson;
                    if(MessageBox.Show($"Payee added by account name: {newRecipient.AccountName}","Payee Added",MessageBoxButtons.OK)==DialogResult.OK)
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
