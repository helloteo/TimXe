using System;
using System.Collections.Generic;

#nullable disable

namespace TimXe.Data.Entities
{
    public partial class Owner
    {
        public Owner()
        {
            Bookings = new HashSet<Booking>();
            Drivers = new HashSet<Driver>();
            Vehicles = new HashSet<Vehicle>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int? IdGroup { get; set; }

        public virtual Group IdGroupNavigation { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; }
        public virtual ICollection<Driver> Drivers { get; set; }
        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}
