using System.Data;
using MoneyManager.Domain.Base;
using MoneyManager.Shared.Enums;

namespace MoneyManager.Domain.Entities
{
    public sealed class AccountBank : Entity
    {
        public AccountBank(string name, decimal balance, string agency, string accountNumber, EAccountBankType accountBankType)
        {
            Name = name;
            Balance = balance;
            Agency = agency;
            AccountNumber = accountNumber;
            AccountBankType = accountBankType;
        }
        public void Update(string name, decimal balance, string agency, string accountNumber, EAccountBankType accountBankType)
        {
            Name = name;
            Balance = balance;
            Agency = agency;
            AccountNumber = accountNumber;
            AccountBankType = accountBankType;
        }
        public void ChangeBalance(decimal value)
        {
            Balance += value;
        }
        public string Name { get; private set; } = "";
        public decimal Balance { get; private set; }
        public string Agency { get; private set; } = "";
        public string AccountNumber { get; private set; } = "";

        public EAccountBankType AccountBankType { get; private set; }

        public IReadOnlyCollection<Transaction> Transactions { get; set; }

    }

}