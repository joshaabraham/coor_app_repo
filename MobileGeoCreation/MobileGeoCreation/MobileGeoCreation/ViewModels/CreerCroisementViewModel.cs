using MobileGeoCreation.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MobileGeoCreation.ViewModels
{
    class CreerCroisementViewModel : BaseViewModel, INotifyPropertyChanged
    {
        double _latitude, _longitude;
        double ?_altitude;
        Coordonne coordonnee =new Coordonne(123.321,321.123,45);

        public event PropertyChangedEventHandler PropertyChanged;


        public CreerCroisementViewModel()
        {
            this.coordonnee._latitude = 123.321;
            this.coordonnee._longitude = 321.123;
        }

        public double Longitude
        {
            set
            {
                if (_longitude != value)
                {
                    _longitude = value;
                    OnPropertyChanged("Longitude");
                    SetNewCoordonne();
                }
            }
            get
            {
                return _longitude;
            }
        }

        public double Latitude
        {
            set
            {
                if (_latitude != value)
                {
                    _latitude = value;
                    OnPropertyChanged("Latitude");
                    SetNewCoordonne();
                }
            }
            get
            {
                return _latitude;
            }
        }

        public double? Altitude
        {
            set
            {
                if (_altitude != value)
                {
                    _altitude = value;
                    OnPropertyChanged("Altitude");
                    SetNewCoordonne();
                }
            }
            get
            {
                return _altitude;
            }
        }

        void SetNewCoordonne()
        {
            coordonnee = new Coordonne(_latitude, _longitude, Altitude);
        }

        public Coordonne Coordonnee
        {
            set
            {
                if (coordonnee != value)
                {
                    coordonnee = value;
                    OnPropertyChanged("Coordonne");
                    Altitude = value._altitude;
                    Latitude = value._latitude;
                    Longitude = value._longitude;
                }
            }
            get
            {
                return coordonnee;
            }
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
