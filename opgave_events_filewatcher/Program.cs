using System;

namespace opgave_events_filewatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.FileSystemWatcher w = new System.IO.FileSystemWatcher(@"c:\temp", "*.txt");
            w.EnableRaisingEvents = true;
            // bind en metode til w.Changed
            w.Changed += ShowChanged;
            w.Created += (s, e) => { Console.WriteLine("Oprettet " + e.FullPath); };
            w.Deleted += (s, e) => Console.WriteLine("Slettet " + e.Name);
            w.Renamed += (s, e) => Console.WriteLine("Omdøbt " + e.Name);

            do
            {

            } while (true);
        }
               
        private static void ShowChanged(object sender, System.IO.FileSystemEventArgs e)
        {
            Console.WriteLine("Ændring " + e.Name);
        }
    }
}
