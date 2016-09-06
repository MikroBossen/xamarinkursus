using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace CalculatorApp
{
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
            
        }

        public async void OnGotoCalStack(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new CalculatorStack());
        }

        public async void OnGotoGridEx(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new GridExample());
        }

        public async void OnGotoCalGrid(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new CalculatorGrid());
        }
    }
}
