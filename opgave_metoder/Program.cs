using System;

namespace opgave_metoder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Opgave med metoden Udskriv");
            Console.WriteLine(LægSammen(2,3));
            Console.WriteLine(BeregnAreal(22));
            Udskriv("Her er en tekst til metoden: Udskriv");
            Console.WriteLine("");

            Console.WriteLine("Opgave med instans- og statisk metode");
            Person m1 = new Person();
            m1.birthYear = 1967;
            m1.sex = "Male";
            bool res = Person.ValiderAlder(43);

            Console.WriteLine("Age is :"+m1.Age());
            Console.WriteLine("");

            Console.WriteLine("Opgave med Beregn metode");
            Console.WriteLine(Beregn(2, 3));
            Console.WriteLine(Beregn(2, 3, 4));  
            Console.WriteLine(Beregn(2, 3, 4, 5));
            Console.WriteLine("");

            Console.WriteLine("Opgave med LøkkeSomMetode");
            LøkkeSomMetode(1, 10);

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
        
        static void LøkkeSomMetode(int a, int b)
        {
            if (a > b)
                return;
            
            Console.WriteLine(a);
            LøkkeSomMetode(a + 1, b);
        }

        static int LægSammen(int a, int b)
        {
            return a + b;
        }

        static double BeregnAreal(int radius)
        {
            return radius * radius * System.Math.PI;
        }

        static void Udskriv(string txt)
        {
            Console.WriteLine(txt);
        }

        static int Beregn(int a, int b)
        {
            return a + b;
        }

        static int Beregn(int a, int b, int c)
        {
            return Beregn(a, b) + c;
        }

        static int Beregn(int a, int b, int c, int d)
        {
            return Beregn(a, b, c) + d;
        }
    }


    public struct Person
    {
        public int birthYear;
        public string sex;

        public int Age()
        {
            //int yearNow = DateTime.Now.Year;
            //int calculateAge = yearNow - birthYear;
            //return (calculateAge);

            return (DateTime.Now.Year - birthYear);
        }
        public static bool ValiderAlder(int a)
        {
            if ((a > 0) && (a <140))
                return true;
            else
                return false;
        }
    }
}
