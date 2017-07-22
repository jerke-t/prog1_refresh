using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oef10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wat is uw eerste getal?");
            int getal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Wat is uw tweede getal?");
            int getal2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Maak een keuze uit de volgende bewerkingen:");
            Console.WriteLine("   1. Optellen");
            Console.WriteLine("   2. Aftrekken");
            Console.WriteLine("   3. Vermenigvuldigen");
            Console.WriteLine("   4. Delen");

            Console.Write("Uw keuze: ");
            string bewerking = Console.ReadLine();
            int uitkomst = 0;
            switch (bewerking)
            {
                case "1":
                    uitkomst = getal1 + getal2;
                    break;
                case "2":
                    uitkomst = getal1 - getal2;
                    break;
                case "3":
                    uitkomst = getal1 * getal2;
                    break;
                case "4":
                    if (!(getal2==0))
                    {
                        uitkomst = getal1 / getal2;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("U mag niet delen door 0");
                        break;
                    }
            }

            Console.WriteLine("De uikomst van de bewerking: " + uitkomst.ToString());
            Console.Write("Druk op een toets om het programme te beëindigen...");
            Console.ReadKey();
        }
    }
}
