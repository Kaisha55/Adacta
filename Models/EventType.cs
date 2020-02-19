using System;
using System.Collections.Generic;

namespace adacta_spa.Models
{
    public partial class EventType
    {
        public int EventTypeId { get; set; }
        public string EventTypeDesc { get; set; }
        public string EventIconName { get; set; }
        public bool ActiveFlag { get; set; }
    }
}
