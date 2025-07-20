namespace Creator.ABA.Models
{
    public class Payment
    {
        public decimal Amount = 0;
        public decimal Tax = 0;
        private string m_LodgementReference = "PAYMENT";

        public string LodgementReference
        {
            get { return m_LodgementReference; }
            set { m_LodgementReference = value; }
        }

        public Payment(decimal _amount, decimal _tax, string _reference)
        {
            Amount = _amount;
            Tax = _tax;
            LodgementReference = _reference;
        }

        public Payment(decimal _amount, decimal _tax)
        {
            Amount = _amount;
            Tax = _tax;
        }

        public Payment(decimal _amount)
        {
            Amount = _amount;
        }
    }
}
