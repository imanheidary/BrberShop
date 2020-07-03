using System.Collections.Generic;

namespace BarberShopModel
{
    public class PaymentType
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsActive { get; set; }

        public ICollection<Payment> payments { get; set; }

    }
}
