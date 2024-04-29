namespace Autos.Models
{
    public class Rental
    {
        public int Id { get; set; }
        public int VehicleId { get; set; }
        public int UserId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
