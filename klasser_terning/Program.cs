using System;

namespace klasser_terning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The real dice - making 10 throws after init");
            Terning t1 = new Terning();
            for (int i = 0; i < 11; i++)
            {
                t1.Show();
                t1.Throw();
            }

            Console.WriteLine("The fake dice - making 2 throws after init");
            Terning t2 = new Terning(true);
            t2.Show();
            t2.Throw();
            t2.Show();
            t2.Throw();
            t2.Show();

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
