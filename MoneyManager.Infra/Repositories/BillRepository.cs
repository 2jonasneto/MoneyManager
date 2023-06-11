using MoneyManager.Domain.Entities;
using MoneyManager.Domain.Interfaces;
using MoneyManager.Infra.Base;

namespace MoneyManager.Infra.Repositories
{
    public sealed class BillRepository : RepositoryBase<Bill>, IBillRepository
    {
        public BillRepository(AppDBContext context, IUnitForWork uow) : base(context, uow)
        {
        }
    }
}
