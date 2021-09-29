using System;
using System.Collections.Generic;
using TimXe.Data.Entities;

#nullable disable

namespace TimXe.Data.Entities
{
    public partial class Trip
    {
        public Trip()
        {
            Bookings = new HashSet<Booking>();
            Locations = new HashSet<Location>();
            VehicleTypes = new HashSet<VehicleType>();
        }

        public int Id { get; set; }
        public double? PriceBooking { get; set; }
        public DateTime? CreateAt { get; set; }
        public int? IdAcount { get; set; }
        public int? IdVehicle { get; set; }
        public int? IdChannel { get; set; }
        public bool? Status { get; set; }
        public string NameCustomer { get; set; }
        public string PhoneCustomer { get; set; }

        public virtual Account IdAcountNavigation { get; set; }
        public virtual Channel IdChannelNavigation { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; }
        public virtual ICollection<Location> Locations { get; set; }
        public virtual ICollection<VehicleType> VehicleTypes { get; set; }
    }
}
