using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace WeatherApp
{
    public partial class Pronostico : ContentPage
    {
        public Pronostico()
        {
            InitializeComponent();
   listView.ItemsSource = Data.WeatherList;
        }
    }
}
