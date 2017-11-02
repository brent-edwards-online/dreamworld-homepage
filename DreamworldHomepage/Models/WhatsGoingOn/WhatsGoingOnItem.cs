using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DreamworldHomepage.Models.WhatsGoingOn
{
    public class WhatsGoingOnItem
    {
        public string Title { get; set; }
        public string DateText { get; set; }
        public string Image { get; set; }
        public string Color { get; set; }
        public Uri Uri { get; set; }
    }
}