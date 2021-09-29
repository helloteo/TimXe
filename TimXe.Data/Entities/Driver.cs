using System;
using System.Collections.Generic;

#nullable disable

namespace TimXe.Data.Entities
{
    public partial class Driver
    {
        public Driver()
        {
            Bookings = new HashSet<Booking>();
        }

        public int Id { get; set; }
        public string DriverName { get; set; }
        public string DriverPhone { get; set; }
        public int? IdOwner { get; set; }

        public virtual Owner IdOwnerNavigation { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
