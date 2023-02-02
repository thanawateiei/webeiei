using System;
using System.Collections.Generic;

namespace WebVanProject.Models
{
    public partial class Station
    {
        public string IdStation { get; set; } = null!;
        public string? IdProvince { get; set; }
        public string? NameStation { get; set; }
        public string? PhoneStation { get; set; }
    }
}
