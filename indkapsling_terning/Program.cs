using System;

namespace indkapsling_terning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Opgave Egenskaber (Terning)");
            Terning t1 = new Terning();

            for (int i = 0; i < 21; i++)
            {
               t1.Ryst();
               Console.WriteLine("Terning kast giver: "+t1.Skriv());
            }

            Console.WriteLine("Ny terning med initiel værdi = 3");
            Terning t2 = new Terning(3);
            Console.WriteLine("Terning har fået værdi "+t2.Skriv());

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

    public class Terning
    {
        private int _værdi;
        private static System.Random rnd;

        // Default constructor
        public Terning()
        {
            rnd = new Random();
            Ryst();
        }

        public int Værdi
        {
            get { return _værdi; }
            private set {
                if ((value < 1) || (value > 6))
                    _værdi = 1;
                else
                    _værdi = value;
            }
        }

        // Custom constructor
        public Terning(int værdi)
        {
            Værdi = værdi;
        }

        public void Ryst()
        {
            Værdi = rnd.Next(1, 15);
        }

        public string Skriv()
        {
            return "[" + _værdi + "]";
        }
    }
}
