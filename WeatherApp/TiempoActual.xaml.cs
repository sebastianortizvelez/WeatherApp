using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace WeatherApp
{
    public partial class TiempoActual : ContentPage
    {
        public TiempoActual()
        {
            InitializeComponent();


        }


        async void Handle_Clicked(object sender, System.EventArgs e)
        {

            if (!String.IsNullOrEmpty(cityEntry.Text))
            {

             
                RootObject weatherObject = await Core.GetWeather(cityEntry.Text);
                if (weatherObject != null)
                {
                    cityEntry.Text = "";
            
                    this.BindingContext = new CurrentWeatherModel(weatherObject);
               /*    
                    if (visibilityLabel.Text.Equals("Clear"))
                    {

                        visibilityLabel.Text = "Despejado";
                        estado.Source = "cloudwhite.png";

                    }

                    else if (visibilityLabel.Text.Equals("Rain"))
                    {

                        visibilityLabel.Text = "Lluvias";
                        estado.Source = "rain.png";

                    }

*/
                }
            }
        }
    }

}