using System;

namespace indkapsling_egenskaber
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Console.WriteLine("Indtast fornavn");
            p1.Fornavn = Console.ReadLine();
            Console.WriteLine("Indtast efternavn");
            p1.Efternavn = Console.ReadLine();
            Console.WriteLine($"Indtastet navn er: {p1.FuldtNavn}");

            

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

    public class Person
    {
        public string Fornavn { get; set; }
        private string _efternavn;

        public string Efternavn
        {
            get {
                return _efternavn;
            }
            set {
                if (value.Length <= 3)
                    _efternavn = "";
                else
                    _efternavn = value;
            }
        }

        public string FuldtNavn
        {
            get
            {
                return Fornavn + " " + Efternavn;
            }
        }
    }
}
