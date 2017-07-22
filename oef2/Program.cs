using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oef2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voer een zin in dat u wilt herhalen:");
            string input = Console.ReadLine();
            Console.WriteLine("De ingevoerde tekst is: " + input.ToString());
            Console.Write("Druk op een toets om de applicatie af te sluiten...");
            Console.ReadKey();
        }
    }
}
