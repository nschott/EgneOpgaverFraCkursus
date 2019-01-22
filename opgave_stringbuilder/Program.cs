using System;

namespace opgave_stringbuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            int antalString = 50_000;
            int antalStringBuilder = 10_000_000;

            // Stopur
            Console.WriteLine("Test med string og antal = "+antalString);
            System.Diagnostics.Stopwatch s = new System.Diagnostics.Stopwatch();
            s.Start();
            string a = "";
            for (int i = 0; i < antalString; i++)
            {
                a += "*";
            }
            s.Stop();
            Console.WriteLine($"ms = {s.ElapsedMilliseconds}");

            Console.WriteLine("Test med StringBuilder og antal = "+antalStringBuilder);
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            s.Start();
            for (int i = 0; i < antalStringBuilder; i++)
            {
                sb.Append("*");
            }
            s.Stop();
            Console.WriteLine($"ms = {s.ElapsedMilliseconds}");

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
