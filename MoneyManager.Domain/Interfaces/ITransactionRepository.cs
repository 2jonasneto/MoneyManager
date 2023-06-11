namespace MoneyManager.Domain.Interfaces
{
    public interface ITransactionRepository<T> : IRepository<T> where T : class
    {

    }
}
