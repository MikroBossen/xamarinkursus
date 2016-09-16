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
        private int idPVM;
        private string namePVM;
        private string categoryPVM;
        private decimal pricePVM;

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
            get { return this.idPVM; }
            set
            {
                if (value != this.idPVM)
                {
                    this.idPVM = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string Name
        {
            get { return this.namePVM; }
            set
            {
                if (value != this.namePVM)
                {
                    this.namePVM = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string Category
        {
            get { return this.categoryPVM; }
            set
            {
                if (value != this.categoryPVM)
                {
                    this.categoryPVM = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public decimal Price
        {
            get { return this.pricePVM; }
            set
            {
                if (value != this.pricePVM)
                {
                    this.pricePVM = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public async void LoadProductAsync(int id)
        {
            var proSC = new ProductServiceClient();
            Product prod = await proSC.GetProduct(id);
            Id = prod.Id;
            Name = prod.Name;
            Category = prod.Category;
            Price = prod.Price;
        }
    }
}
