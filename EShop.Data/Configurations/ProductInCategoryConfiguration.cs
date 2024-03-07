using System;
using System.Collections.Generic;
using System.Text;
using EShop.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EShop.Data.Configurations
{
    public class ProductInCategoryConfiguration : IEntityTypeConfiguration<ProductInCategory>
    {
        public void Configure(EntityTypeBuilder<ProductInCategory> builder)
        {
            builder.ToTable("ProductInCategories");

            builder.HasKey(x => new {x.CategoryId, x.ProductId });

            builder.HasOne(x => x.Product).WithMany(p => p.ProductInCategories).HasForeignKey(p => p.ProductId);

            builder.HasOne(x => x.Category).WithMany(c => c.ProductInCategories).HasForeignKey(c => c.CategoryId);

           
        }
    }
}
