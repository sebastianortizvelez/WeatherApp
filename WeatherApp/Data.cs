using System;

using Xamarin.Forms;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace WeatherApp
{
    public class Weather
    {
        
        public int dia { get; set; }
        public int temperatura { get; set; }
        public String foto { get; set; }


        public string Title { get; set; }
        public string Temperature { get; set; }
        public string Wind { get; set; }
        public string Humidity { get; set; }
        public string Visibility { get; set; }
        public string Sunrise { get; set; }
        public string Sunset { get; set; }


        public Weather()
        {
            //Because labels bind to these values, set them to an empty string to
            //ensure that the label appears on all platforms by default.
            this.Title = " ";
            this.Temperature = " ";
            this.Wind = " ";
            this.Humidity = " ";
            this.Visibility = " ";
            this.Sunrise = " ";
            this.Sunset = " ";
        }
    }


    public class Data
    {


        #region WeatherList
        public static ObservableCollection<Weather> WeatherList = new ObservableCollection<Weather>
        {

            new Weather { dia = 20, temperatura = 35,foto = "lluvias.png"},
                  new Weather { dia = 21, temperatura = 9, foto = "soleado.png"},
                  new Weather { dia = 22, temperatura = 13,foto = "lluvias.png"},
            new Weather {dia = 23,temperatura = 30, foto = "cloudblack.png"},
                    new Weather { dia = 24, temperatura = 32,foto = "soleado.png"},
                  new Weather { dia = 25, temperatura = 30, foto = "cloudwhite.png"},
                  new Weather { dia = 26, temperatura = 31,foto = "lluvias.png"},
            new Weather {dia = 27,temperatura = 29, foto = "cloudblack.png"}

        };
#endregion


    }


}

