using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oef4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wat wilt u herhaald zien worden in hoofdletters?");
            string input = Console.ReadLine();
            Console.WriteLine("Uw invoer in hoofdletters is: " + input.ToString().ToUpper());

            Console.Write("Druk op een toets om het programma te beëindigen...");
            Console.ReadKey();
        }
    }
}
