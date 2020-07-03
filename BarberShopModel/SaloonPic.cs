namespace BarberShopModel
{
    public class SaloonPic
    {
        public int Id { get; set; }
        public int SaloonId { get; set; }
        public Saloon Saloon { get; set; }
        public string Image { get; set; }
    }
}
