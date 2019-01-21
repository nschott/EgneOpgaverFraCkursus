using System;

namespace fejl_simple
{
    class Program
    {
        static void Main(string[] args)
        {
            const int numberTries = 3;
            int tryNo = 1;
Again:
            try
            {
                Run();
            }
            catch (Exception ex)
            {
                tryNo += 1;
                if (tryNo > numberTries)
                    Console.WriteLine($"Der er sket en fejl - {ex.Message}");
                else
                {
                    Console.WriteLine($"Der er fejl i dit input - prøv igen ({numberTries-tryNo+1} forsøg tilbage)");
                    goto Again;
                }
            }
            
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
        private static void Run()
        {
            Console.WriteLine("Indtast 1. tal");
            int tal1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Indtast 2. tal");
            int tal2 = Convert.ToInt32(Console.ReadLine());
            int res = tal1 + tal2;
            Console.WriteLine("resultatet er " + res);
        }
    }
}
