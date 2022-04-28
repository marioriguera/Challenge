namespace Challenge.Repositories.Models
{
    public class Inmueble
    {
        public int Id { get; set; }
        public string AgencyId { get; set; }
        public decimal Price { get; set; }
        public Location Location { get; set; }
        public string OperationType { get; set; }
        public string Type { get; set; }
        public int Rooms { get; set; }
        public int Baths { get; set; }
    }
}