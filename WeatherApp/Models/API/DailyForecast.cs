using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Models.API
{
    public class DailyForecast : INotifyPropertyChanged
    {
        private DateTime date;
        private Temperature temperature;
        private Day day;
        private Night night;

        public DateTime Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
                NotifyPropertyChanged("Date");
            }
        }
        public Temperature Temperature
        {
            get
            {
                return temperature;
            }

            set
            {
                temperature = value;
                NotifyPropertyChanged("Temperature");
            }
        }

        public Day Day
        {
            get
            {
                return day;
            }

            set
            {
                day = value;
                NotifyPropertyChanged("Day");
            }
        }

        public Night Night
        {
            get
            {
                return night;
            }

            set
            {
                night = value;
                NotifyPropertyChanged("Night");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
