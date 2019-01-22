using System;
using System.Collections.Generic;

namespace samlinger
{
    class Bunke
    {
        private Stack<Kort> _bunke = new Stack<Kort>();
             
        public void TilføjKort(Kort kort)
        {
            _bunke.Push(kort);
        }
        
        public Kort FjernKort()
        {
            return _bunke.Pop();
        }

        public void Vis()
        {
            foreach (Kort item in _bunke)
            {
                Console.WriteLine($"Kulør og værdi: {item.Kulør} og {item.Værdi}");
            }
}

        public Bunke()
        {

        }
    }
}