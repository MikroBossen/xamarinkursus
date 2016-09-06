using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace Xamarin2
{
    public class CP : ContentPage
    {
        public CP()
        {
            var startBtn = new Button();
            startBtn.Text = "Den vigtige knap";
            startBtn.TextColor = Color.Olive;
            startBtn.FontAttributes = FontAttributes.Bold;
            startBtn.Text.ToUpper();
            startBtn.BorderColor = Color.Black;
            startBtn.BorderWidth = 5;
            startBtn.BackgroundColor = Color.Blue;
            startBtn.VerticalOptions = LayoutOptions.Start;

            var red = new Label();
            red.Text = "Red label";
            red.BackgroundColor = Color.Red;
            red.TextColor = Color.Black;
            red.VerticalOptions = LayoutOptions.EndAndExpand;

            var yellow = new Label();
            yellow.Text = "Yellow label";
            yellow.TextColor = Color.Black;
            yellow.BackgroundColor = Color.Yellow;

            var green = new Label();
            green.Text = "Green label";
            green.TextColor = Color.Black;
            green.BackgroundColor = Color.Green;

            Content = new StackLayout
            {
                Padding = 10,
                Children =
                {
                    startBtn, red, yellow, green
                }
            };
        }
    }
}
