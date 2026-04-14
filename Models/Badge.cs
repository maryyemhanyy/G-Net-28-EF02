using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHub.Models
{
   public class Badge
    {
        public int Id { get; set; }

        public int BadgeNumber { get; set; }

        public DateTime Badgedate { get; set; }

        public BadgeTier Tier { get; set; }

        public int AttendeesId {  get; set; }
        public Attendee Attendees { get; set; }
    }
}
