using System;
using System.Collections.Generic;
using TimXe.Data.Entities;

#nullable disable

namespace TimXe.Data.Entities
{
    public partial class VehicleType
    {
        public VehicleType()
        {
            Prices = new HashSet<Price>();
            Vehicles = new HashSet<Vehicle>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
        public int? IdAcount { get; set; }
        public int? IdTrip { get; set; }

        public virtual Account IdAcountNavigation { get; set; }
        public virtual Trip IdTripNavigation { get; set; }
        public virtual ICollection<Price> Prices { get; set; }
        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}
