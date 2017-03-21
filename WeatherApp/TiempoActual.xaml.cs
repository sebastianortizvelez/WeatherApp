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
                RootObject weatherObject2 = await Core.GetWeather2(cityEntry.Text);

                if (weatherObject != null)
                {
                    cityEntry.Text = "";
            
                    this.BindingContext = new CurrentWeatherModel(weatherObject);
             

                }
            }
        }
    }

}