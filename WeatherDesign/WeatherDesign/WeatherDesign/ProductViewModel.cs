using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WeatherDesign
{
    public class ProductViewModel : INotifyPropertyChanged
    {
        private int id;
        private string name;
        private string category;
        private decimal price;

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }

        public int Id
        {
            get { return this.id; }
            set
            {
                if (value != this.id)
                {
                    this.id = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value != this.name)
                {
                    this.name = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string Category
        {
            get { return this.category; }
            set
            {
                if (value != this.category)
                {
                    this.category = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value != this.price)
                {
                    this.price = value;
                    NotifyPropertyChanged();
                }
            }
        }
    }
}
