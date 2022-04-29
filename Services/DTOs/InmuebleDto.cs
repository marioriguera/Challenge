using System;

namespace Challenge.Services.DTOs
{
    public class InmuebleDto
    {
        public String AgencyId { get; set; }
        public double? Price { get; set; }
        public LocationDto Location { get; set; }
        public String OperationType { get; set; }
        public String Type { get; set; }
        public int? Rooms { get; set; }
        public int? Baths { get; set; }
    }
}