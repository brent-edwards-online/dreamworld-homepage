using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DreamworldHomepage.Models.Pricing
{
    public class TicketOffice
    {
        public IEnumerable<TicketGroup> TicketGroups { get; set; }

        public TicketOffice()
        {
            TicketGroups = new List<TicketGroup>();
        }
    }
}