using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oef7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wat wilt u herhaald zien worden in omgekeerde volgorde (Reverse() methode mag niet bebruikt worden)?");
            string input = Console.ReadLine();
            string output = string.Empty;
            foreach (char karakter in input)
            {
                output = karakter + output;

            }
            Console.WriteLine("Uw invoer in omgekeerde volgorde is: " + output.ToString());

            Console.Write("Druk op een toets om het programma te beëindigen...");
            Console.ReadKey();
        }
    }
}
