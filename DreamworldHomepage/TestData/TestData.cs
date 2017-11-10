using DreamworldHomepage.Content.images.YourFavouriteDreamworldExperiences;
using DreamworldHomepage.Models;
using DreamworldHomepage.Models.Navigation;
using DreamworldHomepage.Models.ParkUpdate;
using DreamworldHomepage.Models.WhatsGoingOn;
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

            // ***** NAVIGATION
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

            // ***** BANNER
            result.Banner.Title = "LET YOUR IMAGINATION PLAY";
            result.Banner.ButtonText = "Learn More";
            result.Banner.Image = "/Content/images/Banner/Homepage_head-banner_desktop.jpg";
            result.Banner.MobilelImage = "/Content/images/Banner/Homepage_head-banner_mobile.jpg";

            // ***** PARK INFO

            // ***** PARK PRICING

            // ***** WHATS GOING ON
            var whatsgoingon = new List<WhatsGoingOnItem>();
            result.WhatsGoingOn.Title = "What's going on";
            whatsgoingon.Add(new WhatsGoingOnItem()
            {
                Title = "Great white lions are here",
                DateText = "JUNE 27 - JULY 13",
                Image = "/Content/images/WhatsGoingOn/carousel_whats-on_1.jpg",
                Color = "grey"
            });
            whatsgoingon.Add(new WhatsGoingOnItem()
            {
                Title = "Park Afterdark: Extremeworld",
                DateText = "JULY 29, 6.30PM TO 10PM",
                Image = "/Content/images/WhatsGoingOn/carousel_whats-on_2.jpg",
                Color = "pink"
            });
            whatsgoingon.Add(new WhatsGoingOnItem()
            {
                Title = "Enter the Flowrider Competition",
                DateText = "JULY 17 - AUGUST 07",
                Image = "/Content/images/WhatsGoingOn/carousel_whats-on_3.jpg",
                Color = "blue"
            });
            whatsgoingon.Add(new WhatsGoingOnItem()
            {
                Title = "The Wiggles Live @Dreamworld",
                DateText = "JUNE 20",
                Image = "/Content/images/WhatsGoingOn/carousel_whats-on_4.jpg",
                Color = "purple"
            });
            whatsgoingon.Add(new WhatsGoingOnItem()
            {
                Title = "Enter the Flowrider Competition",
                DateText = "JULY 17 - AUGUST 07",
                Image = "/Content/images/WhatsGoingOn/carousel_whats-on_3.jpg",
                Color = "black"
            });
            whatsgoingon.Add(new WhatsGoingOnItem()
            {
                Title = "The Wiggles Live @Dreamworld",
                DateText = "JUNE 20",
                Image = "/Content/images/WhatsGoingOn/carousel_whats-on_4.jpg",
                Color = "orange"
            });
            result.WhatsGoingOn.Items = whatsgoingon;

            // ***** YOUR FAVOURITE DREAMWORLD EXPERIENCES
            result.YourFavouriteDreamworldExperiences = new YourFavouriteDreamworldExperiencesViewModel();
            result.YourFavouriteDreamworldExperiences.Title = @"Your <strong>Favourite</strong> Dreamworld Experiences";
            result.YourFavouriteDreamworldExperiences.Large0 = new FavouriteDreamWorldExperienceItem()
            {
                Image = "/Content/images/YourFavouriteDreamworldExperiences/large-0.jpg",
                Title = "TIGER ISLAND",
                Size = "L"
            };

            result.YourFavouriteDreamworldExperiences.Large1 = new FavouriteDreamWorldExperienceItem()
            {
                Image = "/Content/images/YourFavouriteDreamworldExperiences/large-1.jpg",
                Title = "THE CLAW",
                Size = "L"
            };

            result.YourFavouriteDreamworldExperiences.Medium0 = new FavouriteDreamWorldExperienceItem()
            {
                Image = "/Content/images/YourFavouriteDreamworldExperiences/med-0.jpg",
                Title = "LEGO CERTIFIED STORE",
                Size = "M"
            };

            result.YourFavouriteDreamworldExperiences.Medium1 = new FavouriteDreamWorldExperienceItem()
            {
                Image = "/Content/images/YourFavouriteDreamworldExperiences/med-1.jpg",
                Title = "This is the title",
                Size = "M"
            };
            result.YourFavouriteDreamworldExperiences.Small0 = new FavouriteDreamWorldExperienceItem()
            {
                Image = "/Content/images/YourFavouriteDreamworldExperiences/small-0.jpg",
                Title = "WHITE WATER WORLD",
                Size = "S"
            };
            result.YourFavouriteDreamworldExperiences.Small1 = new FavouriteDreamWorldExperienceItem()
            {
                Image = "/Content/images/YourFavouriteDreamworldExperiences/small-1.jpg",
                Title = "WIGGLES WORLD",
                Size = "S"
            };
            result.YourFavouriteDreamworldExperiences.Small2 = new FavouriteDreamWorldExperienceItem()
            {
                Image = "/Content/images/YourFavouriteDreamworldExperiences/small-2.jpg",
                Title = "FAMILY RIDES",
                Size = "S"
            };
            result.YourFavouriteDreamworldExperiences.Small3 = new FavouriteDreamWorldExperienceItem()
            {
                Image = "/Content/images/YourFavouriteDreamworldExperiences/small-3.jpg",
                Title = "KIDS RIDES",
                Size = "S"
            };

            result.YourFavouriteDreamworldExperiences.Small4 = new FavouriteDreamWorldExperienceItem()
            {
                Image = "/Content/images/YourFavouriteDreamworldExperiences/small-4.jpg",
                Title = "SHOWS",
                Size = "S"
            };

            

            // ***** PARK UPDATES
            result.ParkUpdates = new ParkUpdatesViewModel();
            var updates = new List<ParkUpdateItem>();
            updates.Add(new ParkUpdateItem()
            {
                Title = "Park update",
                Datetext = "24th October 2017",
                Description = "The Claw will be closed this Thursday 27th October between 10am-11am for routine maintenance."
            });
            updates.Add(new ParkUpdateItem()
            {
                Title = "Park update",
                Datetext = "1st November 2017",
                Description = "The Puss In Boots Sword Swing will be closed from 18 to 26 November for routine maintenance."
            });
            updates.Add(new ParkUpdateItem()
            {
                Title = "Park update",
                Datetext = "2nd November 2017",
                Description = "Tiger Island closed 8th November and 12 November."
            });
            updates.Add(new ParkUpdateItem()
            {
                Title = "Park update",
                Datetext = "5nd November 2017",
                Description = "Main street under repair Christmas Eve 2017."
            });
            result.ParkUpdates.Items = updates;

            // ***** HELP ME FIND THE RIGHT TICKET



            return result;
        }
    }
}