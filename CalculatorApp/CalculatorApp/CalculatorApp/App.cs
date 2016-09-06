using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using Xamarin.Forms;

namespace CalculatorApp
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            //MainPage = new MainPage();

            var navigationPage = new NavigationPage();

            //var page2 = new Page2();
            //var calStack = new CalculatorStack();
            //var gridExample = new GridExample();
            //var calGrid = new CalculatorGrid();
            //var compEx = new UseCompExample();
            //var bindVTV = new BindViewToView();
            //var bindBW = new BindBackwards();
            //var dateMVVM = new DateMVVM();
            //var clockMVVM = new ClockMVVM();
            //var colorMVVM = new ColorMVVM();
            //var phoneMVVM = new EnterPhoneNoMVVM();
            //var imageEx = new ImageExample();
            //var imageEx2 = new ImageExample2();
            var custComp = new CustomComponentUse();
            var custComp2 = new CustomComponentBinding();

            navigationPage.PushAsync(custComp2);
            MainPage = navigationPage;


            //// Custom Component
            //MainPage = new ContentPage
            //{
            //    Content = new StackLayout
            //    {
            //        BackgroundColor = Color.Purple,
            //        VerticalOptions = LayoutOptions.Center,
            //        Children =
            //        {
            //            new CustomComponent()
            //        }
            //    }
            //};
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
