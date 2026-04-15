using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHub.Models
{
    public class Registration
    {
        public string? Note { get; set; }

        public DateTime RegisDate { get; set; }

        public Attendee Attendee { get; set; }
        public int AttendeeId { get; set; }

        public Event Event { get; set; }

        public int EventId { get; set; }

    }
}
