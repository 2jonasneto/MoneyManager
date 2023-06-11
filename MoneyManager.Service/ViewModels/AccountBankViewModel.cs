using System.Data;
using MoneyManager.Application.Base;

namespace MoneyManager.Application.ViewModels
{
    public sealed class AccountBankViewModel:ViewModel
    {

        public string Name { get;  set; } = "";
        public decimal Balance { get;  set; }
        public string Agency { get;  set; } = "";
        public string AccountNumber { get;  set; } = "";

        public EAccountBankType AccountBankType { get;  set; }

        public IReadOnlyCollection<TransactionViewModel> Transactions { get; set; }

    }

}