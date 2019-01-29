using System;

namespace opgave_interface_dependency_injection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find tal til terning uden dependency injection");
            ITilfældighedsGenerator m = new TilfældighedsGeneratorMock(1);
            Console.WriteLine(m.FindTalTilTerning());
            ITilfældighedsGenerator f = new TilfældighedsGeneratorFramework();
            Console.WriteLine(f.FindTalTilTerning());

            Console.WriteLine();
            Console.WriteLine("Fin tal til terning MED dependency injection");
            TilfældighedsGeneratorFramework f1 = new TilfældighedsGeneratorFramework();
            Terning t1 = new Terning(f1);
            Console.WriteLine(t1.Værdi);

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

    interface ITilfældighedsGenerator
    {
        int FindTalTilTerning();
    }

    class TilfældighedsGeneratorFramework : ITilfældighedsGenerator
    {
        private static System.Random rnd = new Random();
        public int Tal { get; set; }
        
        public int FindTalTilTerning()
        {
            Tal = rnd.Next(1, 7);
            return Tal;
        }
    }

    class TilfældighedsGeneratorMock : ITilfældighedsGenerator
    {
        public int Tal { get; set; }
        public TilfældighedsGeneratorMock(int tal)
        {
            Tal = tal;
        }

        public int FindTalTilTerning()
        {
            return Tal;
        }
    }

    class Terning : ITilfældighedsGenerator
    {
        public int Værdi { get; set; }

        private ITilfældighedsGenerator generator;
        
                
        public Terning(ITilfældighedsGenerator rnd)
        {
            generator = rnd;
            Ryst();
        }

        public void Ryst ()
        {
            this.Værdi = generator.FindTalTilTerning();
        }

        public int FindTalTilTerning()
        {
            throw new NotImplementedException();
        }
    }
}
