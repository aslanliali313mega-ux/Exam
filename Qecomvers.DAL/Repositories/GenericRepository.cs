using Microsoft.EntityFrameworkCore;
using Qecomvers.DAL.Contexts;
using Qecomvers.Core.Entities.Common;
using Qecomvers.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Qecomvers.DAL.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity, new()
    {
        protected readonly QecomversDbContext _context;

        protected GenericRepository(QecomversDbContext context)
        {
            _context = context;
        }

        protected DbSet<T> Table => _context.Set<T>();

        public async Task AddAsync(T entity) => await Table.AddAsync(entity);

        public void Delete(T entity)
        {
            Table.Remove(entity);
        }

        public async Task DeleteAsync(Guid id)
        {
            var entity = await GetByIdAsync(id);
            if (entity is not null)
            {
                Delete(entity);
            }
        }

        public IQueryable<T> GetAll()
        {
            return Table.AsNoTracking();
        }

        public Task<T?> GetByIdAsync(Guid id)
        {
            return Table.FirstOrDefaultAsync(x => x.Id == id);
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> expression)
        {
            return Table.Where(expression);
        }

        public Task<bool> IsExistAsync(Guid id)
        {
            return Table.AnyAsync(x => x.Id == id);
        }

        public void Update(T entity)
        {
            Table.Update(entity);
        }

        public Task<int> SaveAsync()
        {
            return _context.SaveChangesAsync();
        }
    }
}
