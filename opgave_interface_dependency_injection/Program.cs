using System;

namespace opgave_interface_dependency_injection
{
    class Program
    {
        static void Main(string[] args)
        {
            ITilfældighedsGenerator m = new TilfældighedsGeneratorMock(1);
            Console.WriteLine(m.FindTalTilTerning());
            ITilfældighedsGenerator f = new TilfældighedsGeneratorFramework();
            Console.WriteLine(f.FindTalTilTerning());

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
        private int _tal;

        public int Tal
        {
            get { return _tal; }
            set { _tal = rnd.Next(1,7); }
        }
                

        public int FindTalTilTerning()
        {
            return Tal;
        }
    }

    class TilfældighedsGeneratorMock : ITilfældighedsGenerator
    {
        private int _tal;
        public TilfældighedsGeneratorMock(int tal)
        {
            _tal = tal;
           
        }

        public int FindTalTilTerning()
        {
            return _tal;
        }
    }
}
