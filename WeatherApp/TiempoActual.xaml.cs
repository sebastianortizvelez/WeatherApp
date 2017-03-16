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
                  
                    this.BindingContext = new CurrentWeatherModel(weatherObject);

                }
            }
        }
    }

}