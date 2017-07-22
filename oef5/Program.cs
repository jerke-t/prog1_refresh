using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oef5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Waarvan wilt u het aantal karakters weten?");
            string input = Console.ReadLine();
            Console.WriteLine("Uw invoer heeft " + input.Length.ToString() + " karakters");

            Console.Write("Druk op een toets om het programma te beëindigen...");
            Console.ReadKey();
        }
    }
}
