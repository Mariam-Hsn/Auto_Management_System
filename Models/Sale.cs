namespace Autos.Models
{
    public class Sale
    {
        public int Id { get; set; }
        public int VehicleId { get; set; }
        public int UserId { get; set; }
        public DateTime SaleDate { get; set; }  
        public decimal Price { get; set; }
    }
}
