using MoneyManager.Application.Base;

namespace MoneyManager.Application.ViewModels
{
    public sealed class TransactionViewModel : ViewModel
    {
     

        public decimal Incoming { get;  set; }
        public decimal Outgoing { get;  set; }
        public DateTime TransactionDate { get;  set; }

        public ETransactionType TransactionType { get;  set; }

        public Guid AccountBankId { get;  set; }
        public AccountBankViewModel AccountBankViewModel { get; set; }
    }
}