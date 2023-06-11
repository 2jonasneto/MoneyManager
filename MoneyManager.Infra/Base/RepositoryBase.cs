using Microsoft.EntityFrameworkCore;
using MoneyManager.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyManager.Infra.Base
{
    public class RepositoryBase<T> : IRepository<T> where T : class
    {
        private readonly AppDBContext _context;
        private readonly IUnitForWork _uow;
        private readonly DbSet<T> _dbSet;

        public RepositoryBase(AppDBContext context, IUnitForWork uow)
        {
            _context = context;
            _uow = uow;
            _dbSet = _context.Set<T>();
        }
        public async Task Add(T entity)
        {
            _dbSet.Add(entity);
            await _uow.Save();
        }
        public async Task Update(T entity)
        {
            _dbSet.Update(entity);
            await _uow.Save();
        }
        public async Task Delete(Guid id)
        {
            var entity = _dbSet.Find(id);

            if (entity == null) return;
            else _dbSet.Remove(entity);
            await _uow.Save();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
          return await _dbSet.AsNoTracking().ToListAsync();
        }

        public async Task<T> GetById(Guid id)
        {
           var rst=await _dbSet.FindAsync(id);
           return rst;
        }

        public async Task<IEnumerable<T>> GetByQuery(System.Linq.Expressions.Expression<Func<T, bool>> expression)
        {
            return await _dbSet.Where(expression).AsNoTracking().ToListAsync();
        }


    }
}
