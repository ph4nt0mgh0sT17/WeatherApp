using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Models.API
{
    public class Day : INotifyPropertyChanged
    {
        private string iconPhrase;
        private bool hasPrecipitation;
        private string precipitationType;
        private string precipitationIntensity;

        public string IconPhrase
        {
            get
            {
                return iconPhrase;
            }

            set
            {
                iconPhrase = value;
                NotifyPropertyChanged();
            }
        }

        public bool HasPrecipitation
        {
            get
            {
                return hasPrecipitation;
            }

            set
            {
                hasPrecipitation = value;
                NotifyPropertyChanged();
            }
        }

        public string PrecipitationType
        {
            get
            {
                return precipitationType;
            }

            set
            {
                precipitationType = value;
                NotifyPropertyChanged();
            }
        }

        public string PrecipitationIntensity
        {
            get
            {
                return precipitationIntensity;
            }

            set
            {
                precipitationIntensity = value;
                NotifyPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
