using System;
using System.Collections.Generic;

namespace adacta_spa.Models
{
    public partial class Event
    {
        public int EventId { get; set; }
        public int? ReporterId { get; set; }
        public int? EventTypeId { get; set; }
        public int? CountryId { get; set; }
        public string EventShortDesc { get; set; }
        public string EventSourceLink { get; set; }
        public string EventNotes { get; set; }
        public DateTime? EventDate { get; set; }
        public decimal? EventLocationLat { get; set; }
        public decimal? EventLocationLong { get; set; }
        public string EventLocationDesc { get; set; }
    }
}
