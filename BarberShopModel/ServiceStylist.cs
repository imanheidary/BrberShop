using System.Collections.Generic;

namespace BarberShopModel
{
    public class ServiceStylist
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User StylistUser { get; set; }
        public int ServiceId { get; set; }
        public Service service { get; set; }
        public bool IsActive { get; set; }

        public ICollection<BookingService> bookingServices { get; set; }
    }
}
