using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DreamworldHomepage.Models.Pricing
{
    public class TicketGroup
    {
        public string Text { get; set; }
        public IEnumerable <Ticket> Tickets { get; set; }
        
        public TicketGroup()
        {
            Tickets = new List<Ticket>();
        }
    }
}