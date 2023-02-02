using System;
using System.Collections.Generic;

namespace WebVanProject.Models
{
    public partial class Location
    {
        public int LocationId { get; set; }
        public int DetailId { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }

        public virtual Details1 Detail { get; set; } = null!;
    }
}
