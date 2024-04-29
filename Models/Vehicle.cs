namespace Autos.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public string Color { get; set; }
        public decimal PricePerDay { get; set; }
        public decimal Price { get; set; }
        public bool Available { get; set; }
    }
}
