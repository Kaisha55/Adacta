using System;
using System.Collections.Generic;

namespace adacta_spa.Models
{
    public partial class EventUpdate
    {
        public int EventUpdateId { get; set; }
        public int EventId { get; set; }
        public DateTime Timestamp { get; set; }
        public int UserId { get; set; }
        public string UpdateDesc { get; set; }
        public int EventStatusId { get; set; }
    }
}
