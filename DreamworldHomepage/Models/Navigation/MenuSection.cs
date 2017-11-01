using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DreamworldHomepage.Models.Navigation
{
    public class MenuSection
    {
        public IEnumerable<MenuCategory> Categories { get; set; }

        public MenuSection()
        {            
            Categories = new List<MenuCategory>();
        }
    }
}