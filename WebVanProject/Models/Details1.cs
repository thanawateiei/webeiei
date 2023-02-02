using System;
using System.Collections.Generic;

namespace WebVanProject.Models
{
    public partial class Details1
    {
        public Details1()
        {
            Locations = new HashSet<Location>();
            Routes = new HashSet<Route>();
        }

        public int DetailId { get; set; }
        public string? OriginProvince { get; set; }
        public string? DestinationProvince { get; set; }
        public string? OriginDistrict { get; set; }
        public string? Destination { get; set; }
        public string? QueueName { get; set; }
        public string? StartTime { get; set; }
        public string? EndTime { get; set; }
        public string? PhoneNumber { get; set; }
        public int? Fare { get; set; }
        public string? Route { get; set; }
        public string? PickupDetail { get; set; }

        public virtual ICollection<Location> Locations { get; set; }
        public virtual ICollection<Route> Routes { get; set; }
    }
}
