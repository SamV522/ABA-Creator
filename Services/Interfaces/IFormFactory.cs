using Creator.ABA.Forms.Payee;
using Creator.ABA.Forms.Payer;
using Creator.ABA.Forms.Transactions;

namespace Creator.ABA.Services.Interfaces
{
    public interface IFormFactory
    {
        public AddPayee CreateAddPayeeForm();
        public ManagePayee CreateManagePayeeForm();
        public ManagePayees CreateManagePayeesForm();
        public AddPayer CreateAddPayerForm();
        public ManagePayers CreateManagePayersForm();
        public ManagePayer CreateManagePayerForm();
        public SetActivePayer CreateSetActivePayerForm();
        public AddTransaction CreateAddTransactionForm();
    }
}
