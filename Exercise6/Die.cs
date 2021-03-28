using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    public class Die
    {
        private int _sides = 6;

        public int Rolls { get; set; } = 0;

        public Die(int sides)
        {
            _sides = sides;
        }

        public void rollDie()
        {
            Random rnd = new Random((int)DateTime.Now.Ticks);
            var t = rnd.Next(1, _sides + 1);
            while (t != 1)
            {
                Rolls++;
                t = rnd.Next(_sides);
                Console.WriteLine($"Roll: {Rolls} == {t}");
                System.Threading.Thread.Yield();
            }

            Console.WriteLine($"We have a 1!!");

        }

    }
}
