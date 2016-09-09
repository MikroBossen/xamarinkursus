using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViewExample
{
    public class Person
    {
        private string PersonFirstName;
        private string PersonLastName;
        private string PersonImagePath;

        public Person(string FirstName, string LastName, string ImagePath)
        {
            this.PersonFirstName = FirstName;
            this.PersonLastName = LastName;
            this.PersonImagePath = ImagePath;
        }

        public string FirstName
        {
            get
            {
                return this.PersonFirstName;
            }

            set
            {
                this.PersonFirstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.PersonLastName;
            }

            set
            {
                this.PersonLastName = value;
            }
        }

        public string ImagePath
        {
            get
            {
                return this.PersonImagePath;
            }
            set
            {
                this.PersonImagePath = value;
            }
        }
    }
}
