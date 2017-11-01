using DreamworldHomepage.Models;
using DreamworldHomepage.Models.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DreamworldHomepage.ViewModels
{
    public class NavigationViewModel
    {
        public IEnumerable<MenuItem> MenuItems { get; set; }

        public NavigationViewModel()
        {
            MenuItems = new List<MenuItem>();
        }
    }
}