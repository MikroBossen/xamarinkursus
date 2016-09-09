using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ConverterExample
{
    public partial class MainPage : ContentPage
    {
        private DateTime today = DateTime.Now;
        private DateTime tomorrow = DateTime.Now.AddDays(1);
        private DateTimeDayofweekValueConverter myDayofweekValueConverter = new DateTimeDayofweekValueConverter();
        private DateTimeDanishValueConverter myDateTimeDanishValueConverter = new DateTimeDanishValueConverter();

        public DateTime Today
        {
            get
            {
                return this.today;
            }
            set
            {
                this.today = value;
            }
        }

        public DateTime Tomorrow
        {
            get
            {
                return this.tomorrow;
            }
            set
            {
                this.tomorrow = value;
            }
        }

        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
            myLabelToday.SetBinding(Label.TextProperty, "Today", BindingMode.OneWay, myDayofweekValueConverter);
            myLabelTomorrow.SetBinding(Label.TextProperty, "Tomorrow", BindingMode.OneWay, myDateTimeDanishValueConverter);
        }
    }
}
