using System;
using System.Collections.Generic;

namespace opgave_delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Opgave med lamda (konvertering af delegates)");
            List<int> a = new List<int>() { 5, 1, 51, 7, 1, 56, 36, 5 };

            int res = a.FindIndex(Find);
            Console.WriteLine("Resultat af res er: " + res);

            int res1 = a.FindIndex(x => x == 51);
            Console.WriteLine("Resultat af res1 er: " + res1);

            Console.WriteLine();
            Console.WriteLine("Opgave med delegates");
            Action<string> f1 = MinSkrivTilConsole;
            //MinDelegate1 f1 = new MinDelegate1(MinSkrivTilConsole);
            f1.Invoke("Test1");

            Action<string> f2 = MinSkrivTilConsole;
            //MinDelegate1 f2 = MinSkrivTilConsole;
            f2("Test2");

            Action<string> f3 = MinSkrivTilConsole;
            //MinDelegate1 f3 = MinSkrivTilConsole;
            f3 += Console.WriteLine;
            f3("Test3");

            f1 -= MinSkrivTilConsole;
            f2 -= MinSkrivTilConsole;
            f3 -= MinSkrivTilConsole;
            f3 -= Console.WriteLine;

            // Giver exception
            //f1("Test1");
            //f2("Test2");
            //f3("Test3");

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }


            bool Find(int _a)
            {
                if (_a == 51)
                    return true;
                else
                    return false;

            }


        }


        static void MinSkrivTilConsole(string txt)
        {
            Console.WriteLine("**** " + txt + " ****");
        }
    }

    //delegate void MinDelegate1(string t);
}
