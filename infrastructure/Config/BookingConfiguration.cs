using BarberShopModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BarberShopInfrastructure
{
    class BookingConfiguration : IEntityTypeConfiguration<Booking>
    {
        public void Configure(EntityTypeBuilder<Booking> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.HasOne<User>(p => p.user).WithMany(p => p.bookings).HasForeignKey(p => p.UserId).IsRequired(true).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne<StylistTimeSchadule>(p => p.stylistTime).WithMany(p => p.bookings).HasForeignKey(p => p.stylistSchaduleId).IsRequired(true).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne<Status>(p => p.status).WithMany(p => p.bookings).HasForeignKey(p => p.statusId).IsRequired(true).OnDelete(DeleteBehavior.NoAction);
            builder.ToTable("Booking");
        }
    }
}
