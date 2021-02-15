using System;

namespace ABA_Creator.Entities
{
    [Serializable]
    public class PaymentSender : PaymentRecipient
    {
        #region Properties
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

        private string m_UserPreferredSpecification;

        public string UserPreferredSpecification
        {
            get { return m_UserPreferredSpecification; }
            set { m_UserPreferredSpecification = value.PadRight(26, ' ').Substring(0, 26); }
        }


        private string m_UserIdentificationNumber;

        public string UserIdentificationNumber
        {
            get { return m_UserIdentificationNumber; }
            set { m_UserIdentificationNumber = value.PadLeft(6, '0').Substring(0, 6); }
        }
        #endregion

        public PaymentSender() { }

        public PaymentSender(int _BSB, string _AccountNumber, string _FinancialInstitution, string _AccountName) : base(_BSB, _AccountNumber,_AccountName)
        {
            FinancialInstitution = _FinancialInstitution;
            AccountName = _AccountName;
        }
    }
}
