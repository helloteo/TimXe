using System;
using System.Collections.Generic;
using TimXe.Data.Entities;

#nullable disable

namespace TimXe.Data.Entities
{
    public partial class Group
    {
        public Group()
        {
            Channels = new HashSet<Channel>();
            News = new HashSet<News>();
            Owners = new HashSet<Owner>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int? IdAcount { get; set; }
        public int? IdCity { get; set; }
        public bool? Status { get; set; }

        public virtual Account IdAcountNavigation { get; set; }
        public virtual City IdCityNavigation { get; set; }
        public virtual ICollection<Channel> Channels { get; set; }
        public virtual ICollection<News> News { get; set; }
        public virtual ICollection<Owner> Owners { get; set; }
    }
}
