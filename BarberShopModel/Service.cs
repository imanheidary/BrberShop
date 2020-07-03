using System.Collections.Generic;

namespace BarberShopModel
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool ForWoman { get; set; }
        public bool ForMan { get; set; }
        public int Price { get; set; }
        //تمامی زمانها به دقیقه می باشد
        public int time { get; set; }
        public bool IsActive { get; set; }

        public ICollection<ServiceStylist> serviceUsers { get; set; }
    }
}
