using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherDesign
{
    public class WeatherViewModel : INotifyPropertyChanged
    {
        private DateTime today = DateTime.Now;
        private string city = "Emdrup";
        private string altitude = "520 meter";

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

        public string City
        {
            get
            {
                return this.city;
            }
            set
            {
                this.city = value;
            }
        }

        public string Altitude
        {
            get
            {
                return this.altitude;
            }
            set
            {
                this.altitude = value;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }



    //public class WeatherViewModel
    //{

    //}
}
