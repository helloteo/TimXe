using System;
using System.Collections.Generic;

#nullable disable

namespace TimXe.Data.Entities
{
    public partial class Vehicle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LicensePlate { get; set; }
        public int? IdOwner { get; set; }
        public int? IdVehicleType { get; set; }
        public bool? Status { get; set; }

        public virtual Owner IdOwnerNavigation { get; set; }
        public virtual VehicleType IdVehicleTypeNavigation { get; set; }
    }
}
