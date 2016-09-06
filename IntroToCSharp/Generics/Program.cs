using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var expr = new ConstantExpression<int>(4);

            Console.Write(expr.ToString());
            Console.Write(" = ");
            Console.WriteLine(expr.Evaluate());

            var expr2 = new ConstantExpression<double>(3.5);

            Console.Write(expr2.ToString());
            Console.Write(" = ");
            Console.WriteLine(expr2.Evaluate());

            var expr3 = new ConstantExpression<string>("Hello world");

            Console.Write(expr3.ToString());
            Console.Write(" = ");
            Console.WriteLine(expr3.Evaluate());

            Console.WriteLine("\nPlusExpression kan ikke gøres generisk, fordi genetiske klasser og metoder opererer med objekter og de kan ikke adderes).");

            Console.ReadKey();
        }
    }
}
