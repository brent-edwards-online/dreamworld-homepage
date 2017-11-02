using DreamworldHomepage.Models.ParkUpdate;
using DreamworldHomepage.Models.WhatsGoingOn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DreamworldHomepage.ViewModels
{
    public class ParkUpdatesViewModel
    {        
        public IEnumerable<ParkUpdateItem> Items { get; set; }

        public ParkUpdatesViewModel()
        {
            Items = new List<ParkUpdateItem>();
        }        
        
    }
}