using System;
using System.Collections.Generic;

namespace BarberShopModel
{
    public class StylistTimeSchadule
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User StylistUser { get; set; }
        public DateTime DateEn { get; set; }
        public string DateFa { get; set; }
        public int From { get; set; }
        public int To { get; set; }
        public bool IsBooking{ get; set; }
        public bool IsFinall{ get; set; }

        public ICollection<Booking> bookings { get; set; }
    }
}
