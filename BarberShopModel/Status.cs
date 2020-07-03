using System.Collections.Generic;

namespace BarberShopModel
{
    public class Status
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsActive { get; set; }
        public ICollection<Booking> bookings { get; set; }
        public ICollection<Payment> payments { get; set; }
        public ICollection<Order> orders { get; set; }

    }
}
