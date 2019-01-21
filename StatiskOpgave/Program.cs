using System;

namespace StatiskOpgave
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Navn = "Nicholas";
            p.Alder = 51;
            p.Udskriv();
            bool res = Person.ValiderCpr("1234560123");

            //Statisk
            string fileName = Console.ReadLine();
            string filePath = "c:\\temp\\";
            bool t = System.IO.File.Exists(filePath + @fileName);
            if (t == true) {
                Console.WriteLine("Filen eksisterer");
                Console.WriteLine(System.IO.File.ReadAllText(filePath + fileName));
                //Instans
                var nyFil = new System.IO.FileInfo(filePath + fileName);
                Console.WriteLine($"Sidst ændret: {nyFil.LastAccessTime}");
                Console.WriteLine($"Extension er: {nyFil.Extension}");
            }
            else
                Console.WriteLine("Filen findes IKKE");

            //Instans
            //System.IO.FileInfo f = new System.IO.FileInfo("c:\temp\tmp.txt");
            //f.Delete();
            
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

    struct Person
    {
        public string Navn;
        public int Alder;

        // Instans metode
        public void Udskriv()
        {
            Console.WriteLine($"Jeg hedder {this.Navn} og er {Alder} gammel");
        }

        // Statisk metode
        public static bool ValiderCpr(string cpr)
        {
            return true;
        }

    }
}
