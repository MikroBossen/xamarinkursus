using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToCSharp
{
    // Hvis extension methods ligger udenfor namespace'et (i andet projekt)
    // using IntroToCSharp;

    // og hvis man kun ønsker extension methods fra en specifik klasse
    // using static IntroToSharp.ExpressionExtensions;

    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World");
            //Console.ReadKey();

            //Console.WriteLine("\n");
            //Console.WriteLine("While loop eksempel:");
            //WhileLoop();

            //Console.WriteLine("\n");
            //Console.WriteLine("Do loop eksempel:");
            //DoLoop();

            //Species Kat = new Species("Kat", "Katten", 4, 2);

            //Pet Kaeledyr = new Pet("Olfert", Kat);

            //Person first = new Person("Sigurd", Kaeledyr);
            //first.Gender = "Male";
            //first.BirthYear = 1972;

            //first.NameChanged += Person_NameChanged;
            //first.NameChanged += Another_NameChanged;
            //first.PropertyChanged += Property_Changed;

            //first.Name = "Anja";
            //first.Name = "Børge";
            //first.BirthYear = 1981;

            //Console.WriteLine("Personen hedder " + first.getName() + " og er " + first.getAge() + " år.");
            //Console.WriteLine(first.getHansHendes() + " kæledyr er en " + first.PersonPet.PetSpecies.getSpeciesName().ToLower() + " og har " + first.getPetAmountEyes() + " øjne.");
            //Console.WriteLine(first.PersonPet.PetSpecies.getSpeciesNameSpecific() + "s navn er " + first.PersonPet.getPetName() + ".");

            //Console.ReadKey();


            // Test expression
            // Før extension metoden ToExpression
            //Expression expr = new MinusExpression(
            //                    new ConstantExpression(4),
            //                    new PlusExpression(
            //                        new ConstantExpression(1),
            //                        new ConstantExpression(2)));

            //Expression expr2 = new MultiplyExpression(
            //                    new ConstantExpression(4),
            //                    new PlusExpression(
            //                        new ConstantExpression(1),
            //                        new ConstantExpression(2)));

            //Expression expr3 = new PlusExpression(
            //                   new ConstantExpression(3),
            //                   new NegateExpression(
            //                       new ConstantExpression(4)));

            //Expression expr4 = new SquareExpression(
            //                   new ConstantExpression(3));

            //Expression expr5 = new DivideExpression(
            //                    new ConstantExpression(12),
            //                    new ConstantExpression(4));

            //Expression expr6 = new PowExpression(
            //                    new ConstantExpression(6),
            //                    new ConstantExpression(3));

            //// We print the textual representation
            //Console.Write(expr.ToString());
            //Console.Write(" = ");
            //// ... and then the result of evaluating
            //Console.WriteLine(expr.Evaluate());

            //Console.Write(expr2.ToString());
            //Console.Write(" = ");
            //Console.WriteLine(expr2.Evaluate());

            //Console.Write(expr3.ToString());
            //Console.Write(" = ");
            //Console.WriteLine(expr3.Evaluate());

            //Console.Write(expr4.ToString());
            //Console.Write(" = ");
            //Console.WriteLine(expr4.Evaluate());

            //Console.Write(expr5.ToString());
            //Console.Write(" = ");
            //Console.WriteLine(expr5.Evaluate());

            //Console.Write(expr6.ToString());
            //Console.Write(" = ");
            //Console.WriteLine(expr6.Evaluate());


            // Test expression
            // Efter extension metoden ToExpression

            //double forsteKonstant = 4.0;
            //double andenKonstant = 1.0;
            //double tredjeKonstant = 2.0;

            //Expression expr = new MinusExpression(
            //                    forsteKonstant.ToExpression(),
            //                    new PlusExpression(
            //                        andenKonstant.ToExpression(),
            //                        tredjeKonstant.ToExpression()));

            //Expression expr2 = new MultiplyExpression(
            //                    forsteKonstant.ToExpression(),
            //                    new PlusExpression(
            //                        andenKonstant.ToExpression(),
            //                        tredjeKonstant.ToExpression()));

            //// We print the textual representation
            //Console.Write(expr.ToString());
            //Console.Write(" = ");
            //// ... and then the result of evaluating
            //Console.WriteLine(expr.Evaluate());

            //Console.Write(expr2.ToString());
            //Console.Write(" = ");
            //Console.WriteLine(expr2.Evaluate());



            // Test delegates

            //    var speciesList = new List<Species>();
            //    speciesList.Add(new Species("Kat", "Katten", 4, 2, AnimalType.Fish));
            //    speciesList.Add(new Species("Edderkop", "Edderkop", 8, 6, AnimalType.Bird));
            //    speciesList.Add(new Species("Flue", "Fluen", 6, 8000, AnimalType.Bird));
            //    speciesList.Add(new Species("Aborre", "Aborren", 0, 2, AnimalType.Fish));

            //    var personListe = new List<Person>();
            //    personListe.Add(new Person("Sigurd", new Pet("Olfert", speciesList[0])));
            //    personListe.Add(new Person("Emil", new Pet("Peter", speciesList[1])));
            //    personListe.Add(new Person("Egon", new Pet("Oda", speciesList[2])));
            //    personListe.Add(new Person("Gurli", new Pet("Blobber", speciesList[3])));
            //    personListe.Add(new Person("Mads", new Pet("Felix", speciesList[0])));

            //    Filter filterA = p => p.getPetAmountEyes() <= 2;
            //    var filterAListe = personListe.FilterOut(filterA);

            //    Console.WriteLine("Personer, hvis kæledyr har mere end 2 øjne:");
            //    foreach (Person p in filterAListe)
            //    {
            //        Console.WriteLine(p.Name + " - kæledyrets race: " + p.Pet.Species.getName() + ", som har " + p.Pet.Species.AmountEyes.ToString() + " øjne.");
            //    }
            //    Console.WriteLine("\n");

            //    var filterBListe = personListe.FilterOut(p => p.getName() != "Egon");

            //    Console.WriteLine("Kæledyr, hvis ejer hedder Egon:");
            //    foreach (Person p in filterBListe)
            //    {
            //        var filterNegListeB = personListe.FilterOut(p2 => p2.getName() == "Egon");

            //        Console.Write(p.Pet.Species.getNameSpecific() + " " + p.Pet.getName() + ", hvis ejer ikke er ");
            //        if (filterNegListeB.Count() > 1)
            //        {
            //            Console.Write(filterNegListeB[0].Name + ", ");

            //            for (int i = 1; i < filterNegListeB.Count() - 2; i++)
            //            {
            //                Console.Write(filterNegListeB[i].Name + ", ");
            //            }

            //            Console.Write(filterNegListeB[filterNegListeB.Count() - 2].Name + " eller ");
            //            Console.WriteLine(filterNegListeB[filterNegListeB.Count() - 1].Name + ".");
            //        }
            //        else
            //        {
            //            Console.Write(filterNegListeB[0].Name);
            //        }
            //    }


            //    Console.ReadKey();




            // LINQ opgaver

            //var pets = new List<Pet>()
            //{
            //    new Pet("Rudolph the Goldfish", new Species("Goldfish", AmountEyes: 2, AmountLegs: 0, AnimalType: AnimalType.Fish)),
            //    new Pet("Hugo", new Species("Dog", AnimalType.Bird)),
            //    new Pet("Kaptajn Kaper", new Species("Parrot", AnimalType.Bird)),
            //    new Pet("Mr. Hammer Jr.", new Species("Millipede", AmountEyes: 2, AmountLegs: 1000, AnimalType: AnimalType.Fish)),
            //    new Pet("Ms. Silk", new Species("Spider", AmountEyes: 6, AmountLegs: 8, AnimalType: AnimalType.Bird))
            //};

            //var people = new List<Person>()
            //{
            //    new Person("Anders And", 1934),
            //    new Person("Mr. Hammer", 1975, pets[3]),
            //    new Person("Sørøver John", 1969, pets[2]),
            //    new Person("Bent Tonse", 1973, pets[0]),
            //    new Person("Fyrst Walter", 1965),
            //    new Person("Gentleman Finn", 1972, pets[4]),
            //    new Person("Newton Dynamose", 1657)
            //};

            //// Opgave 2.a:
            //Console.WriteLine("Born in 1972:");
            //var query2A = from p in people
            //              where p.BirthYear == 1972
            //              select p.Name;

            //foreach (var personName in query2A)
            //{
            //    Console.WriteLine(personName);
            //}
            //Console.WriteLine();

            //// Opgave 2.b:
            //Console.WriteLine("Persons sorted by name:");
            //var query2B = from p in people
            //              orderby p.Name
            //              select p.Name;

            //foreach (var personName in query2B)
            //{
            //    Console.WriteLine(personName);
            //}
            //Console.WriteLine();

            //// Opgave 2.c:
            //Console.WriteLine("Fishes:");
            //var query2C = from p in pets
            //              where p.Species.AnimalType == AnimalType.Fish
            //              select p;

            //foreach (var person in query2C)
            //{
            //    Console.WriteLine("Name: " + person.Name + ". Species: " + person.Species.AnimalType);
            //}
            //Console.WriteLine();

            //// Opgave 2.d:
            //Console.WriteLine("Persons with pets with more than 2 eyes:");
            //var query2D = from p in people
            //              join pet in pets
            //              on p.Pet equals pet
            //              where pet.Species.AmountEyes > 2
            //              select p;

            //foreach (var person in query2D)
            //{
            //    Console.WriteLine(person.Name + ", pet's amount of eyes: " + person.Pet.Species.AmountEyes.ToString());
            //}
            //Console.WriteLine();

            //// Opgave 3.a:
            //Console.WriteLine("Sort persons by pets species and name of person:");
            //var query3A = from p in people
            //              where p.Pet != null
            //              orderby p.Pet.Species.AnimalType, p.Name
            //              select p;

            //foreach (var person in query3A)
            //{
            //    Console.WriteLine(person.Pet.Species.AnimalType.ToString() + ", " + person.Name);
            //}
            //Console.WriteLine();

            //// Opgave 3.b:
            //Console.WriteLine("Persons with pets grouped by pet species:");
            //var query3B = from p in people
            //              where p.Pet != null
            //              group p by p.Pet.Species.AnimalType;

            //foreach (var group in query3B)
            //{
            //    Console.WriteLine("Persons with " + group.Key + ":");

            //    foreach (var person in group)
            //    {
            //        Console.WriteLine(person.Name);
            //    }

            //    Console.WriteLine();
            //}
            //Console.WriteLine();

            //// Opgave 3.c:
            //Console.WriteLine("Pets, that are fishes and have more than 0 legs, sorted by amount of legs:");
            //var query3C = from p in pets
            //              where p.Species.AmountLegs > 0 && p.Species.AnimalType == AnimalType.Fish
            //              orderby p.Species.AmountLegs
            //              select p;
            //foreach (var pet in query3C)
            //{
            //    Console.WriteLine(pet.Name + ", der har " + pet.Species.AmountLegs.ToString() + " ben.");
            //}
            //Console.WriteLine();

            //Console.ReadKey();

        }

        //private static void Person_NameChanged(object sender, string name)
        //{
        //    Console.WriteLine("New name: " + name);
        //}

        //private static void Another_NameChanged(object sender, string name)
        //{
        //    Console.WriteLine("YAY");
        //}

        //private static void Property_Changed(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        //{
        //    Console.WriteLine("Property, som har skiftet værdi: " + e.PropertyName);
        //}

        //static void WhileLoop()
        //{
        //    int x = 0;

        //    while(x < 5)
        //    {
        //        Console.Write("{0} ", x);
        //        x++;
        //    }
        //    Console.WriteLine();
        //}


        //static void DoLoop()
        //{
        //    string valg;

        //    do
        //    {
        //        Console.WriteLine("Min ønskeseddel\n");

        //        Console.WriteLine("T - Tilføj ønske til listen");
        //        Console.WriteLine("F - Fjern ønske fra listen");
        //        Console.WriteLine("R - Ret ønske på listen");
        //        Console.WriteLine("V - Vis ønske fra listen");
        //        Console.WriteLine("A - Afslut\n");

        //        Console.WriteLine("Vælg (T, F, R, V, A): ");

        //        valg = Console.ReadLine();

        //        switch (valg)
        //        {
        //            case "T":
        //            case "t":
        //                Console.WriteLine("Du vil tilføje et ønske på listen.");
        //                goto case "continue";
        //            case "F":
        //            case "f":
        //                Console.WriteLine("Du vil fjerne et ønske fra listen.");
        //                break;
        //            case "R":
        //            case "r":
        //                Console.WriteLine("Du vil rette et ønske på listen.");
        //                goto case "continue";
        //            case "V":
        //            case "v":
        //                Console.WriteLine("Du vil have vist et ønske fra listen.");
        //                goto case "continue";
        //            case "A":
        //            case "a":
        //                Console.WriteLine("Farvel og tak for denne gang :-)");
        //                break;
        //            case "continue":
        //                Console.Write("Tryk på Enter-tast for at fortsætte ...");
        //                break;
        //            default:
        //                Console.WriteLine("{0} er ikke et validt tegn / valg. Prøv igen.", valg);
        //                break;
        //        }

        //        Console.ReadLine();
        //        Console.WriteLine();
        //    }
        //    while (valg != "A" && valg != "a");
        //}


        //static void ForLoop()
        //{

        //}
    }
}
