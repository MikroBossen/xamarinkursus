using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToCSharp
{
    // enums
    public enum AnimalType { Bird, Fish }

    // delegates
    public delegate bool Filter(Person person);


    // classes
    public class Species
    {
        // fields
        private string SpeciesName;
        private string SpeciesNameSpecific;
        private int SpeciesAmountLegs;
        private int SpeciesAmountEyes;
        // use of enum
        private readonly AnimalType SpeciesAnimalType = AnimalType.Fish;

        // properties
        public string Name
        {
            get
            {
                return this.SpeciesName;
            }
            private set{ }
        }

        public string NameSpecific
        {
            get
            {
                return this.SpeciesNameSpecific;
            }
            private set{ }
        }

        public int AmountLegs
        {
            get
            {
                return this.SpeciesAmountLegs;
            }
            private set{ }
        }

        public int AmountEyes
        {
            get
            {
                return this.SpeciesAmountEyes;
            }
            private set{ }
        }

        public AnimalType AnimalType
        {
            get
            {
                return this.SpeciesAnimalType;
            }
            private set { }
        }

        // constructor
        public Species(string Name, string NameSpecific, int AmountLegs, int AmountEyes, AnimalType AnimalType)
        {
            this.SpeciesName = Name;
            this.SpeciesNameSpecific = NameSpecific;
            this.SpeciesAmountLegs = AmountLegs;
            this.SpeciesAmountEyes = AmountEyes;
            this.SpeciesAnimalType = AnimalType;
        }

        public Species(string Name, int AmountEyes, int AmountLegs, AnimalType AnimalType)
        {
            this.SpeciesName = Name;
            this.SpeciesAmountLegs = AmountLegs;
            this.SpeciesAmountEyes = AmountEyes;
            this.SpeciesAnimalType = AnimalType;
        }

        public Species(string Name, AnimalType AnimalType)
        {
            this.SpeciesName = Name;
            this.SpeciesAnimalType = AnimalType;
        }

        // methods
        public string getName()
        {
            return this.SpeciesName;
        }

        public string getNameSpecific()
        {
            return this.SpeciesNameSpecific;
        }

        // use of enum
        public string Talk()
        {
            if (this.SpeciesAnimalType == AnimalType.Fish)
            {
                return "pip pip";
            }
            else
            {
                return "...";
            }
        }
    }


    public class Pet
    {
        private string PetName;
        private Species PetSpecies;

        public string Name
        {
            get
            {
                return this.PetName;
            }
            private set{ }
        }

        public Species Species
        {
            get
            {
                return this.PetSpecies;
            }
            private set{ }
        }

        public Pet(string Name, Species Species)
        {
            this.PetName = Name;
            this.PetSpecies = Species;
        }


        public string getName()
        {
            return this.PetName;
        }
    }


    public enum PGender { Male, Female }

    public class Person : INotifyPropertyChanged
    {
        private string PersonName;
        private int PersonBirthYear;
        //private string PersonGender;
        private Pet PersonPet;
        private PGender PersonGender = PGender.Male;

        // properties
        public string Name
        {
            get
            {
                return this.PersonName;
            }
            set
            {
                this.PersonName = value;
                OnNameChanged();
                OnPropertyChanged(nameof(Name));
            }
        }

        public int BirthYear
        {
            get
            {
                return this.PersonBirthYear;
            }
            set
            {
                this.PersonBirthYear = value;
                OnPropertyChanged(nameof(BirthYear));
            }
        }

        public PGender Gender
        {
            get
            {
                return this.PersonGender;
            }
            set
            {
                this.PersonGender = value;
            }
        }

        // Note1: ikke tilladt at skrive access modifier = public i get eller set
        // Note2: hvis enten get eller set er defineret med en body (tyborgklammer), kan den anden ikke skrives 
        // vha. kort notification som ovenstående property: PersonName
        public Pet Pet
        {
            get
            {
                return this.PersonPet;
            }
            private set{ }
        }

        // constructor 1
        public Person(string Name)
        {
            this.PersonName = Name;
        }

        // constructor 2
        public Person(string Name, Pet Pet)
        {
            this.PersonName = Name;
            this.PersonPet = Pet;
        }

        // constructor 3
        public Person(string Name, string PetName, Species Species)
        {
            this.PersonName = Name;
            this.PersonPet = new Pet(PetName, Species);
        }

        // constructor 4
        public Person(string Name, int BirthYear)
        {
            this.PersonName = Name;
            this.PersonBirthYear = BirthYear;
        }

        // constructor 5
        public Person(string Name, int BirthYear, Pet Pet)
        {
            this.PersonName = Name;
            this.PersonBirthYear = BirthYear;
            this.PersonPet = Pet;
        }

        // events

        //
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // PersonName changed = NameChanged
        // delegate (method signature for handlers)
        public event EventHandler<string> NameChanged; 

        // method som raiser eventen NameChanged:
        private void OnNameChanged()
        {
            NameChanged?.Invoke(this, this.PersonName);  // (sender = OnNameChanged, eventarg = indhold af PersonName)         
        }
        

        // methods
        public string getName()
        {
            return this.PersonName;
        }

        public int getAge()
        {
            return Convert.ToInt32(DateTime.Now.Year) - this.PersonBirthYear;
        }

        public int getPetAmountEyes()
        {
            return this.PersonPet.Species.AmountEyes;
        }

        // use enum
        public string getHansHendes()
        {
            if (this.PersonGender == PGender.Male)
            {
                return "Hans";
            }
            else
            {
                return "Hendes";
            }
        }
    }


    // Extension classes
    public static class PersonExtensions
    {
        public static List<Person> FilterOut(this List<Person> personer, Filter filter)
        {
            List<Person> filterPersoner = new List<Person>();

            foreach (Person p in personer)
            {
                if (!filter(p))
                {
                    filterPersoner.Add(p);
                }
            }

            return filterPersoner;
        }
    }
}
