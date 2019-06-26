using System;
using System.Collections.Generic;
using System.Text;

namespace MobileGeoCreation.Models
{
    class Coordonne
    {

        public double _latitude { get; set; }
        public double _longitude { get; set; }
        public double ? _altitude { get; set; }

        public Coordonne()
        {

        }

        public Coordonne(double lat, double lon, double? altitude)
        {
            this._latitude = lat;
            this._longitude = lon;
            this._altitude = altitude;
        }
                
    }
}
