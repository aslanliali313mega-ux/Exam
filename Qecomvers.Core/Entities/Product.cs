using Qecomvers.Core.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qecomvers.Core.Entities
{
    public class Product : BaseEntity
    {
       public string Name { get; set; }
public string Price { get; set; }
public string Description { get; set; }
public int Discount { get; set; }
public string Count { get; set; }
public string ImageUrl { get; set; }

public ICollection<ProductCategory> ProductCategories { get; set; }
        public ICollection<ProductImage> ProductImages { get; set; }
    }
}
