using System.Collections.Generic;

namespace BarberShopModel
{
    public class Booking
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public User user { get; set; }

        public int stylistSchaduleId { get; set; }
        public StylistTimeSchadule stylistTime { get; set; }

        public int statusId { get; set; }
        public Status status { get; set; }

        public ICollection<BookingService> bookingServices { get; set; }
        public ICollection<Payment> payments { get; set; }

    }
}
