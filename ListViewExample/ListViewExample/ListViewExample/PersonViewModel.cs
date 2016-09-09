using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViewExample
{
    public class PersonViewModel : IPersonViewModel
    {
        private List<Person> personList = new List<Person>();

        public PersonViewModel()
        {
            personList.Add(new Person("Wing", "Wong", "iconasian.png"));
            personList.Add(new Person("Andreas", "Mogensen", "iconastronaut.png"));
            personList.Add(new Person("Sweedish", "Cook", "iconchef.png"));
            personList.Add(new Person("Pennywise", "The Clown", "iconclown.png"));
            personList.Add(new Person("Elvis", "Presliy", "iconelvis.png"));
            personList.Add(new Person("General", "Custer", "icongeneral.png"));
            personList.Add(new Person("Sherlock", "Holmes", "iconholmes.png"));
            personList.Add(new Person("Marilyn", "Monroe", "iconmonroe.png"));
            personList.Add(new Person("Harry", "Potter", "iconpotter.png"));
            personList.Add(new Person("Fader", "Thomas", "iconpriest.png"));
            personList.Add(new Person("Verka", "Serduchka", "iconserduchka.png"));
            personList.Add(new Person("Arnold", "Schwarzenegger", "iconterminator.png"));
        }

        public List<Person> AllPersons
        {
            get
            {
                return personList;
            }
        }
    }
}
