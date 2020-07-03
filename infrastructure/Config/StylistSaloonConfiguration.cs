using BarberShopModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BarberShopInfrastructure
{
    class StylistSaloonConfiguration : IEntityTypeConfiguration<SaloonStylist>
    {
        public void Configure(EntityTypeBuilder<SaloonStylist> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.HasOne<User>(p => p.StylistUser).WithMany(p => p.SaloonUsers).HasForeignKey(p => p.UserId).IsRequired(true).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne<Saloon>(p => p.saloon).WithMany(p => p.SaloonUsers).HasForeignKey(p => p.SaloonId).IsRequired(true).OnDelete(DeleteBehavior.NoAction);
            builder.HasIndex(p =>new { p.UserId,p.SaloonId }).IsUnique(true);
            builder.ToTable("SaloonStylist");
        }
    }
}
