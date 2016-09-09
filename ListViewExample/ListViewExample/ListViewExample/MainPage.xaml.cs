using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ListViewExample
{
    public partial class MainPage : ContentPage
    {
        private IPersonViewModel personViewModel;

        public MainPage(IPersonViewModel personViewModel)
        {
            this.personViewModel = personViewModel;

            InitializeComponent();

            myPersonListView.ItemsSource = personViewModel.AllPersons;

            BindingContext = personViewModel;

            var newViewDataTemplate = new DataTemplate(typeof(PersonView));
            newViewDataTemplate.SetBinding(PersonView.FirstNameProperty, "FirstName");
            newViewDataTemplate.SetBinding(PersonView.LastNameProperty, "LastName");
            newViewDataTemplate.SetBinding(PersonView.ImagePathProperty, "ImagePath");
            myPersonListView.ItemTemplate = newViewDataTemplate;
        }
    }
}
