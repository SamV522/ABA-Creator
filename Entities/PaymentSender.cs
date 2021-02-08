using System;

namespace ABA_Creator.Entities
{
    [Serializable]
    public class PaymentSender : PaymentRecipient
    {
        private string m_FinancialInstitution;

        public string FinancialInstitution
        {
            get { return m_FinancialInstitution; }
            set { m_FinancialInstitution = value.ToUpper().Substring(0, Math.Min(value.Length,3)); }
        }

        override public string AccountName
        {
            get { return m_AccountName; }
            set { m_AccountName = value.Substring(0, Math.Min(value.Length,26)); }
        }

        public PaymentSender() { }

        public PaymentSender(int _BSB, string _AccountNumber, string _FinancialInstitution, string _AccountName) : base(_BSB, _AccountNumber,_AccountName)
        {
            FinancialInstitution = _FinancialInstitution;
            AccountName = _AccountName;
        }
    }
}
