using System;
using System.Collections.Generic;

namespace adacta_spa.Models
{
    public partial class CityLocations
    {
        public string Location { get; set; }
        public string State { get; set; }
        public string Id { get; set; }
        public double? Lat { get; set; }
        public double? Lon { get; set; }
    }
}
