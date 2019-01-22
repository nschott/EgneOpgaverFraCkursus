using System;

namespace klasser_terning
{
    public class Terning
    {
        public int Value;
        private bool Cheat;

        private static Random rnd = new Random();

        public void Show()
        {
            Console.WriteLine($"[{this.Value}]");
        }

        public void Throw()
        {
            if (this.Cheat == false)
                this.Value = rnd.Next(1, 7);
            else
                this.Value = 6;
        }

        public Terning()
        {
            this.Value = 1;
            this.Cheat = false;
        }

        public Terning(bool setCheat)
        {
            this.Value = 1;
            this.Cheat = setCheat;
        }
    }
}
