namespace Challenge.Services.DTOs
{
    public class InmuebleDto
    {
        public string AgencyId { get; set; }
        public double? Price { get; set; }
        public LocationDto Location { get; set; }
        public string OperationType { get; set; }
        public string Type { get; set; }
        public int? Rooms { get; set; }
        public int? Baths { get; set; }
    }
}