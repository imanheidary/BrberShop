using BarberShopModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BarberShopInfrastructure
{
    class OrderCargoConfiguration : IEntityTypeConfiguration<OrderCargo>
    {
        public void Configure(EntityTypeBuilder<OrderCargo> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.HasOne<Cargo>(p => p.cargo).WithMany(p => p.orderCargos).HasForeignKey(p => p.CargoId).IsRequired(true).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne<Order>(p => p.order).WithMany(p => p.orderCargos).HasForeignKey(p => p.OrderId).IsRequired(true).OnDelete(DeleteBehavior.NoAction);
            builder.ToTable("OrderCargo");
        }
    }
}
