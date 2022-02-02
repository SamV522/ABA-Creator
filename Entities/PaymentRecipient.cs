using System;

namespace ABA_Creator.Entities
{
    [Serializable]
    public class PaymentRecipient
    {
        protected int m_BSB;

        public int BSB
        {
            get { return m_BSB; }
            set { m_BSB = Math.Min(999999,value); }
        }

        protected string m_accountNumber;

        public string AccountNumber
        {
            get { return m_accountNumber; }
            set { m_accountNumber = value.Substring(0, Math.Min(value.Length, 9)); }
        }

        protected string m_AccountName;

        virtual public string AccountName
        {
            get { return m_AccountName; }
            set { m_AccountName = value.Substring(0,Math.Min(value.Length,32)); }
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
