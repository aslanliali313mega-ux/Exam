using Microsoft.EntityFrameworkCore;
using Qecomvers.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qecomvers.DAL.Configurations
{
    public class ProductImageConfiguration : IEntityTypeConfiguration<ProductImage>
    {
        void IEntityTypeConfiguration<ProductImage>.Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ProductImage> builder)
        {
            builder.Property(e => e.ProductId)
                .IsRequired();

            builder.Property(e => e.ImageUrl)
                .IsRequired();
            
        }
    }
}
