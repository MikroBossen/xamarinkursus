using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListViewExample2
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

            // DataTemplate benyttes, når man ikke kender det præcise antal elementer
            var newViewDataTemplate = new DataTemplate(typeof(PersonView));
            newViewDataTemplate.SetBinding(PersonView.FirstNameProperty, "FirstName");
            newViewDataTemplate.SetBinding(PersonView.LastNameProperty, "LastName");
            newViewDataTemplate.SetBinding(PersonView.ImagePathProperty, "ImagePath");
            myPersonListView.ItemTemplate = newViewDataTemplate;
        }
    }
}
