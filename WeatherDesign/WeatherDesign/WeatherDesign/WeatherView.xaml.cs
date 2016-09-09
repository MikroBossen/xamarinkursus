using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace WeatherDesign
{
    public partial class WeatherView : ContentPage
    {
        WeatherViewModel weatherViewModel;
        Color myColor1 = Color.FromRgba(255, 255, 255, 0.2); //new Color(255, 255, 255, 80);
        Color myColor2 = Color.FromRgba(255, 255, 255, 0.3);

        //private DateTime today = DateTime.Now;
        private DateTimeDanishValueConverter myDateTimeDanishValueConverter = new DateTimeDanishValueConverter();

       //public DateTime Today
        //{
        //    get
        //    {
        //        return this.today;
        //    }
        //    set
        //    {
        //        this.today = value;
        //    }
        //}


        public WeatherView(WeatherViewModel weatherViewModel)
        {
            this.weatherViewModel = weatherViewModel;
            BindingContext = weatherViewModel;

            InitializeComponent();

            Weather3HoursCC treeHoursCC1 = new Weather3HoursCC();
            treeHoursCC1.BackgroundColor = this.myColor1;
            FirstlodCC.Children.Add(treeHoursCC1);

            Weather3HoursCC treeHoursCC2 = new Weather3HoursCC();
            treeHoursCC2.BackgroundColor = this.myColor1;
            SecondlodCC.Children.Add(treeHoursCC2);

            Weather3HoursCC treeHoursCC3 = new Weather3HoursCC();
            treeHoursCC3.BackgroundColor = this.myColor1;
            ThirdlodCC.Children.Add(treeHoursCC3);

            Weather3HoursCC treeHoursCC4 = new Weather3HoursCC();
            treeHoursCC4.BackgroundColor = this.myColor1;
            FourthlodCC.Children.Add(treeHoursCC4);

            //udskiftTilForsteLodretteCustomComponent.BackgroundColor = this.myColor1;
            //udskiftTilAndenLodretteCustomComponent.BackgroundColor = this.myColor1;
            //udskiftTilTredjeLodretteCustomComponent.BackgroundColor = this.myColor1;
            //udskiftTilFjerdeLodretteCustomComponent.BackgroundColor = this.myColor1;

            udskiftTilForsteKvadratCustomComponent.BackgroundColor = this.myColor2;
            udskiftTilTredjeKvadratCustomComponent.BackgroundColor = this.myColor2;

            cityNameLbl.SetBinding(Label.TextProperty, "City", BindingMode.OneWay);
            cityAltitudeLbl.SetBinding(Label.TextProperty, "Altitude", BindingMode.OneWay);
            dayLbl.SetBinding(Label.TextProperty, "Today", BindingMode.OneWay, myDateTimeDanishValueConverter);
        }
    }
}
