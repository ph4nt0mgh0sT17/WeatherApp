using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.API;
using WeatherApp.Models.API;

namespace WeatherApp.ViewModels
{
    public class MainWindowViewModel
    {
        private ApiEngine apiEngine;
        public MainWindowViewModel()
        {
            apiEngine = new ApiEngine();
            GetCities("Vratimov");
        }

        private async void GetCities(string queryCity)
        {
            List<SearchResult> cities = await apiEngine.SearchResult(queryCity);
            WeatherForecast forecast = await apiEngine.GetWeatherForecastAsync(cities[0]);
        }
    }
}
