using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Qecomvers.Core.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qecomvers.DAL.Configurations
{
    public class ProductCategoryConfiguration : IEntityTypeConfiguration<ProductCategory>
    {
        void IEntityTypeConfiguration<ProductCategory>.Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            builder.Property(e => e.ProductId)
                .IsRequired();

            builder.Property(e => e.CategoryId)
                .IsRequired();
        }
    }
}
