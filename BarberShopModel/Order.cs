using System;
using System.Collections.Generic;

namespace BarberShopModel
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User user { get; set; }

        public int StatusId { get; set; }
        public Status status { get; set; }

        public DateTime DateEn { get; set; }
        public string DateFa { get; set; }
        public bool IsDeliver { get; set; }
        public DateTime DateDeliverEn { get; set; }
        public string DateDeliverFa { get; set; }

        public int PriceBeforOff { get; set; }
        public int OffPrice { get; set; }
        public int FinallPrice { get; set; }
        public string AddressTodeliver { get; set; }


        public ICollection<Payment> payments { get; set; }
        public ICollection<OrderCargo> orderCargos { get; set; }


    }
}
