using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace WeatherDesign
{
    public class App : Application
    {
        public App()
        {
            var weatherViewModel = new WeatherViewModel();
            var weatherVM = new WeatherView(weatherViewModel);

            var navigationPage = new NavigationPage();
            navigationPage.PushAsync(weatherVM);
            MainPage = navigationPage;

            //MainPage = new TestCC();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
