using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalculatorApp
{
    public partial class CustomComponentBinding : ContentPage
    {
        public CustomComponentBinding()
        {
            InitializeComponent();

            CustomComponent custComp1 = new CustomComponent();
            CustomComponent custComp2 = new CustomComponent();
            CustomComponent custComp3 = new CustomComponent();

            myLayout.Children.Add(custComp1);
            myLayout.Children.Add(custComp2);
            myLayout.Children.Add(custComp3);

            custComp1.FirstName = "Anton";
            custComp1.LastName = "Bjerg";

            custComp2.FirstName = "Per";
            custComp2.LastName = "Neele";

            custComp3.FirstName = "Otto";
            custComp3.LastName = "Næs Horn";
        }
    }
}
