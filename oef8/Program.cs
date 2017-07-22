using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oef8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Waarvan wilt u het aantal woorden weten?");
            string input = Console.ReadLine();
            string[] woorden = input.Split(' ');
            Console.WriteLine("Uw invoer heeft " + woorden.Length.ToString() + " woord(en)");
            Console.WriteLine("Deze woorden zijn:");
            foreach (string woord in woorden)
            {
                Console.WriteLine('"' + woord.ToString() + '"');
            }


            Console.Write("Druk op een toets om het programma te beëindigen...");
            Console.ReadKey();
        }
    }
}
