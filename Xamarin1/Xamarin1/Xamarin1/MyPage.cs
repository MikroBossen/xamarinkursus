using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace Xamarin1
{
    public class MyPage : ContentPage
    {
        //public MyPage()
        //{
        //    Content = new StackLayout
        //    {
        //        Children = {
        //            new Label { Text = "Hello ContentPage" }
        //        }
        //    };
        //}

        // Constructor:
        public MyPage()
        {
            // Elementer:
            var red = new Label();
            red.Text = "Stop";
            red.BackgroundColor = Color.Red;
            red.FontSize = 20;
            red.TextColor = Color.Black;

            var yellow = new Label();
            //yellow.Text.PadLeft(20);
            yellow.Text = "Slow down";
            yellow.BackgroundColor = Color.Yellow;
            yellow.FontSize = 20;
            yellow.TextColor = Color.Black;
            //yellow.HorizontalOptions = LayoutOptions.CenterAndExpand;
            
            
            var green = new Label();
            green.Text = "Go";
            green.BackgroundColor = Color.Green;
            green.FontSize = 20;
            green.TextColor = Color.Black;

            // Layout:
            Padding = new Thickness(20);

            // Content: (indsæt elementer)
            Content = new StackLayout
            {
                Spacing = 10,
                Children = { red, yellow, green }
            };
        }
    }
}
