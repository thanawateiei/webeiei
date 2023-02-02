using System;
using System.Collections.Generic;

namespace WebVanProject.Models
{
    public partial class Ticket
    {
        public string IdTicket { get; set; } = null!;
        public int? UserId { get; set; }
        public string? OriginProvince { get; set; }
        public string? TerminalProvince { get; set; }
        public string? OriginStation { get; set; }
        public string? TerminalStation { get; set; }
        public string? TravelDate { get; set; }
        public int? Price { get; set; }
        public string? Passenger { get; set; }
        public int? TotalPrice { get; set; }
        public int? IdPayment { get; set; }
        public string? DepartureTime { get; set; }
        public string? DateTicket { get; set; }
        public string? IdCar { get; set; }

        public virtual User? User { get; set; }
    }
}
