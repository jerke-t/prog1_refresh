using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oef11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geeft uw eerste getal in:");
            decimal getal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Geeft uw tweede getal in:");
            decimal getal2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Maak een keuze uit volgende bewerkingen");
            Console.WriteLine("    1. Optellen");
            Console.WriteLine("      " + getal1.ToString() + " + " + getal2.ToString());
            Console.WriteLine("    2. Aftrekken");
            Console.WriteLine("      " + getal1.ToString() + " - " + getal2.ToString());
            Console.WriteLine("    3. Vermenigvuldigen");
            Console.WriteLine("      " + getal1.ToString() + " * " + getal2.ToString());
            Console.WriteLine("    4. Delen");
            Console.WriteLine("      " + getal1.ToString() + " / " + getal2.ToString());

            Console.Write("Uw keuze: ");
            string keuze = Console.ReadLine();
            decimal uitkomst = 0;
            string output = string.Empty;
            switch (keuze)
            {
                case "1":
                    uitkomst = getal1 + getal2;
                    output = "De uitkomst van de bewerking is: " + uitkomst.ToString();
                    break;
                case "2":
                    uitkomst = getal1 - getal2;
                    output = "De uitkomst van de bewerking is: " + uitkomst.ToString();
                    break;
                case "3":
                    uitkomst = getal1 * getal2;
                    output = "De uitkomst van de bewerking is: " + uitkomst.ToString();
                    break;
                case "4":
                    if (getal2==0)
                    {
                        output = "ERROR: U mag niet delen door 0";
                    }
                    else
                    {
                        uitkomst = getal1 / getal2;
                        output = "De uitkomst van de bewerking is: " + uitkomst.ToString();
                    }
                    
                    break;
                default:
                    output = "ERROR: U heeft een ongeldige keuze gemaakt...";
                    break;
            }
            Console.WriteLine(output);

            Console.WriteLine("Druk op een toets om het programma af te sluiten...");
            Console.ReadKey();
        }
    }
}
