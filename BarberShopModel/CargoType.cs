using System.Collections.Generic;

namespace BarberShopModel
{
    public class CargoType
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsActive { get; set; }

        public ICollection<Cargo> cargos { get; set; }


    }
}
