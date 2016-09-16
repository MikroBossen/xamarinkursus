using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace WeatherDesign
{
    public partial class ProductView : ContentPage
    {
        public ProductView()
        {
            InitializeComponent();

            var proVM = new ProductViewModel();
            var entID = new Entry();
            entID.BindingContext = proVM;
        }

        public void onClickedGetProductBtn()
        {

        }
    }
}
