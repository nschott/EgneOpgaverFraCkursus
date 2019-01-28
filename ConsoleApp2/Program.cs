using System;

namespace StartDag5
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Collections.Generic.List<B> lst;
            lst = new System.Collections.Generic.List<B>();
            lst.Add(new B());

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }



    struct A
    {

    }

    class B
    {
        // ofentligt felt
        public int A; // nej tak!!

        // privat felt
        private int c;

        // Komplet egenskab
        public int C
        {
            get
            {
                // validering
                // sikkerhed
                // log
                return this.c;
            }
            set
            {
                this.c = value;
            }
        }

        // public int D { get; set; }
    }
}
