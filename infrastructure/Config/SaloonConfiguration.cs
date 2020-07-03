using BarberShopModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BarberShopInfrastructure
{
    class SaloonConfiguration : IEntityTypeConfiguration<Saloon>
    {
        public void Configure(EntityTypeBuilder<Saloon> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Name).HasMaxLength(100);
            builder.HasIndex(p =>new { p.Name,p.IsMen,p.IsWomen }).IsUnique(true);
            builder.ToTable("Saloon");
        }
    }
}
