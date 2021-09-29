using System;
using System.Collections.Generic;

#nullable disable

namespace TimXe.Data.Entities
{
    public partial class Channel
    {
        public Channel()
        {
            Trips = new HashSet<Trip>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public int? IdChannelType { get; set; }
        public int? IdGroup { get; set; }
        public bool? Status { get; set; }

        public virtual ChannelType IdChannelTypeNavigation { get; set; }
        public virtual Group IdGroupNavigation { get; set; }
        public virtual ICollection<Trip> Trips { get; set; }
    }
}
