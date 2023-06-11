namespace MoneyManager.Domain.Entities
{
    public sealed class Bill : Entity
    {
        public Bill(string description, EBillType billType, DateTime dueDate, DateTime payday, decimal price, bool isPaid, EFormPayment formPayment)
        {
            Description = description;
            BillType = billType;
            DueDate = dueDate;
            Payday = payday;
            Price = price;
            IsPaid = isPaid;
            FormPayment = formPayment;
        }
        public void Update(string description, EBillType billType, DateTime dueDate, DateTime payday, decimal price, bool isPaid, EFormPayment formPayment)
        {
            Description = description;
            BillType = billType;
            DueDate = dueDate;
            Payday = payday;
            Price = price;
            IsPaid = isPaid;
            FormPayment = formPayment;
        }
        public void SetPaid(DateTime payday, decimal price, bool isPaid, EFormPayment formPayment, Guid transactionId)
        {
            Payday = payday;
            Price = price;
            IsPaid = isPaid;
            FormPayment = formPayment;
            TransactionId = transactionId;
        }
        public string Description { get; private set; }

        public EBillType BillType { get; private set; }

        public DateTime DueDate { get; private set; }
        public DateTime Payday { get; private set; }
        public decimal Price { get; private set; }
        public bool IsPaid { get; private set; }
        public Guid TransactionId { get; private set; }= Guid.Empty;
        public EFormPayment FormPayment { get; private set; }

    }
}