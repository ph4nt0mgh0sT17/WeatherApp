using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Models.API;
using Newtonsoft.Json;

namespace WeatherApp.API
{
    public class ApiEngine
    {
        private HttpClient httpClient;
        private readonly string API_KEY = "coMQ7mzWJsAnfdHxDeD8PtsjMBDTTDU5";
        private readonly string FORECAST_URL = "http://dataservice.accuweather.com/forecasts/v1/daily/5day/{0}?apikey={1}&metric=true";
        private readonly string AUTOCOMPLETE_URL = "http://dataservice.accuweather.com/locations/v1/cities/autocomplete?apikey={0}&q={1}";

        public ApiEngine()
        {
            httpClient = new HttpClient();
        }

        public async Task<List<SearchResult>> SearchResult(string queryCity)
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, String.Format(AUTOCOMPLETE_URL,API_KEY, queryCity));

            HttpResponseMessage response = await httpClient.SendAsync(request);

            string json = await response.Content.ReadAsStringAsync();

            List<SearchResult> results = JsonConvert.DeserializeObject<List<SearchResult>>(json);

            return results;
        }

        public async Task<WeatherForecast> GetWeatherForecastAsync(SearchResult result)
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, String.Format(FORECAST_URL, result.Key, API_KEY));

            HttpResponseMessage response = await httpClient.SendAsync(request);

            string json = await response.Content.ReadAsStringAsync();

            WeatherForecast forecast = JsonConvert.DeserializeObject<WeatherForecast>(json);

            return forecast;
        }
    }
}
