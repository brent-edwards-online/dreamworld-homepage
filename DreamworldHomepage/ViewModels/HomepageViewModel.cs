using DreamworldHomepage.Models.Pricing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DreamworldHomepage.ViewModels
{
    public class HomepageViewModel
    {
        public HomepageViewModel()
        {
            Navigation = new NavigationViewModel();
            Banner = new BannerViewModel();
            ParkPricing = new TicketOffice();
            HelpMeFindTherightTicket = ParkPricing;
        }

        public NavigationViewModel Navigation { get; set; }

        public BannerViewModel Banner { get; set; }

        public string ParkInformation { get; set; }

        public TicketOffice ParkPricing { get; set; }

        public string  WhatsGoingOn { get; set; }

        public string YourFavouriteExperiences { get; set; }

        public string ParkUpdates { get; set; }

        public TicketOffice HelpMeFindTherightTicket { get; set; }

        public string LiveAtDreamworld { get; set; }

        public string SignUpforSpecialOffers { get; set; }

        public string Footer { get; set; }
    }
}