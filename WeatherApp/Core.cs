using System;
using System.Threading.Tasks;

namespace WeatherApp
{
    public class Core
    {
        public static async Task<Weather> GetWeather(string city)
        {
            //Sign up for a free API key at http://openweathermap.org/appid
            string key = "50d4d8b59f8c1a0a41360976992f86f1";
            //    string queryString = "http://api.openweathermap.org/data/2.5/weather?zip="+ zipCode + "&appid=" + key;
            string nueva = "http://api.openweathermap.org/data/2.5/weather?q=" + city + "&units=metric&appid=" + key;

            var results = await DataService.getDataFromService(nueva).ConfigureAwait(false);

            if (results["weather"] != null)
            {
                Weather weather = new Weather();
                weather.Title = (string)results["name"];
                weather.Temperature = (string)results["main"]["temp"] + "º";
                weather.Wind = (string)results["wind"]["speed"] + " mph";
                weather.Humidity = (string)results["main"]["humidity"] + " %";
                weather.Visibility = (string)results["weather"][0]["main"];


                double km = Convert.ToDouble(weather.Wind);
               km = km * 3.6;


                if (weather.Visibility.Equals("Clear"))
                {
                    weather.Visibility = "Despejado";

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
            }
            else
            {
                return null;
            }
        }
    }
}