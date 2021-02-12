using System;
using System.Collections.Generic;
using System.Linq;

namespace ABA_Creator.Entities.ABA
{
    public class FileTotalRecord
    {
        public string RecordType = "7";
        public string BSBFiller = "999-999";
        public List<DetailRecord> CreditDetailRecords;
        public List<DetailRecord> DebitDetailRecords;
        private decimal CreditAmount => CreditDetailRecords.Select(record => record.m_Payment.Amount).Sum();
        private decimal DebitAmount => DebitDetailRecords.Select(record => record.m_Payment.Amount).Sum();
        private decimal DifferenceAmount => Math.Abs(CreditAmount) + Math.Abs(DebitAmount);
        public string NetTotal => DifferenceAmount.ToString("0000000000");
        public string CreditTotal => CreditAmount.ToString("0000000000");
        public string DebitTotal => DebitAmount.ToString("0000000000");
        public string CountOfRecords => (CreditDetailRecords.Count + DebitDetailRecords.Count).ToString("000000");

        public FileTotalRecord(List<DetailRecord> _CreditDetailRecords, List<DetailRecord> _DebitDetailRecords)
        {
            CreditDetailRecords = _CreditDetailRecords;
            DebitDetailRecords = _DebitDetailRecords;
        }

        public FileTotalRecord(List<DetailRecord> Transactions)
        {
            CreditDetailRecords = (from trans in Transactions
                                   where trans.TransactionCode != "13"
                                   select trans).ToList<DetailRecord>();
            DebitDetailRecords = (from trans in Transactions
                                  where trans.TransactionCode == "13"
                                  select trans).ToList<DetailRecord>();
        }

        public override string ToString()
        {
            return $"{RecordType}{BSBFiller}{"".PadRight(12, ' ')}{NetTotal}{CreditTotal}{DebitTotal}{"".PadRight(24, ' ')}{CountOfRecords}{"".PadRight(40, ' ')}";
        }

        public string[] ToArray()
        {
            return new string[] { 
                RecordType,
                BSBFiller,
                (decimal.Parse(NetTotal)/100).ToString("F2"),
                (decimal.Parse(CreditTotal)/100).ToString("F2"),
                (decimal.Parse(DebitTotal)/100).ToString("F2"),
                CountOfRecords };
        }
    }
}
