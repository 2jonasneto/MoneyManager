using MoneyManager.Domain.Base;
using MoneyManager.Domain.Enums;

namespace MoneyManager.Domain.Entities
{
    public sealed class Transaction : Entity
    {
        public Transaction(decimal currentBalance, decimal incoming, decimal outgoing, DateTime transactionDate, ETransactionType transactionType, Guid accountBankId)
        {
            CurrentBalance = currentBalance;
            Incoming = incoming;
            Outgoing = outgoing;
            TransactionDate = transactionDate;
            TransactionType = transactionType;
            AccountBankId = accountBankId;
        }
        public void Update(decimal currentBalance, decimal incoming, decimal outgoing, DateTime transactionDate, ETransactionType transactionType, Guid accountBankId)
        {
            CurrentBalance += currentBalance + incoming - outgoing;
            Incoming = incoming;
            Outgoing = outgoing;
            TransactionDate = transactionDate;
            TransactionType = transactionType;
            AccountBankId = accountBankId;
        }

        public decimal CurrentBalance { get; private set; }
        public decimal Incoming { get; private set; }
        public decimal Outgoing { get; private set; }
        public DateTime TransactionDate { get; private set; }

        public ETransactionType TransactionType { get; private set; }

        public Guid AccountBankId { get; private set; }
        public AccountBank AccountBank { get; set; }
    }
}