using System;

namespace opgave_arv
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Opgave med arv - exception");
            try
            {
                StockItem s = new StockItem(-1);

            }
            catch (StockItemException ex)
            {
                Console.WriteLine("StockItem Error : " + ex.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("General Error");
            }

            Console.WriteLine();
            Console.WriteLine("Opgave med arv - udvid System.Random");
            UdvidetRandom r = new UdvidetRandom();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(r.NextBool()); // true eller false
            }
            
            Console.WriteLine();
            Console.WriteLine("Opgave med arv - simpel");
            Person p1 = new Person();
            p1.Fornavn = "Nicholas";
            p1.Efternavn = "Schott";

            Person p2 = new Person() { Fornavn = "Christoffer", Efternavn = "Schott" };

            Console.WriteLine("Første person er "+p1.FuldtNavn());
            Console.WriteLine("Anden person er  "+p2.FuldtNavn());

            Elev e1 = new Elev() { Fornavn = "Elev1", Efternavn = "ElevEfternavn1", Klasselokale = "Astralis" };
            Instruktør i1 = new Instruktør() { Fornavn = "Instruktør1", Efternavn = "InsturktørEfternavn1", NøgleId = 1 };

            Console.WriteLine("Første elev er   "+e1.FuldtNavn());
            Console.WriteLine("Første instruktør er " + i1.FuldtNavn());
                       
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        public class StockItemException : Exception
        {
            public StockItemException(string message) : base(message)
            {

            }
        }
        class StockItem
        {
            public int ID { get; set; }

            public StockItem(int id)
            {
                if (id < 0)
                    throw new StockItemException ("Wrong id");
                else
                    this.ID = id;
            }
        }

        class UdvidetRandom : System.Random
        {
            public bool NextBool()
            {
                return this.Next(1, 1002) < 501;
            }
        }

        class Elev : Person
        {
            public string Klasselokale { get; set; }

        }

        class Instruktør : Person
        {
            public int NøgleId { get; set; }
        }

        class Person
        {
            public string Fornavn { get; set; } 
            public string Efternavn { get; set; }

            public string FuldtNavn ()
            {
                return this.Fornavn + " " + this.Efternavn;
            }
        }
    }
}
