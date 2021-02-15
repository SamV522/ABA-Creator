using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABA_Creator.Entities
{
    public class UserSupplyingFile
    {
        private string m_financialInstitution;

        public string FinancialInstitution
        {
            get { return m_financialInstitution; }
            set { m_financialInstitution = value.Substring(0,3); }
        }

        private string m_UserPreferredSpecification;

        public string UserPreferredSpecification
        {
            get { return m_UserPreferredSpecification; }
            set { m_UserPreferredSpecification = value.PadRight(26,' ').Substring(0,26); }
        }


        private string m_UserIdentificationNumber;

        public string UserIdentificationNumber
        {
            get { return m_UserIdentificationNumber; }
            set { m_UserIdentificationNumber = value.PadLeft(6,'0').Substring(0,6); }
        }

        public UserSupplyingFile(string _FI, string _UPS, string _UID)
        {
            FinancialInstitution = _FI;
            UserPreferredSpecification = _UPS;
            UserIdentificationNumber = _UID;
        }
    }
}
