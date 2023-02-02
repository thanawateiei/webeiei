using System;
using System.Collections.Generic;

namespace WebVanProject.Models
{
    public partial class Route
    {
        public int RouteId { get; set; }
        public int? DetailId { get; set; }
        public string? OriginProvince { get; set; }
        public string? DestinationProvince { get; set; }
        public string? Point1 { get; set; }
        public string? Point2 { get; set; }
        public string? Point3 { get; set; }
        public string? Point4 { get; set; }
        public string? Point5 { get; set; }
        public string? Point6 { get; set; }
        public string? Point7 { get; set; }
        public string? Point8 { get; set; }
        public string? Point9 { get; set; }
        public string? Point10 { get; set; }
        public string? Point11 { get; set; }
        public string? Point12 { get; set; }
        public string? Point13 { get; set; }
        public string? Point14 { get; set; }
        public string? Point15 { get; set; }
        public string? Point16 { get; set; }
        public string? Point17 { get; set; }
        public string? Point18 { get; set; }
        public string? Point19 { get; set; }
        public string? Point20 { get; set; }
        public string? Point21 { get; set; }
        public string? Point22 { get; set; }
        public string? Point23 { get; set; }
        public string? Point24 { get; set; }
        public string? Point25 { get; set; }
        public string? Point26 { get; set; }
        public string? Point27 { get; set; }
        public string? Point28 { get; set; }
        public string? Point29 { get; set; }
        public string? Point30 { get; set; }

        public virtual Details1? Detail { get; set; }
    }
}
