using BarberShopModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BarberShopInfrastructure
{
    class CargoCommentConfiguration : IEntityTypeConfiguration<CargoComment>
    {
        public void Configure(EntityTypeBuilder<CargoComment> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.ToTable("CargoComment");
        }
    }
}
