using System;

namespace klasser_komplete_egenskaber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Opgave med Trekant med grundlinje=3 og højde=5");
            Trekant t1 = new Trekant(3, 5);
            //Console.WriteLine("Areal af trekant er: "+t1.Areal()); // Som metode
            Console.WriteLine("Areal af trekant er: " + t1.Areal);   // Som egenskab

            Console.WriteLine("");
            Console.WriteLine("Opgave med Vare");
            Vare v1 = new Vare();
            v1.Navn = "Tomat";
            v1.Pris = 10;

            Vare v2 = new Vare("Agurk", 5);

            Console.WriteLine($"Vare nr. 1 og pris m. moms: {v1.Navn} og {v1.PrisMedMoms()}");
            Console.WriteLine($"Vare nr. 2 og pris m. moms: {v2.Navn} og {v2.PrisMedMoms()}");

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

    public class Trekant
    {
        private int _grundlinje;
        private int _højde;
        
        public Trekant (int grundlinje, int højde)
        {
            this._grundlinje = grundlinje;
            this._højde = højde;
        }

        // Som metode ?
        //public double Areal ()
        //{
        //    return _grundlinje * _højde * 0.5;
        //}

        // Som egenskab?
        public double Areal
        {
            get
            {
                return _grundlinje * _højde * 0.5;
            }
        }
       
        public int Grundlinje
        {
            get; private set;
            //get { return _grundlinje; }
            //private set { _grundlinje = value; }
        }

        public int Højde
        {
            get; private set;
            //get { return _højde; }
            //private set { _højde = value; }
        }


    }

    public class Vare
    {
        public Vare()
        {

        }
        public Vare(string navn, double pris)
        {
            this._pris = pris;
            this._navn = navn;
        }

        private string _navn;
        private double _pris;

        public string Navn
        {
            get {
                Console.WriteLine("Nu aflæses navn");
                return _navn;
            }
            set {
                Console.WriteLine("Nu tildeles navn");
                _navn = value;
            }
        }

        public double Pris
        {
            get {
                Console.WriteLine("Nu aflæses pris");
                return _pris;
            }
            set {
                Console.WriteLine("Nu tildeles pris");
                _pris = value;
            }
        }

        public double PrisMedMoms()
        {
            return this._pris * 1.25;
        }
    }
}
