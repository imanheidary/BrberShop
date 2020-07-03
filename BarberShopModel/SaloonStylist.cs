namespace BarberShopModel
{
    public class SaloonStylist
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User StylistUser { get; set; }
        public int SaloonId { get; set; }
        public Saloon saloon { get; set; }
        public bool IsActive { get; set; }
    }
}
