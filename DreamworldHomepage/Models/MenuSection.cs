using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DreamworldHomepage.Models
{
    public class MenuSection
    {
        public string Text { get; set; }

        public Uri Uri { get; set; }

        public IEnumerable<MenuPage> Pages { get; set; }

        public MenuSection()
        {
            Text = "Undefined";
            Uri = new Uri("www.undefined.com");
            Pages = new List<MenuPage>();
        }
    }
}