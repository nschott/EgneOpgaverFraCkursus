using System;
using System.Collections.Generic;

namespace samlinger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Opgave med stack");

            Bunke b = new Bunke();
            b.TilføjKort(new Kort() { Kulør = "Spar", Værdi = 2 });
            b.TilføjKort(new Kort() { Kulør = "Hjerter", Værdi = 14 });
            b.TilføjKort(new Kort() { Kulør = "Ruder", Værdi = 3 });
            b.Vis();

            var k = b.FjernKort();
            Console.WriteLine();
            Console.WriteLine(k);
            Console.WriteLine();

            b.Vis();

            Console.WriteLine("Opgave med list og dictionary");
            List<Person> personRegister = new List<Person>();
            //Person p1 = new Person();
            //p1.Id = 17;
            //p1.Navn = "Første person";

            //Person p2 = new Person();
            //p2.Id = 12;
            //p2.Navn = "Anden person";

            //Person p3 = new Person();
            //p3.Id = 3;
            //p3.Navn = "Tredje person";

            //personRegister.Add(p1);
            //personRegister.Add(p2);
            //personRegister.Add(p3);


            personRegister.Add(new Person() { Id = 1, Navn = "Første person" });
            personRegister.Add(new Person() { Id = 2, Navn = "Anden person" });
            personRegister.Add(new Person() { Id = 3, Navn = "Tredje person" });

            foreach (Person item in personRegister)
            {
                Console.WriteLine($"Person Id og Navn: {item.Id} og {item.Navn}");
            }

            Dictionary<int, Person> lst = new Dictionary<int, Person>();
            lst.Add(1, personRegister[0]);
            lst.Add(2, personRegister[1]);
            lst.Add(3, personRegister[2]);
            if (lst.ContainsKey(2))
                Console.WriteLine(lst[2].Navn);

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

    public class Kort
    {
        public string Kulør { get; set; }
        public int Værdi { get; set; }
        public override string ToString()
        {
            return this.Kulør + " " + this.Værdi;
        }
    }
    class Person
    {
        public int Id { get; set; }
        public string Navn { get; set; }
    }
}
