using System;
using System.Collections.Generic;

#nullable disable

namespace TimXe.Data.Entities
{
    public partial class PriceItem
    {
        public int Id { get; set; }
        public string FromKm { get; set; }
        public string Tokm { get; set; }
        public string Description { get; set; }
        public int? IdPrice { get; set; }

        public virtual Price IdPriceNavigation { get; set; }
    }
}
