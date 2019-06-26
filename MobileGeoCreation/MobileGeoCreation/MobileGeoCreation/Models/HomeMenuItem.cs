using System;
using System.Collections.Generic;
using System.Text;

namespace MobileGeoCreation.Models
{
    public enum MenuItemType
    {
        CreationCroisement,
        CreationVoie,
        Browse,
        About
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
