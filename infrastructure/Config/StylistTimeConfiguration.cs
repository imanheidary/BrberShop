using BarberShopModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BarberShopInfrastructure
{
    class StylistTimeConfiguration : IEntityTypeConfiguration<StylistTimeSchadule>
    {
        public void Configure(EntityTypeBuilder<StylistTimeSchadule> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.HasOne<User>(p => p.StylistUser).WithMany(p => p.stylistTimeSchadules).HasForeignKey(p=>p.UserId).IsRequired(true).OnDelete(DeleteBehavior.NoAction);
            builder.HasIndex(p => new { p.DateEn, p.From, p.To, p.UserId }).IsUnique(true).HasName("UniqueRecorde");
            builder.ToTable("StylistTimeSchadule");
        }
    }
}
