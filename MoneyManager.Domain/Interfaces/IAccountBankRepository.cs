using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyManager.Domain.Interfaces
{
    public interface IAccountBankRepository <T>:IRepository<T> where T : class
    {

    }
}
