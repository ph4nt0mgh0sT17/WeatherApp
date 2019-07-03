using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Models.API
{
    public class WeatherForecast : INotifyPropertyChanged
    {
        private Headline headline;
        private List<DailyForecast> dailyForecasts;
        public Headline Headline
        {
            get
            {
                return headline;
            }

            set
            {
                headline = value;
                NotifyPropertyChanged();
            }
        }
        public List<DailyForecast> DailyForecasts
        {
            get
            {
                return dailyForecasts;
            }

            set
            {
                dailyForecasts = value;
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
