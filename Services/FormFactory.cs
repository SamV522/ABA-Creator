using Creator.ABA.Forms.Payee;
using Creator.ABA.Forms.Payer;
using Creator.ABA.Forms.Transactions;
using Creator.ABA.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Creator.ABA.Services
{
    public class FormFactory : IFormFactory
    {
        private readonly IServiceProvider sp;

        public FormFactory(IServiceProvider serviceProvider) => sp = serviceProvider;

        public AddPayee CreateAddPayeeForm() => sp.GetRequiredService<AddPayee>();
        public ManagePayees CreateManagePayeesForm() => sp.GetRequiredService<ManagePayees>();
        public ManagePayee CreateManagePayeeForm() => sp.GetRequiredService<ManagePayee>();
        public AddPayer CreateAddPayerForm() => sp.GetRequiredService<AddPayer>();
        public ManagePayers CreateManagePayersForm() => sp.GetRequiredService<ManagePayers>();
        public ManagePayer CreateManagePayerForm() => sp.GetRequiredService<ManagePayer>();
        public SetActivePayer CreateSetActivePayerForm() => sp.GetRequiredService<SetActivePayer>();
        public AddTransaction CreateAddTransactionForm() => sp.GetRequiredService<AddTransaction>();

    }
}
