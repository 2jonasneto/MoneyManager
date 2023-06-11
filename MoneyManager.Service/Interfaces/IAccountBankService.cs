using MoneyManager.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyManager.Application.Interfaces
{
    public interface IAccountBankService
    {
        Task AddAccountBank(AccountBankViewModel account);
        Task UpdateAccountBank(AccountBankViewModel account);
        Task<IEnumerable<AccountBankViewModel>> GetAll();
        Task ChangeBalance(Guid id, decimal value);
    }
}
