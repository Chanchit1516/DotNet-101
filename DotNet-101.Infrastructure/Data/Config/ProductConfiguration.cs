using DotNet_101.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNet_101.Infrastructure.Data.Config
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(m => m.Id);
            builder.HasOne(m => m.Order)
                .WithMany(m => m.Product)
                .HasForeignKey(m => m.Id);
            //builder.HasOne(m => m.Order).WithMany(m => m.Product).HasForeignKey(m => m.OrderId);
        }
    }
}
