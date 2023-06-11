namespace MoneyManager.Domain.Entities
{
    public sealed class     Bill : Entity
    {
        public string Description { get; private set; }

        public EBillType BillType { get; private set; }

        public DateTime DueDate { get; private set; }
        public DateTime Payday { get; private set; }
        public decimal Price { get; private set;}
        public bool IsPaid { get; private set; }
        public EFormPayment FormPayment { get; private set; }

    }
}