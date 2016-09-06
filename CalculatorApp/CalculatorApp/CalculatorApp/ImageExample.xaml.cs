using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace CalculatorApp
{
    public partial class ImageExample : ContentPage
    {
        private string first = "iconDog.png";
        private string second = "iconCat.png";

        public ImageExample()
        {
            InitializeComponent();

            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += OnImageTapped;
            petImage.GestureRecognizers.Add(tapGestureRecognizer);
        }

        void OnImageTapped(object sender, EventArgs args)
        {
            var tmp = ((Image)sender).Source as FileImageSource;
            var name = tmp.File;
            if (name == "iconCat")
            {
                petImage.Source = ImageSource.FromFile("iconDog");
            }
            else
            {
                petImage.Source = ImageSource.FromFile("iconCat");
            }                
        }
    }
}
