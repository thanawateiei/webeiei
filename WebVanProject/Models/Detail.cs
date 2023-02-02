using System;
using System.Collections.Generic;

namespace WebVanProject.Models
{
    public partial class Detail
    {
        public int Id { get; set; }
        public string? OriginProvince { get; set; }
        public string? TerminalProvince { get; set; }
        public string? OriginStation { get; set; }
        public string? TerminalStation { get; set; }
        public string? TravelDate { get; set; }
        public int? Price { get; set; }
        public string? Time { get; set; }
        public string? IdCar { get; set; }
    }
}
