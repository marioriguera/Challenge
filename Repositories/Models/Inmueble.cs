using System;

namespace Challenge.Repositories.Models
{
    public class Inmueble
    {
        public int Id { get; set; }
        public String AgencyId { get; set; }
        public double? Price { get; set; }
        public Location Location { get; set; }
        public String OperationType { get; set; }
        public String Type { get; set; }
        public int? Rooms { get; set; }
        public int? Baths { get; set; }
    }
}