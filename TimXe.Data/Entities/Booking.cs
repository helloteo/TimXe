using System;
using System.Collections.Generic;

#nullable disable

namespace TimXe.Data.Entities
{
    public partial class Booking
    {
        public int IdOwner { get; set; }
        public int IdTrip { get; set; }
        public int? IdDriver { get; set; }

        public virtual Driver IdDriverNavigation { get; set; }
        public virtual Owner IdOwnerNavigation { get; set; }
        public virtual Trip IdTripNavigation { get; set; }
    }
}
