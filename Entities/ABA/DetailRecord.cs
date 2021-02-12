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
        public string PayeeAcc => Payer.AccountNumber.PadLeft(9 - Payer.AccountNumber.Length, ' ');

        public string PayerBSB => Payer.BSB.ToString("000-000");
        public string PayerAcc => Payer.AccountNumber.PadLeft(9 - Payer.AccountNumber.Length, ' ');

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
        public string Amount => (m_Payment.Amount * 100).ToString("0000000000");

        public string TitleOfAccount => Payee.AccountName;

        public string LodgementReference => m_Payment.LodgementReference.PadRight(18-m_Payment.LodgementReference.Length);

        public string TraceRecord => Payer.BSB.ToString("000-000");

        public string AccountNumber => Payer.AccountNumber;

        private string m_NameOfRemitter;

        public string NameOfRemitter
        {
            get { return m_NameOfRemitter; }
            set { m_NameOfRemitter = value.Substring(0,Math.Min(value.Length,16)); }
        }

        public string AmountWithholdingTax => (m_Payment.Tax*100).ToString("00000000");

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

        public DetailRecord(PaymentSender _payer, PaymentRecipient _payee, string _indicator, decimal _amount, decimal _taxWH, string _lodgementReference, string _Remitter)
        {
            Payer = _payer;
            Payee = _payee;
            m_Payment = new Payment(_amount, _taxWH, _lodgementReference);
            Indicator = _indicator;
            NameOfRemitter = _Remitter;
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

        #endregion

        #region Methods
        public string[] ToArray()
        {
            return new string[12] { RecordType, PayerBSB, PayeeAcc, Indicator, TransactionCode, (decimal.Parse(Amount)/100).ToString("F2"), TitleOfAccount, LodgementReference, TraceRecord, AccountNumber, NameOfRemitter, (decimal.Parse(AmountWithholdingTax)/100).ToString("F2") };
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
            str += TraceRecord;
            str += Payer.AccountNumber;
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
