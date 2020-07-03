using System;
using System.Collections.Generic;

namespace BarberShopModel
{
    public class Payment
    {
        public int Id { get; set; }
        public int? BookingId { get; set; }
        public Booking booking { get; set; }

        public int? OrderId { get; set; }
        public Order Order { get; set; }

        public int PriceBeforOff { get; set; }
        public int OffPrice { get; set; }
        public int PriceAfterOff { get; set; }
        public int FinalPrice { get; set; }
        public int PaymentPrice { get; set; }

        public int PaymentForId { get; set; }
        public PaymentFor paymentFor { get; set; }

        public int PaymentTypeId { get; set; }
        public PaymentType paymentType { get; set; }

        public DateTime PaymentDateEn { get; set; }
        public string PaymentDateFa { get; set; }

        public string PaymentCode { get; set; }

        public int StatusId { get; set; }
        public Status status { get; set; }

    }
}
