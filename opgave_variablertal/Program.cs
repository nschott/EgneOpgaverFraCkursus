using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave_variablertal
{
    class Program
    {
        static void Main(string[] args)
        {
            int heltal1 = 10;
            heltal1++;
            Console.WriteLine(heltal1);

            heltal1--;
            Console.WriteLine(heltal1);
            
            heltal1 += 20;
            Console.WriteLine(heltal1);

            double kommatal1 = 12.5;
            kommatal1++;
            Console.WriteLine(kommatal1);

            kommatal1--;
            Console.WriteLine(kommatal1);

            kommatal1 *= 2;
            Console.WriteLine(kommatal1);

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
