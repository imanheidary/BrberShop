using BarberShopModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BarberShopInfrastructure
{
    class SaloonPicConfiguration : IEntityTypeConfiguration<SaloonPic>
    {
        public void Configure(EntityTypeBuilder<SaloonPic> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.HasOne<Saloon>(p => p.Saloon).WithMany(p => p.saloonPics).HasForeignKey(p => p.SaloonId).IsRequired(true).OnDelete(DeleteBehavior.NoAction);

            builder.ToTable("SaloonPic");
        }
    }
}
