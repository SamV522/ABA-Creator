using ABA_Creator.Entities;
using System;

namespace ABA_Creator.Entities.ABA
{
    public class DetailRecord
    {
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

        public string[] ToArray()
        {
            return new string[12] { RecordType, PayerBSB, PayeeAcc, Indicator, TransactionCode, Amount, TitleOfAccount, LodgementReference, TraceRecord, AccountNumber, NameOfRemitter, AmountWithholdingTax };
        }

        public override string ToString()
        {
            return $"{RecordType}{PayeeBSB}{PayeeAcc}{Indicator}{TransactionCode}{Amount}{TitleOfAccount}{LodgementReference}{TraceRecord}{AccountNumber}{NameOfRemitter}{AmountWithholdingTax}";
        }

        public DetailRecord(PaymentSender _payer, PaymentRecipient _payee, string _indicator, int _amount, int _taxWH, string _lodgementReference, string _Remitter)
        {
            Payer = _payer;
            Payee = _payee;
            m_Payment = new Payment(_amount, _taxWH, _lodgementReference);
            Indicator = _indicator;
            NameOfRemitter = _Remitter;
        }

        public DetailRecord(PaymentSender _payer, PaymentRecipient _payee, string _indicator, int _amount, int _taxWH, string _Remitter)
        {
            Payer = _payer;
            Payee = _payee;
            m_Payment = new Payment(_amount, _taxWH);
            Indicator = _indicator;
            NameOfRemitter = _Remitter;
        }

        public DetailRecord(PaymentSender _payer, PaymentRecipient _payee, string _indicator, int _amount, int _taxWH)
        {
            Payer = _payer;
            Payee = _payee;
            m_Payment = new Payment(_amount, _taxWH);
            Indicator = _indicator;
            NameOfRemitter = Utilities.BlankPad(Payer.AccountName,Utilities.PadSide.RIGHT,16).Substring(0,16);
        }

        public DetailRecord(PaymentSender _payer, PaymentRecipient _payee, string _indicator, int _amount)
        {
            Payer = _payer;
            Payee = _payee;
            m_Payment = new Payment(_amount);
            Indicator = _indicator;
            NameOfRemitter = Utilities.BlankPad(Payer.AccountName, Utilities.PadSide.RIGHT, 16).Substring(0, 16);
        }
    }
}
