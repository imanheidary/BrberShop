using BarberShopModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BarberShopInfrastructure
{
    class StylistSampleConfiguration : IEntityTypeConfiguration<StylistSample>
    {
        public void Configure(EntityTypeBuilder<StylistSample> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.HasOne<User>(p => p.stylistyUser).WithMany(p => p.stylistSamples).HasForeignKey(p=>p.UserId).IsRequired(true).OnDelete(DeleteBehavior.NoAction);
            builder.ToTable("StylistSample");
        }
    }
}
