using System.Collections.Generic;

namespace BarberShopModel
{
    public class Saloon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Manager { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longtitude { get; set; }
        public string Address { get; set; }
        public string Logo { get; set; }
        public bool IsWomen { get; set; }
        public bool IsMen { get; set; }
        public bool IsActive { get; set; }

        public  ICollection<SaloonPic> saloonPics { get; set; }
        public  ICollection<SaloonStylist> SaloonUsers { get; set; }
    }
}
