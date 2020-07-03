namespace BarberShopModel
{
    public class StylistSample
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User stylistyUser { get; set; }
        public string Image { get; set; }
    }
}
