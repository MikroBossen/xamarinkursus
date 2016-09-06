using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Xamarin1
{
    public class App : Application
    {
        // Constructor:
        public App()
        {
            // The root page of your application
            //MainPage = new ContentPage
            //{
            //Content = new StackLayout
            //{
            //    VerticalOptions = LayoutOptions.Center,
            //    Children = {
            //        new Label {
            //            HorizontalTextAlignment = TextAlignment.Center,
            //            Text = "Welcome to Xamarin Forms!"
            //        }
            //    }
            //}

            //Content = new Label
            //{
            //    Text = "Hello, Forms !",
            //    VerticalOptions = LayoutOptions.CenterAndExpand,
            //    HorizontalOptions = LayoutOptions.CenterAndExpand,
            //}

            //Content = new StackLayout
            //{
            //    Padding = new Thickness(20), Spacing = 10,
            //    Children =
            //    {
            //        new Label
            //        {
            //            Text = "Stop",
            //            BackgroundColor = Color.Red,
            //            FontSize = 20
            //        },
            //        new Label
            //        {
            //            Text = "Slow down",
            //            BackgroundColor = Color.Yellow,
            //            FontSize = 20
            //        },
            //        new Label
            //        {
            //            Text = "Go",
            //            BackgroundColor = Color.Green,
            //            FontSize = 20
            //        }
            //    }
            //}
            //};

            // The root page of your application
            MainPage = new MyPage();
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

    //public class StackLayoutExample : ContentPage
    //{
    //    public StackLayoutExample()
    //    {
    //        Padding = new Thickness(20);
    //        var red = new Label
    //        {
    //            Text = "Stop",
    //            BackgroundColor = Color.Red,
    //            FontSize = 20
    //        };
    //        var yellow = new Label
    //        {
    //            Text = "Slow down",
    //            BackgroundColor = Color.Yellow,
    //            FontSize = 20
    //        };
    //        var green = new Label
    //        {
    //            Text = "Go",
    //            BackgroundColor = Color.Green,
    //            FontSize = 20
    //        };

    //        Content = new StackLayout
    //        {
    //            Spacing = 10,
    //            Children = { red, yellow, green }
    //        };
    //    }
    //}
}
