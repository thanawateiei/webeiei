using System;
using System.Collections.Generic;

namespace WebVanProject.Models
{
    public partial class User
    {
        public User()
        {
            Tickets = new HashSet<Ticket>();
        }

        public int UserId { get; set; }
        public string? Email { get; set; }
        public int? Password { get; set; }
        public string? Status { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
