using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DreamworldHomepage.Models.Pricing
{
    public enum TicketType
    {
        Ticket,
        Pass,
        Package
    }

    public class Ticket
    {
        public string Title { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }
        public string OfferTitle { get; set; }
        public string OfferText { get; set; }
        public string Image { get; set; }
        public string TicketColor { get; set; }
        public TicketType TicketType { get; set; }        
    }
}