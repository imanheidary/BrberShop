using BarberShopModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BarberShopInfrastructure
{
    class CargoConfiguration : IEntityTypeConfiguration<Cargo>
    {
        public void Configure(EntityTypeBuilder<Cargo> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Name).HasMaxLength(200);
            builder.HasIndex(p =>new { p.Name, p.CargoTypeId }).IsUnique(true);
            builder.HasOne<CargoType>(p => p.CargoType).WithMany(p => p.cargos).HasForeignKey(p => p.CargoTypeId).IsRequired(true).OnDelete(DeleteBehavior.NoAction);
            builder.ToTable("Cargo");
        }
    }
}
