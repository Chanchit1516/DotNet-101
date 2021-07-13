using DotNet_101.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNet_101.Infrastructure.Data.Config
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(m => m.CustomerId);
            builder.HasMany(m => m.Order)
                .WithOne(m => m.Customer)
                .HasForeignKey(m => m.CustomerId);
        }
    }
}
