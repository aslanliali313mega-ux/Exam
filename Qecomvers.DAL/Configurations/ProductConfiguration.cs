using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Qecomvers.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qecomvers.DAL.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(e => e.Name)
            .IsRequired()
            .HasMaxLength(256);
            builder.Property(e => e.Price)
            .IsRequired()
            .HasDefaultValue(0);
            builder.Property(e => e.Description)
            .IsRequired()
            .HasMaxLength(512);
            builder.Property(e => e.Discount)
            .IsRequired()
            .HasDefaultValue(0);
            builder.Property(e => e.Count)
           .IsRequired()
           .HasDefaultValue(0);
            builder.Property(e => e.Stars)
           .IsRequired()
           .HasDefaultValue(0);
            builder.Property(e => e.Stars)
            .HasMaxLength(1)
            .IsFixedLength(true);

            builder.Property(e => e.ImageUrl)
                .IsRequired();

            builder.HasMany(e => e.ProductImages)
             .WithOne(e => e.Product)
             .HasForeignKey(e => e.ProductId)
             .OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(e => e.ProductCategories)
                .WithOne(e => e.Product)
                .HasForeignKey(e => e.ProductId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(e => e.ProductSizes)
                .WithOne(e => e.Product)
                .HasForeignKey(e => e.ProductId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(e => e.ProductColors)
                .WithOne(e => e.Product)
                .HasForeignKey(e => e.ProductId)
                .OnDelete(DeleteBehavior.Cascade);


        }
    }
}
