using ABA_Creator.Entities;
using System;

namespace ABA_Creator.Entities.ABA
{
    public class DetailRecord
    {
        #region Properties
        public string RecordType { get; protected set; } = "1";

        public PaymentRecipient Payee { get; set; }
        public PaymentSender Payer { get; set; }
        public Payment m_Payment;

        private string m_Indicator;

        public string PayeeBSB => Payee.BSB.ToString("000-000");
        public string PayeeAcc => Payee.AccountNumber.PadLeft(9, ' ');

        public string PayerBSB => Payer.BSB.ToString("000-000");
        public string PayerAcc => Payer.AccountNumber.PadLeft(9, ' ');

        public string Indicator
        {
            get { return m_Indicator; }
            set { m_Indicator = value.Substring(0,1); }
        }


        private string m_TransactionCode;

        public string TransactionCode
        {
            get { return m_TransactionCode; }
            set { m_TransactionCode = value.Substring(0,2); }
        }
        public string Amount => (m_Payment.Amount * 100).ToString("0").PadLeft(10, '0');

        public string TitleOfAccount => Payee.AccountName.PadRight(32,' ').Substring(0,32);

        public string LodgementReference => m_Payment.LodgementReference.PadRight(18,' ').Substring(0,18);

        public string TraceRecord => PayerBSB;

        public string AccountNumber => PayerAcc;

        private string m_NameOfRemitter;

        public string NameOfRemitter
        {
            get { return m_NameOfRemitter; }
            set { m_NameOfRemitter = value.Substring(0,Math.Min(value.Length,16)); }
        }

        public string AmountWithholdingTax => (m_Payment.Tax*100).ToString("0").PadLeft(8,'0');

        #endregion

        #region Constructors
        public DetailRecord(PaymentSender _payer, PaymentRecipient _payee, string _indicator, decimal _amount, decimal _taxWH, string _lodgementReference, string _Remitter, string _transactioncode = "13")
        {
            Payer = _payer;
            Payee = _payee;
            m_Payment = new Payment(_amount, _taxWH, _lodgementReference);
            Indicator = _indicator;
            NameOfRemitter = _Remitter;
            TransactionCode = _transactioncode;
        }

        public DetailRecord(PaymentSender _payer, PaymentRecipient _payee, string _indicator, decimal _amount, decimal _taxWH, string _Remitter)
        {
            Payer = _payer;
            Payee = _payee;
            m_Payment = new Payment(_amount, _taxWH);
            Indicator = _indicator;
            NameOfRemitter = _Remitter;
        }

        public DetailRecord(PaymentSender _payer, PaymentRecipient _payee, string _indicator, decimal _amount, decimal _taxWH)
        {
            Payer = _payer;
            Payee = _payee;
            m_Payment = new Payment(_amount, _taxWH);
            Indicator = _indicator;
            NameOfRemitter = Payer.AccountName.PadRight(16,' ').Substring(0,16);
        }

        public DetailRecord(PaymentSender _payer, PaymentRecipient _payee, string _indicator, decimal _amount)
        {
            Payer = _payer;
            Payee = _payee;
            m_Payment = new Payment(_amount);
            Indicator = _indicator;
            NameOfRemitter = Payer.AccountName.PadRight(16,' ').Substring(0, 16);
        }

        public DetailRecord(string record)
        : this(new PaymentSender(
                                int.Parse(record.Substring(80, 7).Replace("-","")),
                                record.Substring(87, 9),
                                "   ",
                                "".PadRight(30, ' ')),
                new PaymentRecipient(
                                int.Parse(record.Substring(1, 7).Replace("-","")),
                                record.Substring(8, 9),
                                record.Substring(30, 32)
                                ), " ",
                                decimal.Parse(record.Substring(20, 10))/100,
                                decimal.Parse(record.Substring(112, 8))/100,
                                record.Substring(62, 18),
                                record.Substring(96, 16),
                                record.Substring(18, 2))
        { }

        public DetailRecord(string[] record)
        :this(new PaymentSender(int.Parse(record[8].Replace("-", "")), record[9], "", ""),
                                    new PaymentRecipient(int.Parse(record[1].Replace("-", "")), record[2], record[6]),
                                    record[3],
                                    decimal.Parse(record[5]),
                                    decimal.Parse(record[11]),
                                    record[7],
                                    record[10],
                                    record[4])
        { }
        #endregion

        #region Methods
        public string[] ToArray()
        {
            return new string[12] { RecordType, 
                                        PayeeBSB, 
                                        PayeeAcc, 
                                        Indicator, 
                                        TransactionCode, 
                                        (decimal.Parse(Amount)/100).ToString("F2"), 
                                        TitleOfAccount, 
                                        LodgementReference, 
                                        TraceRecord, 
                                        AccountNumber, 
                                        NameOfRemitter, 
                                        (decimal.Parse(AmountWithholdingTax)/100).ToString("F2") 
                                    };
        }

        public DetailRecord FromArray(string[] array)
        {
            return new DetailRecord(array);
        }

        public override string ToString()
        {
            string str = "";
            str += RecordType;
            str += PayeeBSB;
            str += PayeeAcc;
            str += Indicator;
            str += TransactionCode;
            str += Amount;
            str += TitleOfAccount;
            str += LodgementReference;
            str += PayerBSB;
            str += PayerAcc;
            str += NameOfRemitter;
            str += AmountWithholdingTax;
            return str;
        }

        public static DetailRecord FromString(string record)
        {
            return new DetailRecord(record);
        }
        #endregion
    }
}
