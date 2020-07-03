using System;
using System.Collections.Generic;

namespace BarberShopModel
{
    public class CargoComment
    {
        public int Id { get; set; }
        public string comment { get; set; }

        public int CargoId { get; set; }
        public Cargo cargo { get; set; }

        public int UserId { get; set; }
        public User user { get; set; }

        public DateTime DateEn { get; set; }
        public string DateFa { get; set; }
    }
}
