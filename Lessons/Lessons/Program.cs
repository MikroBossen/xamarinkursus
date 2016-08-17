using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lesson1_01();
            //Lesson1_02();
            //Lesson1_03();
            //Lesson1_04();
            Lesson1_05();
            //Lesson1_06();
            //Lesson1_07();
            //Lesson1_08();
            //Lesson1_09();
            //Lesson1_10();

            //Lesson2_01();
            //Lesson2_02();
            //Lesson2_03();
            //Lesson2_05();
            //Lesson2_06();
            //Lesson2_07();
            //Lesson2_08();
            //Lesson2_09();
        }

        public static void Lesson1_01()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Berit");
            Console.ReadKey();

            Console.WriteLine("\n");

            Console.WriteLine("Hello \nBerit");
            Console.ReadKey();
        }

        public static void Lesson1_02()
        {
            Console.WriteLine(12 + 13);
            Console.ReadKey();
            Console.WriteLine("\n");

            int a = 12;
            int b = 13;

            Console.WriteLine("Result of adding {0} and {1}: \n{2}", a, b, a+b);
            Console.ReadKey();
        }

        public static void Lesson1_03()
        {
            Console.WriteLine(24 / 5);
            Console.ReadKey();
            Console.WriteLine("\n");

            float a = 24;
            float b = 5;
            float result = a / b;

            Console.WriteLine(result);
            Console.ReadKey();
        }

        public static void Lesson1_04()
        {
            Console.WriteLine(-1 + 3 * 5);
            Console.WriteLine((24 + 5) % 7);
            Console.WriteLine(15 + -4 * 6 / 11);
            Console.WriteLine(2 + 10 / 6 * 1 - 7 % 2);
            Console.ReadKey();
            Console.WriteLine("\n");

            float a;
            float b;
            float c;
            float d;
            float e;
            float f;
            float result;

            a = -1;
            b = 3;
            c = 5;
            result = a + b * c;
            Console.WriteLine(result);

            a = 24;
            b = 5;
            c = 7;
            result = (a + b) % c;
            Console.WriteLine(result);

            a = 15;
            b = -4;
            c = 6;
            d = 11;
            result = a + b * c / d;
            Console.WriteLine(result);

            a = 2;
            b = 10;
            c = 6;
            d = 1;
            e = 7;
            f = 2;
            result = a + b / c * d - e % f;
            Console.Write(result);

            Console.ReadKey();
        }

        public static void Lesson1_05()
        {
            int a;
            int b;

            Console.WriteLine("Skriv 1. tal: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Skriv 2. tal: ");
            b = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("Resultat af multiplikation: {0}", a * b);
            Console.ReadKey();
        }

        public static void Lesson1_06()
        {
            Console.WriteLine("Hej Berit. Angiv venligst 3 tal til multiplikering: ");
            Console.WriteLine("1. tal:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. tal:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3. tal:");
            int c = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Resultat: {0} * {1} * {2} = {3}", a, b, c, a * b * c);
            Console.ReadKey();
        }

        public static void Lesson1_07()
        {
            double a;
            double b;

            Console.WriteLine("Angiv 2 tal, der skal hhv. lægges sammen, trækkes fra hinanden, ganges, divideres og finde modulus.");
            Console.WriteLine("Indtast 1. tal:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Indtast 2. tal:");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
            Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
            Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
            if (b != 0)
            {
                Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
                Console.WriteLine("{0} mod {1} = {2}", a, b, a % b);
            }
            else
            {
                Console.WriteLine("Division med {0} ikke muligt.", b);
            }            

            Console.ReadKey();
        }

        public static void Lesson1_08()
        {
            int a;
            Console.WriteLine("Indtast et tal og få vist dets gangetabel.");
            Console.WriteLine("Indtast tal:");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Gangetabel for {0}:", a);
            for(int i = 1; i < 11; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", a, i, a * i);
            }

            Console.ReadKey();
        }

        public static void Lesson1_09()
        {
            double a;
            double b;
            double c;
            double d;

            Console.WriteLine("Indtast 4 tal og få vist gennemsnittet af disse tal.");
            Console.WriteLine("Indtast 1. tal:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Indtast 2. tal;");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Indtast 3. tal;");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Indtast 4. tal;");
            d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("({0} + {1} + {2} + {3}) / 4 = {4}", a, b, c, d, (a + b + c + d) / 4);

            Console.ReadKey();
        }

        public static void Lesson1_10()
        {
            int a;
            int b;
            int c;

            Console.WriteLine("Angiv 3 tal.");
            Console.WriteLine("1. tal:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. tal:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3. tal:");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("({0} + {1}) * {2} = {3} og {0} * {2} + {1} * {2} = {4}", a, b, c, (a + b) * c, a * c + b * c);

            Console.ReadKey();
        }


        public static void Lesson2_01()
        {
            int a;

            Console.WriteLine("Angiv et tal:");
            a = Convert.ToInt32(Console.ReadLine());

            if(a > 0)
            {
                Console.WriteLine("Tallet er positivt.");
            }
            else if(a == 0)
            {
                Console.WriteLine("Tallet er 0.");
            }
            else
            {
                Console.WriteLine("Tallet er negativt.");
            }

            Console.ReadKey();
        }

        public static void Lesson2_02()
        {
            int a;
            int b;

            Console.WriteLine("Skriv et tal");
            a = Convert.ToInt32(Console.ReadLine());

            if(a != 0)
            {
                Console.WriteLine("Skriv et andet tal");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
            }
            else
            {
                Console.WriteLine("Du tastede 0");
            }

            Console.ReadKey();
        }

        public static void Lesson2_03()
        {
            int a;
            int b;

            Console.WriteLine("Skriv et tal");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Skriv et andet tal");
            b = Convert.ToInt32(Console.ReadLine());

            if (b != 0)
            {
                Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
            }
            else
            {
                Console.WriteLine("Man kan ikke dividere med 0");
            }

            Console.ReadKey();
        }

        // Opgave Lesson2_04 løst i Lesson2_03

        public static void Lesson2_05()
        {
            int a, b, c;
            int abEqual = 0;
            int acEqual = 0;
            int bcEqual = 0;

            Console.WriteLine("Angiv 1. tal:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Angiv 2. tal:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Angiv 3. tal:");
            c = Convert.ToInt32(Console.ReadLine());

            if (a == b)
            {
                abEqual = 1;
            }

            if (a == c)
            {
                acEqual = 1;
            }

            if (b == c)
            {
                bcEqual = 1;
            }

            if (a > b && a > c)
            {
                if (bcEqual != 1)
                {
                    Console.WriteLine("{0} er større end {1} og {2}", a, b, c);
                }
                else
                {
                    Console.WriteLine("{0} er større end {1} (angivet 2 gange)", a, b);
                }
            }
            else if(b > a && b > c)
            {
                if (acEqual != 1)
                {
                    Console.WriteLine("{1} er større end {0} og {2}", a, b, c);
                }
                else
                {
                    Console.WriteLine("{1} er større end {0} (angivet 2 gange)", a, b);
                }
                
            }
            else if(c > a && c > b)
            {
                if (abEqual != 1)
                {
                    Console.WriteLine("{2} er større end {0} og {1}", a, b, c);
                }
                else
                {
                    Console.WriteLine("{1} er større end {0} (angivet 2 gange)", a, c);
                }                
            }
            else if (abEqual == 1 && a > c)
            {
                Console.WriteLine("{0} (angivet 2 gange) er større end {1}", a, c);
            }
            else if (acEqual == 1 && a > b) 
            {
                Console.WriteLine("{0} (angivet 2 gange) er større end {1}", a, b);
            }
            else if (bcEqual == 1 && b > a)
            {
                Console.WriteLine("{1} (angivet 2 gange) er større end {0}", a, b);
            }
            else
            {
                Console.WriteLine("Samme tal angivet alle 3 gange.");
            }

            Console.ReadKey();
        }

        public static void Lesson2_06()
        {
            int x;
            Console.WriteLine("Angiv et tal");
            x = Convert.ToInt32(Console.ReadLine());

            while (x != 0)
            {
                Console.WriteLine("Resultat: {0} * 10 = {1}", x, x * 10);
                Console.WriteLine("Angiv et nyt tal");
                x = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("0 angivet og programmet afsluttes.");
            Console.ReadKey();
        }

        public static void Lesson2_07()
        {
            int x;

            do
            {
                Console.WriteLine("Angiv et tal");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Resultat: {0} * 10 = {1}", x, x * 10);
            } while (x != 0);

            Console.WriteLine("0 angivet og programmet afsluttes.");
            Console.ReadKey();
        }

        public static void Lesson2_08()
        {
            int x = 1;

            while (x <= 10)
            {
                Console.WriteLine("{0}", x);
                x++;
            }

            Console.ReadKey();
        }

        public static void Lesson2_09()
        {
            int number;
            int x = 0;

            Console.WriteLine("Angiv et tal");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Gangetabel for {0}", number);

            while (x <= 10)
            {
                Console.WriteLine("{0} * {1} = {2}", number, x, number * x);
                x++;
            }

            Console.ReadKey();
        }
    }
}
