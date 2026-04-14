using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHub.Models
{
   public class OrganizerProfile
    {
        public int Id { get; set; }

        public string? Biography { get; set; }
        public string? link { get; set; }

        public string? logo { get; set; }

        public int OrganizerId { get; set; }
        public Organizer Organizer { get; set; }


    }
}
