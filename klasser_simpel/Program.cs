using System;

namespace klasser_simpel
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Person p2 = new Person("Nicholas", "Schott", 1967);

            Console.WriteLine("Test af klasser og constructor");
            Console.WriteLine("Indtast fornavn for person 1");
            string fornavn = Console.ReadLine();
            Console.WriteLine("Indtast efternavn for person 1");
            string efternavn = Console.ReadLine();
            Console.WriteLine("Indtast fødselsår for person 1");
            string alder = Console.ReadLine();
            p1.Fornavn = fornavn;
            p1.Efternavn = efternavn;
            p1.Fødselsår = Convert.ToInt32(alder);

            Console.WriteLine($"P1 Navn og estimeret alder: {p1.FuldtNavn()} og {p1.EstimeretAlder()}");
            Console.WriteLine($"P2 Navn og estimeret alder: {p2.FuldtNavn()} og {p2.EstimeretAlder()}");
            
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

    public class Person
    {
        public string Fornavn;
        public string Efternavn;
        public int Fødselsår;

        // Default constructor
        public Person()
        {
            this.Fornavn = "";
            this.Efternavn = "";
        }

        // Custom constructor
        public Person(string fornavn, string efternavn, int fødselsår)
        {
            this.Fornavn = fornavn;
            this.Efternavn = efternavn;
            this.Fødselsår = fødselsår;
        }

        public string FuldtNavn()
        {
            string tmpFornavn = "";
            string tmpEfternavn = "";

            if (this.Fornavn == "")
                tmpFornavn = "<tomt>";
            else
                tmpFornavn = this.Fornavn;
            if (this.Efternavn == "")
                tmpEfternavn = "<tomt>";
            else
                tmpEfternavn = this.Efternavn;
            return tmpFornavn + " " + tmpEfternavn;
        }

        public int EstimeretAlder()
        {
            return DateTime.Now.Year - this.Fødselsår;
        }
    }
}
