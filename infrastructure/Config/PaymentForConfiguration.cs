using BarberShopModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BarberShopInfrastructure
{
    class PaymentForConfiguration : IEntityTypeConfiguration<PaymentFor>
    {
        public void Configure(EntityTypeBuilder<PaymentFor> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Title).HasMaxLength(50);
            builder.HasIndex(p => p.Title).IsUnique(true);
            builder.ToTable("PaymentFor");
        }
    }
}
