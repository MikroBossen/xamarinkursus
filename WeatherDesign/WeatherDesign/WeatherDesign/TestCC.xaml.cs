using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace WeatherDesign
{
    public partial class TestCC : ContentPage
    {
        public TestCC()
        {
            InitializeComponent();
            Weather3HoursCC useComponent1 = new Weather3HoursCC();
            myLayout.Children.Add(useComponent1);
        }
    }
}
