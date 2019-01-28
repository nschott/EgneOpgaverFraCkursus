using System;

namespace opgave_arv_terning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Almindelig terning");
            Terning t1 = new Terning();
            for (int i = 0; i < 10; i++)
            {
                t1.Skriv();
                t1.Ryst();
            }

            Console.WriteLine();
            Console.WriteLine("Ludo terning");
            LudoTerning l1 = new LudoTerning();
            for (int i = 0; i < 10; i++)
            {
                l1.Skriv();
                if (l1.ErGlobus())
                    Console.WriteLine("Det var en Globus!");
                if (l1.ErStjerne())
                    Console.WriteLine("Det var en Stjerne!");
                l1.Ryst();
            }

            Console.WriteLine();
            Console.WriteLine("Tildel terning værdi fra start");
            LudoTerning l2 = new LudoTerning(3);
            Console.Write(" - fik værdien ");
            l2.Skriv();

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

    class LudoTerning : Terning
    {
        public LudoTerning() : base()
        {

        }

        public LudoTerning(int _værdi) : base(_værdi)
        {

        }

        public bool ErGlobus()
        {
            if (this.Værdi == 3)
                return true;
            else
                return false;
        }

        public bool ErStjerne()
        {
            if (this.Værdi == 5)
                return true;
            else
                return false;
        }
    }

    class Terning
    {
        private int _værdi;

        public int Værdi
        {
            get
            {
                // Evt. logning ...
                return _værdi;
            }
            set {
                if ((value < 1) || (value > 6))
                    _værdi = 1;
                else
                    _værdi = value;
            }
        }

        private static System.Random rnd = new System.Random();

        public int Ryst()
        {
            // På denne vis 'går man igennem' get metoden i Værdi
            return Værdi = rnd.Next(1, 7);
        }

        public void Skriv()
        {
            Console.WriteLine($"[{this.Værdi}]");
        }

        public Terning()
        {
            this.Værdi = Ryst();
        }

        public Terning(int _værdi)
        {
            Værdi = _værdi;
        }
    }
}
