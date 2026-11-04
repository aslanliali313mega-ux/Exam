using Qecomvers.Core.Entities.Common;
using Qecomvers.Core.Repositories;
using Qecomvers.DAL.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qecomvers.DAL.Repositories
{
    public class ProductCategoryRepository : GenericRepository<ProductCategory>, IProductCategoryRepository
    {
        public ProductCategoryRepository(QecomversDbContext context) : base(context)
        {
        }
    }

}
