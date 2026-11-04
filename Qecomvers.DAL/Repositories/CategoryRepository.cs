using Qecomvers.Core.Entities;
using Qecomvers.Core.Repositories;
using Qecomvers.DAL.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qecomvers.DAL.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(QecomversDbContext context) : base(context)
        {
        }
    }
}
