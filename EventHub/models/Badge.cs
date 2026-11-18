using EventHub.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventHub.models
{

    public class Badge
    {
        public int Id { get; set; }
        public int BadgeNumber { get; set; }
        public DateTime IssuedDate { get; set; }
        public BadgeTier Tier { get; set; }
    }
}
