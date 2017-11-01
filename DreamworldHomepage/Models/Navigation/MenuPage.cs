using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DreamworldHomepage.Models.Navigation
{
    public class MenuPage
    {
        public string Text { get; set; }
        public Uri Uri { get; set; }

        public MenuPage()
        {
            Text = "Undefined Menu Page";
            Uri = new Uri("www.undefined.com");
        }
    }
}