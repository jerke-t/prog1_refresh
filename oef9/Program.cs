using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oef9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Waarvan wilt u de woorden in omgekeerde volgorde zien?");
            string input = Console.ReadLine();
            string[] woorden = input.Split(' ');

            Console.WriteLine("De woorden van uw invoer in omgekeerde volgorde:");
            string output = string.Empty;
            foreach (string woord in woorden)
            {
                output = woord + " " + output;
            }
            Console.WriteLine(output.ToString());

            Console.Write("Druk op een toets om het programma te beëindigen...");
            Console.ReadKey();
        }
    }
}
