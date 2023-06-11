using MoneyManager.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyManager.Infra.Base
{
    public class UnitForWork : IUnitForWork
    {
        private readonly AppDBContext _dbContext;
        public UnitForWork(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task Save()
        {
           await _dbContext.SaveChangesAsync();
        }
    }
}
