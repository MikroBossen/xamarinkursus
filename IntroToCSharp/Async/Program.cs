using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async
{
    class Program
    {
        static void Main(string[] args)
        {
            MainAsync().Wait();
            //MainAsync(); // mangler en await metode
            Console.WriteLine("Skriver noget, imens vi venter.");
        }

        static async Task MainAsync()
        //static async void MainAsync() // void => så kan man ikke kalde Wait-metoden i Main
        {
            await Task.Delay(1000);
            //Task.Delay(1000); // manglende await => metoden fortsætter, før kaldet er tilendebragt 

            //throw new Exception();
        }
    }
}
