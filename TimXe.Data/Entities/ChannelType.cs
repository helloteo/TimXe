﻿using System;
using System.Collections.Generic;

#nullable disable

namespace TimXe.Data.Entities
{
    public partial class ChannelType
    {
        public ChannelType()
        {
            Channels = new HashSet<Channel>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Channel> Channels { get; set; }
    }
}
