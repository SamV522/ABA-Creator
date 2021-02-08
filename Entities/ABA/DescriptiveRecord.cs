using System;
using ABA_Creator.Entities;

namespace ABA_Creator.Entities.ABA
{
    class DescriptiveRecord
    {
        public string RecordType { get; protected set; } = "0";

        private string m_ReelSequenceNumber = "01";

        public string  ReelSequenceNumber
        {
            get { return m_ReelSequenceNumber; }
            set { m_ReelSequenceNumber = value.Substring(0,1); }
        }

        public PaymentSender Payer { get; set; }


        public string UserFinancialInstitution => Payer.FinancialInstitution;


        public string UserPreferredSpecification => Utilities.Pad(Payer.AccountName, Utilities.PadSide.RIGHT, 26, " ");

        public string UserIdentificationNumber => Payer.BSB.ToString("000000");


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

        public override string ToString()
        {
            return $"{RecordType}{Utilities.Pad(17," ")}{ReelSequenceNumber}{UserFinancialInstitution}{Utilities.Pad(7," ")}{UserPreferredSpecification}{UserIdentificationNumber}{Description}{Date}{Utilities.Pad(40," ")}";
        }

        public DescriptiveRecord(string _ReelSequenceNumber,PaymentSender _Payer,string _Description,string _Date)
        {
            ReelSequenceNumber = _ReelSequenceNumber;
            Payer = _Payer;
            Description = _Description;
            Date = _Date;
        }

        public DescriptiveRecord(string _ReelSequenceNumber, PaymentSender _Payer, string _Description)
        {
            ReelSequenceNumber = _ReelSequenceNumber;
            Payer = _Payer;
            Description = _Description;
            Date = DateTime.Today.ToString("ddmmyy");
        }

        public DescriptiveRecord(string _ReelSequenceNumber, PaymentSender _Payer)
        {
            ReelSequenceNumber = _ReelSequenceNumber;
            Payer = _Payer;
            Description = Utilities.BlankPad("PAYMENT", Utilities.PadSide.RIGHT, 12);
        }

        /*public DescriptiveRecord FromString(string record)
        {
            //string _recordType = record.Substring()

        }*/
    }
}
