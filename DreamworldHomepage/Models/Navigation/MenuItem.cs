using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DreamworldHomepage.Models.Navigation
{
    public class MenuItem
    {
        public string Text { get; set; }
        public IEnumerable<MenuSection> Sections { get; set; }

        public MenuItem()
        {
            Text = "Undefined";
            Sections = new List<MenuSection>();
        }
    }
}