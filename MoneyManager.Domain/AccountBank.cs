namespace MoneyManager.Domain
{
    public sealed class AccountBank : Entity
    {
        public string Name { get; private set; } = "";
        public Decimal Balance { get; private set; }
        public string Agency { get; private set; } = "";
        public string AccountNumber { get; private set; } = "";

        public EAccountBankType AccountBankType { get; private set; }

        public IReadOnlyCollection<Movements> Movements { get; set; }

    }

}