using BarberShopModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BarberShopInfrastructure
{
    class PaymentConfiguration : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.HasOne<Booking>(p => p.booking).WithMany(p => p.payments).HasForeignKey(p => p.BookingId).IsRequired(false).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne<Order>(p => p.Order).WithMany(p => p.payments).HasForeignKey(p => p.OrderId).IsRequired(false).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne<PaymentType>(p => p.paymentType).WithMany(p => p.payments).HasForeignKey(p => p.PaymentTypeId).IsRequired(true).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne<PaymentFor>(p => p.paymentFor).WithMany(p => p.payments).HasForeignKey(p => p.PaymentForId).IsRequired(true).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne<Status>(p => p.status).WithMany(p => p.payments).HasForeignKey(p => p.StatusId).IsRequired(true).OnDelete(DeleteBehavior.NoAction);
            builder.ToTable("Payment");
        }
    }
}
