using DreamworldHomepage.Models.WhatsGoingOn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DreamworldHomepage.ViewModels
{
    public class WhatsGoingOnViewModel
    {
        public string Title { get; set; }
        public IEnumerable<WhatsGoingOnItem> Items { get; set; }

        public WhatsGoingOnViewModel()
        {
            Items = new List<WhatsGoingOnItem>();
        }        
        
    }
}