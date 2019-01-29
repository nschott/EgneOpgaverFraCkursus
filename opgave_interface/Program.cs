using System;
using System.Collections.Generic;

namespace opgave_interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Opgave med compare");
            Hund[] hunde = new Hund[2];
            hunde[0] = new Hund() { Alder = 10, Navn = "Bulder" };
            hunde[1] = new Hund() { Alder = 5, Navn = "Lady" };
            Array.Sort(hunde);
            foreach (var item in hunde)
            {
                Console.WriteLine(item.Navn);
            }

            Console.WriteLine();
            Console.WriteLine("Opgave med interface");
            // Array
            IDbFunktioner[] a1 = new IDbFunktioner[10];
            a1[0] = new Hund();
            a1[1] = new Ubåd();
            a1[2] = new Ubåd();
            a1[3] = new Ubåd();

            Console.WriteLine("Liste via Array");
            for (int i = 0; i < a1.Length; i++)
            {
                if (a1[i] is null)
                    break;
                else
                    a1[i].Gem();
            }

            
            // Liste
            List<IDbFunktioner> l1 = new List<IDbFunktioner>();
            l1.Add(new Hund());
            l1.Add(new Ubåd());
            l1.Add(new Ubåd());
            l1.Add(new Ubåd());

            Console.WriteLine();
            Console.WriteLine("Liste via List");
            foreach (IDbFunktioner item in l1)
            {
                item.Gem();
            }

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }


        interface IDbFunktioner
        {
            void Gem();
        }

        class Hund : IDbFunktioner, IComparable<Hund>
        {

            public string Navn { get; set; }
            public int Alder { get; set; }

            public int CompareTo(Hund other)
            {
                return this.Alder.CompareTo(other.Alder);
                //if (this.Alder > other.Alder)
                //return 1;
                //if (this.Alder < other.Alder)
                //    return -1;
                //return 0;
            }

            public void Gem()
            {
                Console.WriteLine("Gemmer hund");
            }
        }

        class Ubåd : IDbFunktioner 
        {

            public int Nummer { get; set; }
            public double Tubine { get; set; }

            public void Gem()
            {
                Console.WriteLine("Gemmer ubåd");
            }
        }
    }
}
