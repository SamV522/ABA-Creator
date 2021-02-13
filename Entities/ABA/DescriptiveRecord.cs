using System;
using ABA_Creator.Entities;

namespace ABA_Creator.Entities.ABA
{
    public class DescriptiveRecord
    {
        #region Properties
        public string RecordType { get; protected set; } = "0";

        private string m_ReelSequenceNumber = "01";

        public string  ReelSequenceNumber
        {
            get { return m_ReelSequenceNumber; }
            set { m_ReelSequenceNumber = value.Substring(0,2); }
        }

        public UserSupplyingFile Payer { get; set; }


        public string UserFinancialInstitution => Payer.FinancialInstitution;


        public string UserPreferredSpecification => Payer.UserPreferredSpecification;

        public string UserIdentificationNumber => Payer.BSB;


        private string m_Description;

        public string Description
        {
            get { return m_Description; }
            set { m_Description = value.Substring(0,12); }
        }

        private string m_Date = DateTime.Today.ToString("ddmmyy");

        public string Date 
        { 
            get { return m_Date; } 
            set { m_Date = value.Substring(0,6); } 
        }
        #endregion

        #region Constructors
        public DescriptiveRecord(string _ReelSequenceNumber, UserSupplyingFile _Payer,string _Description,string _Date)
        {
            ReelSequenceNumber = _ReelSequenceNumber;
            Payer = _Payer;
            Description = _Description;
            Date = _Date;
        }

        public DescriptiveRecord(string _ReelSequenceNumber, UserSupplyingFile _Payer, string _Description)
        : this(_ReelSequenceNumber, _Payer, _Description, DateTime.Today.ToString("ddmmyy")) { }

        public DescriptiveRecord(string _ReelSequenceNumber, UserSupplyingFile _Payer)
        : this(_ReelSequenceNumber, _Payer, "PAYMENT".PadRight(12, ' '), DateTime.Today.ToString("ddmmyy")) { }

        public DescriptiveRecord(string _ReelSequenceNumber, string _userFI, string _userPS, string _userBSB, string _desc, string _date)
        : this(_ReelSequenceNumber, new UserSupplyingFile(_userFI, _userPS, _userBSB), _desc, _date) { }

        public DescriptiveRecord(string _ReelSequenceNumber, string _userFI, string _userPS, string _userBSB, string _desc)
        : this(_ReelSequenceNumber, new UserSupplyingFile(_userFI, _userPS, _userBSB), _desc, DateTime.Today.ToString("ddmmyy")) { }

        public DescriptiveRecord(string _ReelSequenceNumber, string _userFI, string _userPS, string _userBSB)
        : this(_ReelSequenceNumber, new UserSupplyingFile(_userFI, _userPS, _userBSB), "PAYMENT".PadRight(12,' '), DateTime.Today.ToString("ddmmyy")) { }

        public DescriptiveRecord(string record)
        : this(
                record.Substring(18, 2),    // Reel Sequence #
                    new UserSupplyingFile(  // USF
                        record.Substring(20, 3),    // User Financial Institution
                        record.Substring(30, 26),   // User Preferred Specification
                        record.Substring(56, 6)     // APCA BSB 
                    ),
                record.Substring(62, 12),   // Description of entries in file
                record.Substring(74, 6)     // Date
             )
        { }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"{RecordType}{"".PadRight(17, ' ')}{ReelSequenceNumber}{UserFinancialInstitution}{"".PadRight(7, ' ')}{UserPreferredSpecification}{UserIdentificationNumber}{Description}{Date}{"".PadRight(40, ' ')}";
        }

        public string[] ToArray()
        { 
            return new string[7] {RecordType, ReelSequenceNumber, UserFinancialInstitution, UserPreferredSpecification, Payer.BSB, Description, Date };
        }

        public DescriptiveRecord FromString(string record)
        {
            return new DescriptiveRecord(record); ;
        }

        #endregion
    }
}
