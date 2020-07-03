using BarberShopModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BarberShopInfrastructure
{
    class BookingServiceConfiguration : IEntityTypeConfiguration<BookingService>
    {
        public void Configure(EntityTypeBuilder<BookingService> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.HasOne<Booking>(p => p.booking).WithMany(p => p.bookingServices).HasForeignKey(p => p.bookingId).IsRequired(true).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne<ServiceStylist>(p => p.serviceUser).WithMany(p => p.bookingServices).HasForeignKey(p => p.ServiceId).IsRequired(true).OnDelete(DeleteBehavior.NoAction);
            builder.ToTable("BookingService");
        }
    }
}
