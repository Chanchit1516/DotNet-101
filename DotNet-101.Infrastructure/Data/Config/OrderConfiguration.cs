using DotNet_101.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNet_101.Infrastructure.Data.Config
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(m => m.Id);
            builder.HasOne(m => m.Customer)
                .WithMany(m => m.Order)
                .HasForeignKey(m => m.CustomerId);
        }
    }
}
