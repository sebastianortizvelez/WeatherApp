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



                /*
                 * 
                 * 
                 * 
                Weather weather = new Weather();
                weather.Title = (string)results["name"];
                weather.Temperature = (string)results["main"]["temp"] + "º";
                weather.Wind = (string)results["wind"]["speed"] + " mph";
                weather.Humidity = (string)results["main"]["humidity"] + " %";
                weather.Visibility = (string)results["weather"][0]["main"];


               

                if (weather.Visibility.Equals("Clear"))
                {
                    weather.Visibility = "Despejadosss";

                }

                else if (weather.Visibility.Equals("Clouds"))
                {
                    weather.Visibility = "Con nubes";

                }

                else if (weather.Visibility.Equals("Rain"))
                {
                    weather.Visibility = "Con lluvias";

                }

                else if (weather.Visibility.Equals("Drizzle"))
                {
                    weather.Visibility = "Con llovizna";

                }


                DateTime time = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
                DateTime sunrise = time.AddSeconds((double)results["sys"]["sunrise"]);
                DateTime sunset = time.AddSeconds((double)results["sys"]["sunset"]);
                weather.Sunrise = sunrise.ToString() + " UTC";
                weather.Sunset = sunset.ToString() + " UTC";
                return weather;

                */



                return weatherObject;


            }
            else
            {
                return null;
            }
        }
    }
}