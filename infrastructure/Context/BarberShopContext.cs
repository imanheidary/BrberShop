using BarberShopModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BarberShopInfrastructure
{
    class BarberShopContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=.;initial catalog=Barbershop;integrated security=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var Alltype = System.Reflection.Assembly.GetExecutingAssembly().GetTypes();
            foreach (var item in Alltype)
            {
                if (item.GetType() == typeof(IEntityTypeConfiguration<>))
                {
                    dynamic tp = Activator.CreateInstance(item);
                    modelBuilder.ApplyConfiguration(tp);
                }
            }
        }

        public DbSet<User> users { get; set; }
        public DbSet<StylistTimeSchadule> stylistTimeSchadules { get; set; }
        public DbSet<StylistSample> stylistSamples { get; set; }
        public DbSet<Status> statuses { get; set; }
        public DbSet<Service> services { get; set; }
        public DbSet<ServiceStylist> serviceStylists { get; set; }
        public DbSet<Saloon> saloons { get; set; }
        public DbSet<SaloonPic> saloonPics { get; set; }
        public DbSet<SaloonStylist> saloonStylists { get; set; }
        public DbSet<PaymentFor> paymentFors { get; set; }
        public DbSet<PaymentType> paymentTypes { get; set; }
        public DbSet<Payment> payments { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<OrderCargo> orderCargos { get; set; }
        public DbSet<Cargo> cargos { get; set; }
        public DbSet<CargoComment> cargoComments { get; set; }
        public DbSet<CargoType> cargoTypes { get; set; }
        public DbSet<Booking> bookings { get; set; }
        public DbSet<BookingService> bookingServices { get; set; }

    }
}
