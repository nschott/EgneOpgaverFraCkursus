using System;

namespace opgave_arv_polymorfi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mere kompleks polymorfi - med dyr");
            Hund h1 = new Hund() { Navn = "Fido" };
            Kat k1 = new Kat() { Navn = "Katty" };
            
            //h1.SigNoget();
            //k1.SigNoget();

            System.Collections.Generic.List<Dyr> zoo = new System.Collections.Generic.List<Dyr>();
            zoo.Add(h1);
            zoo.Add(k1);
            zoo.Add(new Kat() { Navn = "Trunte" });
            zoo.Add(new Kat() { Navn = "Sofus" });
            zoo.Add(new Hest() { Navn = "Danmark" });

            foreach (Dyr item in zoo)   
            {
                //Console.Write(item is Hund);
                item.SigNoget();
            }
            Console.WriteLine();
            Console.WriteLine($"Brug af 'is' på h1 og Dyr : {h1 is Dyr }");
            Console.WriteLine($"Brug af 'is' på k1 og Dyr : {k1 is Dyr }");
            Console.WriteLine($"Brug af 'is' på k1 og Hund: {k1 is Hund }");
            Console.WriteLine($"Brug af 'is' på k1 og Kat : {k1 is Kat }");

            Console.WriteLine();
            Console.WriteLine("Simpel polymorfi");
            Faktura f1 = new Faktura() { Nr = 1, Dato = new DateTime(2019, 01, 28), Kunde = "Mainframe-Soft" };
            Console.WriteLine(f1.ToString());


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        // Keyword 'abstract' forhindrer oprettelse af instans
        // Og for metoder fortæller man, at underklasser SKAL implementere metoden
        abstract class Dyr
        {
            public string Navn { get; set; }

            public abstract void SigNoget();
        }

        class Hund : Dyr
        {
            public override void SigNoget()
            {
                Console.WriteLine($"Vov! Jeg er en hund og hedder {Navn}");
            }
        }

        class Kat : Dyr
        {
            public override void SigNoget()
            {
                Console.WriteLine($"Miaw! Jeg er en kat og hedder {Navn}");
            }
        }

        class Hest : Dyr
        {
            public override void SigNoget()
            {
                Console.WriteLine($"Pruh! Jeg er en hest og hedder {Navn}");
            }

        }

        class Faktura
        {
            public int Nr { get; set; }
            public DateTime Dato { get; set; }
            public string Kunde { get; set; }

            // Polymorfi: Keyword 'override' benyttes på metoder, som er erklæret 'virtual'
            public override string ToString()
            {
                return $"Faktura til {Kunde} nr {Nr} fra {Dato:D}";
            }
        }
    }
}
