using System;

namespace opgave_regnemaskine
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime c = DateTime.Now;
            DateTime d = new DateTime();
        
            Console.WriteLine(c);
            Console.WriteLine(d);

            //Console.WriteLine("Indtast tal 1");
            //string tal1 = Console.ReadLine();
            //Console.WriteLine("Indtast tal 2");
            //string tal2 = Console.ReadLine();
            //double t1 = System.Convert.ToDouble(tal1);
            //double t2 = System.Convert.ToDouble(tal2);
            //double result = t1 + t2;
            //Console.WriteLine(result.ToString("N2"));


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
