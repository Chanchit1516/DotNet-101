using DotNet_101.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNet_101.Infrastructure.Data.Config
{
    public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.HasKey(m => new { m.OrderId, m.ProductId });
            builder.HasIndex(m => m.ProductId);
            builder
                .HasOne(m => m.Order)
                .WithMany(m => m.OrderDetail)
                .HasForeignKey(m => m.OrderId);
            builder
                .HasOne(m => m.Product)
                .WithMany()
                .HasForeignKey(m => m.ProductId);
        }
    }
}
