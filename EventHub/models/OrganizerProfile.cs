using System;
using System.Collections.Generic;
using System.Text;

namespace EventHub.models
{
    public class OrganizerProfile
    {
        public int Id { get; set; }
        public string? Bio { get; set; }
        public string? WebsiteUrl { get; set; }
        public string? LogoUrl { get; set; }
    }
}
