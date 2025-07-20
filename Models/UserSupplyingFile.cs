namespace Creator.ABA.Models
{
    public class UserSupplyingFile
    {
        private string m_financialInstitution;

        public string FinancialInstitution
        {
            get { return m_financialInstitution; }
            set { m_financialInstitution = value.Substring(0, 3); }
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
            set { m_UserIdentificationNumber = value.PadLeft(6,'0').Substring(0,6); }
        }

        public UserSupplyingFile(string _FinancialInstitution, string _UserPreferredSpecification, string _UserIndefiicationNumber)
        {
            FinancialInstitution = _FinancialInstitution;
            UserPreferredSpecification = _UserPreferredSpecification;
            UserIdentificationNumber = _UserIndefiicationNumber;
        }

        public UserSupplyingFile(PaymentSender payer)
        {
            FinancialInstitution = payer.FinancialInstitution;
            UserPreferredSpecification = payer.UserPreferredSpecification;
            UserIdentificationNumber = payer.UserIdentificationNumber;
        }
    }
}
