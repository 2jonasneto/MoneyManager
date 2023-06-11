using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MoneyManager.Domain.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task Add(T entity);
        Task Update(T entity);
        Task Delete(Guid id);

        Task <IEnumerable<T>> GetAll();
        Task <T> GetById(Guid id);
        Task<IEnumerable<T>> GetByQuery(Expression<Func<T,bool>> expression);
    }
}
