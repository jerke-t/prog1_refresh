using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oef12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Waarvan wilt u de faculteit kennen?");
            int input = int.Parse(Console.ReadLine());
            int output = 1;
            for (int i = 1; i < input+1; i++)
            {
                output = output * i;
            }
            Console.WriteLine(input.ToString() + "! = " + output.ToString());
            Console.Write("Druk op een toets om het programma af te sluiten...");
            Console.ReadKey();
        }
    }
}
