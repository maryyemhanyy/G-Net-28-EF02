using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHub.Models
{
    public class Organizer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string? CompanyName { get; set; }

        public bool VerifiedStatus { get; set; }

        public OrganizerProfile Profile { get; set; }

        public ICollection<Event>? Events { get; set; } = new HashSet<Event>();
    }
}
