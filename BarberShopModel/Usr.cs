using System;
using System.Collections.Generic;

namespace BarberShopModel
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string Phone { get; set; }
        public DateTime BirthdateEn { get; set; }
        public string BirthDateFa { get; set; }
        public string Pic { get; set; }
        public string Nickname { get; set; }
        public bool IsBarber { get; set; }
        public string ActiveCode { get; set; }
        public byte[] password { get; set; }
        public bool IsActive { get; set; }
        public bool IsWomen { get; set; }
        //این فیلد برای آرایشگران مورد استفاده قرار میگیرد که توسط ادمین پر میگردد و اگر تایید نشود اکانت وی لاک است
        public bool IsAcceptByAdmin { get; set; }

        public  ICollection<SaloonStylist> SaloonUsers { get; set; }
        public  ICollection<StylistSample> stylistSamples { get; set; }
        public  ICollection<ServiceStylist> serviceUsers { get; set; }
        public  ICollection<StylistTimeSchadule> stylistTimeSchadules { get; set; }
        public  ICollection<Booking> bookings { get; set; }
        public  ICollection<CargoComment> cargoComments { get; set; }
        public  ICollection<Order> orders { get; set; }
    }
}
