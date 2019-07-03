using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Models.API;

namespace WeatherApp.API
{
    public class ApiEngine
    {
        private HttpClient httpClient;
        private readonly string API_KEY = "coMQ7mzWJsAnfdHxDeD8PtsjMBDTTDU5";
        private readonly string FORECAST_URL = "http://dataservice.accuweather.com/forecasts/v1/daily/5day/{0}";

        public ApiEngine()
        {
            httpClient = new HttpClient();
        }

        public async Task<List<SearchResult>> SearchResult(string queryCity)
        {

        }

        public async Task<WeatherForecast> GetWeatherForecastAsync(SearchResult result)
        {
            return null;
        }
    }
}
