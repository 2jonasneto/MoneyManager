namespace MoneyManager.Domain
{
    public sealed class Movements:Entity
    {
     
        public decimal CurrentBalance { get; private set; }
        public decimal WithDrawal { get; private set; }
        public decimal Deposit { get; private set; }
        public DateTime MovementDate { get; private set; }


        public Guid AccountBankId { get; private set; }
        public AccountBank  AccountBank { get; set; }
    }

}