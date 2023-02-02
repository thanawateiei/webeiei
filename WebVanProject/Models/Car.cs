using System;
using System.Collections.Generic;

namespace WebVanProject.Models
{
    public partial class Car
    {
        public string IdCar { get; set; } = null!;
        public string? CarNumber { get; set; }
        public string? TypeCar { get; set; }
    }
}
