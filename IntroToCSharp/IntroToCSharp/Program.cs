using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.ReadKey();

            Console.WriteLine("\n");
            Console.WriteLine("While loop eksempel:");
            WhileLoop();

            Console.WriteLine("\n");
            Console.WriteLine("Do loop eksempel:");
            DoLoop();
        }


        static void WhileLoop()
        {
            int x = 0;

            while(x < 5)
            {
                Console.Write("{0} ", x);
                x++;
            }
            Console.WriteLine();
        }


        static void DoLoop()
        {
            string valg;

            do
            {
                Console.WriteLine("Min ønskeseddel\n");

                Console.WriteLine("T - Tilføj ønske til listen");
                Console.WriteLine("F - Fjern ønske fra listen");
                Console.WriteLine("R - Ret ønske på listen");
                Console.WriteLine("V - Vis ønske fra listen");
                Console.WriteLine("A - Afslut\n");

                Console.WriteLine("Vælg (T, F, R, V, A): ");

                valg = Console.ReadLine();

                switch (valg)
                {
                    case "T":
                    case "t":
                        Console.WriteLine("Du vil tilføje et ønske på listen.");
                        goto case "continue";
                    case "F":
                    case "f":
                        Console.WriteLine("Du vil fjerne et ønske fra listen.");
                        break;
                    case "R":
                    case "r":
                        Console.WriteLine("Du vil rette et ønske på listen.");
                        goto case "continue";
                    case "V":
                    case "v":
                        Console.WriteLine("Du vil have vist et ønske fra listen.");
                        goto case "continue";
                    case "A":
                    case "a":
                        Console.WriteLine("Farvel og tak for denne gang :-)");
                        break;
                    case "continue":
                        Console.Write("Tryk på Enter-tast for at fortsætte ...");
                        break;
                    default:
                        Console.WriteLine("{0} er ikke et validt tegn / valg. Prøv igen.", valg);
                        break;
                }

                Console.ReadLine();
                Console.WriteLine();
            }
            while (valg != "A" && valg != "a");
        }


        static void ForLoop()
        {

        }
    }
}
