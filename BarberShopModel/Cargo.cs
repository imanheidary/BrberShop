using System.Collections.Generic;

namespace BarberShopModel
{
    public class Cargo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Balance { get; set; }
        public int CargoTypeId { get; set; }
        public CargoType CargoType { get; set; }
        public bool IsActive { get; set; }

        public ICollection<CargoComment> cargoComments { get; set; }
        public ICollection<OrderCargo> orderCargos { get; set; }


    }
}
