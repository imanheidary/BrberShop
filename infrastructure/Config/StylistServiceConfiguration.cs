using BarberShopModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BarberShopInfrastructure
{
    class StylistServiceConfiguration : IEntityTypeConfiguration<ServiceStylist>
    {
        public void Configure(EntityTypeBuilder<ServiceStylist> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.HasOne<User>(p => p.StylistUser).WithMany(p => p.serviceUsers).HasForeignKey(p => p.UserId).IsRequired(true).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne<Service>(p => p.service).WithMany(p => p.serviceUsers).HasForeignKey(p => p.ServiceId).IsRequired(true).OnDelete(DeleteBehavior.NoAction);
            builder.HasIndex(p =>new { p.UserId,p.ServiceId }).IsUnique(true);
            builder.ToTable("ServiceStylist");
        }
    }
}
