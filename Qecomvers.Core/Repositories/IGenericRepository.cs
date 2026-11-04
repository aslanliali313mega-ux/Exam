using Qecomvers.Core.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Qecomvers.Core.Repositories
{
    public interface IGenericRepository<T> where T : BaseEntity, new()
    {
        IQueryable<T> GetAll();
        Task<T?> GetByIdAsync(Guid id);
        IQueryable<T> GetWhere(Expression<Func<T, bool>> expression);
        Task<bool> IsExistAsync(Guid id);
        Task AddAsync(T entity);
        void Update(T entity);
        void Delete(T entity);
        Task DeleteAsync(Guid id);
        Task<int> SaveAsync();
    }
}
