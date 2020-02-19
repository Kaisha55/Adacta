using System;
using System.Collections.Generic;

namespace adacta_spa.Models
{
    public partial class EventAddress
    {
        public int AddressId { get; set; }
        public int EventId { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressCity { get; set; }
        public string AddressStateCode { get; set; }
        public string AddressZipCode { get; set; }
        public int? RegionId { get; set; }
        public string FullGoogleAddress { get; set; }
        public string Country { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
    }
}
