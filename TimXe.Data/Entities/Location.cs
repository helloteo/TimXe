using System;
using System.Collections.Generic;

#nullable disable

namespace TimXe.Data.Entities
{
    public partial class Location
    {
        public int Id { get; set; }
        public string Coordinates { get; set; }
        public string LatLon { get; set; }
        public string Address { get; set; }
        public int? PointTypeValue { get; set; }
        public int? OrderNumber { get; set; }
        public int? IdTrip { get; set; }

        public virtual Trip IdTripNavigation { get; set; }
    }
}
