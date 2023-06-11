using MoneyManager.Domain.Entities;
using MoneyManager.Domain.Interfaces;
using MoneyManager.Infra.Base;

namespace MoneyManager.Infra.Repositories
{
    public sealed class AccountBankRepository : RepositoryBase<AccountBank>, IAccountBankRepository
    {
        public AccountBankRepository(AppDBContext context, IUnitForWork uow) : base(context, uow)
        {

        }
    }
}
