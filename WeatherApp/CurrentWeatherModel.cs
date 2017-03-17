using System;
using System.Linq;
namespace WeatherApp
{


    public class CurrentWeatherModel
    {
        public string Title { get; set; }
        public String Temperature { get; set; }
        public String Temp_min { get; set; }
        public String Temp_max { get; set; }
        public String Wind { get; set; }
        public double Humidity { get; set; }
        public double Rain { get; set; }
        public string Visibility { get; set; }
        public DateTime Sunrise { get; set; }
        public DateTime Sunset { get; set; }
        public string Country { get; set; }
        public string Foto { get; set; }

        public CurrentWeatherModel(RootObject weatherRootObject)
        {
            Title = weatherRootObject.name;
            Temperature =  weatherRootObject.main.temp.ToString();
            Temp_min = weatherRootObject.main.temp_min.ToString();
            Temp_max = weatherRootObject.main.temp_max.ToString();
            Wind = weatherRootObject.wind.speed.ToString();
            Humidity = weatherRootObject.main.humidity;
            Rain = weatherRootObject.rain == null ? 0 : weatherRootObject.rain.__invalid_name__3h;
            DateTime time = new System.DateTime(1970, 1, 1, 1, 0, 0, 0);
            Sunrise = time.AddSeconds(weatherRootObject.sys.sunrise);
            Sunset = time.AddSeconds(weatherRootObject.sys.sunset);
            Country = weatherRootObject.sys.country;


  
            Weather w = weatherRootObject.weather.FirstOrDefault();
            if (w != null)
            {
                Visibility = w.main;
            }

            if (Visibility.Equals("Clear")) {

                Visibility = "Despejado";
                Foto = "sunny.png";

            }
            else if (Visibility.Equals("Clouds"))
            {
                Visibility = "Con nubes";
                Foto = "cloudblack.png";

            }

            else if (Visibility.Equals("Rain"))
            {

                Visibility = "Lluvia";
                Foto = "lluvias.png";

            }

                else if (Visibility.Equals("Drizzle"))
            {
               Visibility = "Con llovizna";
                Foto = "lluvias.png";

            }

            Temperature += "º";
            Temp_min += "º";
            Temp_max += "º";
            Wind += " Km/h";
    


        }
    }
}