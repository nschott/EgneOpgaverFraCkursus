using System;

namespace opgave_strenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string fornavn = "Mikkel";
            string efternavn = "Cronberg";
            string samletNavn = fornavn + " " + efternavn;
            Console.WriteLine(samletNavn);

            string navnStort = samletNavn.ToUpper();
            Console.WriteLine(navnStort);

            string navnLille = samletNavn.ToLower();
            Console.WriteLine(navnLille);

            string uddrag = samletNavn.Substring(7, 4);
            Console.WriteLine(uddrag);

            string sti = "c:\\git";
            string filnavn = "test.txt";
            Console.WriteLine(sti);

            System.IO.File.WriteAllText(sti+@"\"+filnavn, fornavn);


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
