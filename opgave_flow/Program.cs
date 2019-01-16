using System;

namespace opgave_flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int tal;
            string visTal;
            for (int x = 1; x < 11; x++)
            {
                for (int y = 1; y < 11; y++)
                {
                    tal = y*x;
                    visTal = tal.ToString();
                    if (tal > 50)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    
                    Console.Write(visTal.PadLeft(4)+" ");
                }
                Console.WriteLine("");
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Method 1");
            for (int z = 0; z < 20; z+=3)
            {
                Console.WriteLine(z);
                if (z == 15)
                    break;
            }

            Console.WriteLine("Method 2");
            for (int z = 0; z < 20; z++)
            {
                if (z % 3 == 0)
                    Console.WriteLine(z);
                else
                    continue;
                if (z == 15)
                    break;
            }
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
