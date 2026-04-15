using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHub.Models
{
    public class Attendee
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public string Email { get; set; }

        public Address Address { get; set; }

        public Badge? Badge { get; set; }

        public ICollection<Registration>? Registrations { get; set; } = new HashSet<Registration>();

       
    }
}
