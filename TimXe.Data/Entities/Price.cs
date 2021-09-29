using System;
using System.Collections.Generic;

#nullable disable

namespace TimXe.Data.Entities
{
    public partial class Price
    {
        public Price()
        {
            PriceItems = new HashSet<PriceItem>();
        }

        public int Id { get; set; }
        public double? Price1 { get; set; }
        public string Description { get; set; }
        public int? IdGroup { get; set; }
        public int? IdVehicleType { get; set; }
        public int? IdAcount { get; set; }

        public virtual VehicleType IdVehicleTypeNavigation { get; set; }
        public virtual ICollection<PriceItem> PriceItems { get; set; }
    }
}
