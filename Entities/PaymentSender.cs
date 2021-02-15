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
            set { m_UserPreferredSpecification = value; }
        }


        private string m_UserIdentificationNumber;

        public string UserIdentificationNumber
        {
            get { return m_UserIdentificationNumber; }
            set { m_UserIdentificationNumber = value; }
        }
        #endregion

        #region Constructors
        public PaymentSender() { }

        public PaymentSender(int _BSB, string _AccountNumber, string _FinancialInstitution, string _AccountName) : base(_BSB, _AccountNumber, _AccountName)
        {
            BSB = _BSB;
            AccountNumber = _AccountNumber;
            FinancialInstitution = _FinancialInstitution;
            AccountName = _AccountName;
            UserPreferredSpecification = _AccountName.PadRight(26, ' ').Substring(0, 26);
        }

        public PaymentSender(int _BSB, string _AccountNumber, string _FinancialInstitution, string _AccountName, string _UIN) : base( _BSB, _AccountNumber, _AccountName)
        {
            BSB = _BSB;
            AccountNumber = _AccountNumber;
            FinancialInstitution = _FinancialInstitution;
            AccountName = _AccountName;
            UserPreferredSpecification = _AccountName;//.PadRight(26, ' ').Substring(0, 26);
            UserIdentificationNumber = _UIN;
        }
        #endregion
    }
}
