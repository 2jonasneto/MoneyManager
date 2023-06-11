using MoneyManager.Domain.Entities;
using MoneyManager.Domain.Interfaces;
using MoneyManager.Infra.Base;

namespace MoneyManager.Infra.Repositories
{
    public sealed class TransactionRepository : RepositoryBase<Transaction>, ITransactionRepository
    {
        public TransactionRepository(AppDBContext context, IUnitForWork uow) : base(context, uow)
        {
        }
    }
}
