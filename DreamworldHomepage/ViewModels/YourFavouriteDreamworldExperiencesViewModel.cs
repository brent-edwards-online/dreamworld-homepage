using DreamworldHomepage.Content.images.YourFavouriteDreamworldExperiences;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DreamworldHomepage.ViewModels
{
    public class YourFavouriteDreamworldExperiencesViewModel
    {
        public string Title { get; set; }

        public FavouriteDreamWorldExperienceItem Large0 { get; set; }
        public FavouriteDreamWorldExperienceItem Large1 { get; set; }

        public FavouriteDreamWorldExperienceItem Medium0 { get; set; }
        public FavouriteDreamWorldExperienceItem Medium1 { get; set; }

        public FavouriteDreamWorldExperienceItem Small0 { get; set; }
        public FavouriteDreamWorldExperienceItem Small1 { get; set; }
        public FavouriteDreamWorldExperienceItem Small2 { get; set; }
        public FavouriteDreamWorldExperienceItem Small3 { get; set; }
        public FavouriteDreamWorldExperienceItem Small4 { get; set; }

    }
}