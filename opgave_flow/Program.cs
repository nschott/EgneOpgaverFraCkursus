using System;

namespace opgave_flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int visTal;
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    visTal = y*x;
                    Console.Write(visTal);
                }
            }

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
