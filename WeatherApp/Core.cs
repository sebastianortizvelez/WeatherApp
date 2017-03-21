using System;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherApp
{
    public class Core
    {
        public static async Task<RootObject> GetWeather(string city)
        {
            //Sign up for a free API key at http://openweathermap.org/appid
            string key = "87e32935e8b06fadde698295899f5dbe";
            string queryString = "http://api.openweathermap.org/data/2.5/weather?q=" + city + "&units=metric&appid=" + key;

            string forecastQuery = "http://api.openweathermap.org/data/2.5/forecast/daily?q="+ city + "units=metric&appid=" + key;
         //   http://api.openweathermap.org/data/2.5/forecast/daily?q=lleida&units=metric&appid=87e32935e8b06fadde698295899f5dbe

            var results = await DataService.GetDataFromService(queryString);


            if (results  != string.Empty)
            {

                RootObject weatherObject = Newtonsoft.Json.JsonConvert.DeserializeObject<RootObject>(results);

                return weatherObject;


            }
            else
            {
                return null;
            }

        }
        public static async Task<RootObject> GetWeather2(string city)
        {
            //Sign up for a free API key at http://openweathermap.org/appid
            string key = "87e32935e8b06fadde698295899f5dbe";
            string queryString = "http://api.openweathermap.org/data/2.5/weather?q=" + city + "&units=metric&appid=" + key;

            string forecastQuery = "http://api.openweathermap.org/data/2.5/forecast/daily?q=" + city + "units=metric&appid=" + key;
            //   http://api.openweathermap.org/data/2.5/forecast/daily?q=lleida&units=metric&appid=87e32935e8b06fadde698295899f5dbe

            var results = await DataService.GetDataFromService(forecastQuery);


            if (results != string.Empty)
            {

                RootObject weatherObject2 = Newtonsoft.Json.JsonConvert.DeserializeObject<RootObject>(results);

                return weatherObject2;


            }
            else
            {
                return null;
            }

        }
    }
}