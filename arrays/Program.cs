using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] månedsløn = { 10000, 20000, 15000, 20000, 30000, 15000 };
            double gns = 0;

            string txt = "3;5;22;1;10;15;5";
            string[] txtarray;
            
            Console.WriteLine("Indhold af månedsløn - usorteret");
            foreach (int item in månedsløn)
            {
                Console.WriteLine(item);
                gns += item;
            }

            Console.WriteLine("Indhold af månedsløn - sorteret");
            Array.Sort(månedsløn);
            foreach (int item in månedsløn)
            {
                Console.WriteLine(item);
            }

            gns = gns / månedsløn.Length;
            Console.WriteLine("Gennemsnit af månedsløn er: "+gns.ToString("N2"));

            gns = 0;
            Console.WriteLine("Indhold af string txt");
            txtarray = txt.Split(';');
            foreach (string item in txtarray)
            {
                gns = gns + Convert.ToInt32(item);
                Console.WriteLine(item);
            }
            gns = gns / txtarray.Length;
            Console.WriteLine("Gennemsnit af txt data er: " + gns.ToString("N2") + " (skrevet med +)");
            Console.WriteLine($"Gennemsnit af txt data er: {gns:N2} (skrevet med $-tegn)");

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
