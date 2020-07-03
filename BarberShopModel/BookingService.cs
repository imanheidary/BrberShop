namespace BarberShopModel
{
    public class BookingService
    {
        public int Id { get; set; }

        public int bookingId { get; set; }
        public Booking booking { get; set; }

        public int ServiceId { get; set; }
        public ServiceStylist serviceUser  { get; set; }

    
    }
}
