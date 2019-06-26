using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace MobileGeoCreation.Services.GeolocService
{
    interface IGeoloc
    {
         Task GetCoordAsync();
    }
}
