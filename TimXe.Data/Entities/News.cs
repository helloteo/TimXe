using System;
using System.Collections.Generic;

#nullable disable

namespace TimXe.Data.Entities
{
    public partial class News
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public int? IdGroup { get; set; }

        public virtual Group IdGroupNavigation { get; set; }
    }
}
