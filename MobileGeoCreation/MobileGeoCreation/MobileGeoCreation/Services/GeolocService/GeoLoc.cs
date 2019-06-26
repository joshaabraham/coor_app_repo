using MobileGeoCreation.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace MobileGeoCreation.Services.GeolocService
{
    class GeoLoc : IGeoloc
    {

        public void geoloc()
        {

        }

        public async Task GetCoordAsync()
        {
            try
            {

                Coordonne coord;
                Location location =  await Geolocation.GetLastKnownLocationAsync();

                if (location != null)
                {
                    coord = new Coordonne(location.Latitude, location.Longitude, location.Altitude);
                    Console.WriteLine($"Latitude: {coord._latitude}, Longitude: {coord._longitude}, Altitude: {coord._altitude}");
                }
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                // Handle not supported on device exception
            }
            catch (FeatureNotEnabledException fneEx)
            {
                // Handle not enabled on device exception
            }
            catch (PermissionException pEx)
            {
                // Handle permission exception
            }
            catch (Exception ex)
            {
                // Unable to get location
            }
        }
    }
}
