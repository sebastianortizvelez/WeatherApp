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

            getWeatherBtn.Clicked += GetWeatherBtn_Clicked;

            //Set the default binding to a default object for now
            this.BindingContext = new Weather();
        }


        private async void GetWeatherBtn_Clicked(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(zipCodeEntry.Text))
            {
                Weather weather = await Core.GetWeather(zipCodeEntry.Text);
                if (weather != null)
                {

                    zipCodeEntry.Text = "";
                    this.BindingContext = weather;
                    getWeatherBtn.Text = "Nueva busqueda";
                }
            }
        }
    }
}
