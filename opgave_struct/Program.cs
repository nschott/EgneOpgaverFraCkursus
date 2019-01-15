using System;

namespace opgave_struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Vare v1 = new Vare
            {
                Id = 1,
                Navn = "Vare #1",
                Beskrivelse = "Min beskrivelse til #1",
                Pris = 100
            };
            Console.WriteLine($"{v1.Navn} koster {v1.Pris:N2}");
                       

            Vare v2 = new Vare();
            v2.Id = 2;
            v2.Navn = "Vare #2";
            v2.Beskrivelse = "Min beskrivelse til #2";
            v2.Pris = 200;
            Console.WriteLine($"{v2.Navn} koster {v2.Pris:N2}");

            Vare v2Kopi = v2;
            Console.WriteLine($"{v2Kopi.Navn} koster {v2Kopi.Pris:N2}");

            SpilleKort s1 = new SpilleKort();
            s1.Værdi = 2;
            s1.Kulør = Kulør.Spar;
            Console.WriteLine($"{s1.Kulør} {s1.Værdi}");

            SpilleKort s2 = new SpilleKort();
            s2.Værdi = 10;
            s2.Kulør = Kulør.Hjerter;
            Console.WriteLine($"{s2.Kulør} {s2.Værdi}");

            string person1Navn = "Mathias";
            int person1Alder = 12;
            Køn person1Køn = Køn.Mand; // antag 1 = mand

            string person2Navn = "Lene";
            int person2Alder = 53;
            Køn person2Køn = Køn.Kvinde; // antag 0 = kvinde

            Console.WriteLine(person1Køn);

            Terning t = new Terning(4);
            Console.WriteLine(t.Værdi);
            t.Ryst();
            Console.WriteLine(t.Værdi);

            Person p1 = new Person();
            p1.Navn = "Mathias";
            p1.Alder = 10;
            p1.Skriv();

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
    public enum Kulør
    {
        Spar = 10,
        Hjerter = 20,
        Ruder = 30,
        Klør =40
    }

    public struct SpilleKort
    {
        public int Værdi;
        public Kulør Kulør;
    }

    public struct Vare
    {
        public int Id;
        public string Navn;
        public string Beskrivelse;
        public double Pris;
    }

    public enum Køn {
        Mand = 1,
        Kvinde = 0
    }

    internal struct Person
    {
        // felter
        public string Navn;
        public int Alder;

        public void Skriv()
        {
            Console.WriteLine("Jeg hedder "+Navn);
        }
    }

    struct A { };
    
    struct B { };

    public class Terning
    {
        // Felter
        private static Random rnd;
        private int _værdi;

        // Egenskab
        public int Værdi
        {
            get
            {
                return _værdi;
            }
            set
            {
                if (value < 1 || value > 6)
                    value = 1;
                if (value == 6)
                    ErSekser?.Invoke(this, new EventArgs());
                _værdi = value;
            }
        }

        // Metode
        public void Ryst()
        {
            Værdi = rnd.Next(1, 7);
        }

        // Hændelse
        public event EventHandler ErSekser;

        // Konstruktør
        public Terning()
        {
            rnd = new Random();
            Ryst();
        }

        // Konstruktør
        public Terning(int værdi) : base()
        {
            rnd = new Random();
            this.Værdi = værdi;
        }
    }
}
