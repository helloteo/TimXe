using System;
using System.Collections.Generic;

#nullable disable

namespace TimXe.Data.Entities
{
    public partial class Account
    {
        public Account()
        {
            Groups = new HashSet<Group>();
            Trips = new HashSet<Trip>();
            VehicleTypes = new HashSet<VehicleType>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string PassWord { get; set; }
        public string Email { get; set; }
        public int? RoleId { get; set; }
        public bool? Status { get; set; }
        public DateTime? CreateAt { get; set; }

        public virtual Role Role { get; set; }
        public virtual ICollection<Group> Groups { get; set; }
        public virtual ICollection<Trip> Trips { get; set; }
        public virtual ICollection<VehicleType> VehicleTypes { get; set; }
    }
}
