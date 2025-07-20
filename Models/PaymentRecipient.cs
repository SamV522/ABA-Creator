using System;
using System.ComponentModel.DataAnnotations;

namespace Creator.ABA.Models
{
    [Serializable]
    public class PaymentRecipient
    {
        protected int m_BSB;

        [Required]
        public int BSB
        {
            get { return m_BSB; }
            set { m_BSB = Math.Min(999999,value); }
        }

        protected string m_accountNumber;

        [Required, MaxLength(9)]
        public string AccountNumber
        {
            get { return m_accountNumber; }
            set { m_accountNumber = value?.Substring(0, Math.Min(value.Length, 9)); }
        }

        protected string m_AccountName;

        [Required, MaxLength(32)]
        virtual public string AccountName
        {
            get { return m_AccountName; }
            set { m_AccountName = value?.Substring(0,Math.Min(value.Length,32)); }
        }

        public PaymentRecipient() { }

        public PaymentRecipient(int _BSB, string _AccountNumber, string _AccountName)
        {
            BSB = _BSB;
            AccountNumber = _AccountNumber;
            AccountName = _AccountName;
        }
        public override string ToString()
        {
            return $"{AccountName.ToUpper().PadRight(26)} - BSB: {BSB} - Acc: {AccountNumber}";
        }
    }
}
