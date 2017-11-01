using DreamworldHomepage.Models;
using DreamworldHomepage.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DreamworldHomepage.TestData
{
    public static class TestData
    {
        public static HomepageViewModel GetData()
        {
            HomepageViewModel result = new HomepageViewModel();

            var menu = new List<MenuItem>();
            menu.Add(new MenuItem() {
                Text = "Park Info",
                Sections = new List<MenuSection>()
                {

                }                
            });
            menu.Add(new MenuItem() { Text = "Rides" });
            menu.Add(new MenuItem() { Text = "Attractions" });
            menu.Add(new MenuItem() { Text = "Group Events" });
            menu.Add(new MenuItem() { Text = "Food And Shopping" });
            menu.Add(new MenuItem() { Text = "Schools" });
            result.Navigation.MenuItems = menu;            
            return result;
        }
    }
}