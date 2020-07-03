using BarberShopModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BarberShopInfrastructure
{
    class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.HasOne<User>(p => p.user).WithMany(p => p.orders).HasForeignKey(p => p.UserId).IsRequired(true).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne<Status>(p => p.status).WithMany(p => p.orders).HasForeignKey(p => p.StatusId).IsRequired(true).OnDelete(DeleteBehavior.NoAction);
            builder.ToTable("Order");
        }
    }
}
