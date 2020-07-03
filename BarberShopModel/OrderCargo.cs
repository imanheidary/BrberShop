using System;
using System.Collections.Generic;

namespace BarberShopModel
{
    public class OrderCargo
    {
        public int Id { get; set; }
        public int CargoId { get; set; }
        public Cargo cargo { get; set; }

        public int OrderId { get; set; }
        public Order order { get; set; }

        public int Count { get; set; }

        //count*unitprice
        public int Price { get; set; }


    }
}
