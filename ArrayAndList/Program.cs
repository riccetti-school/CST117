using System;
using System.Collections.Generic;

namespace ArrayAndList
{
    class Program
    {
        static void Main(string[] args)
        {
            pnt[,] grid = new pnt[10,10];
            // monsters
            var monsters = new List<monster>();

            // add the first monster
            monsters.Add(new monster());

            var runtime = 5000;
            var c = 0;

            while (true)
            {
                c++;
                if (c > runtime)
                    break;
                monsters.RemoveAll(c => !c.Alive);

                System.Threading.Thread.Sleep(2000);
                monsters.Add(new monster());
            }
        }
    }

    public class pnt
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class monster
    {
        public string Name { get; set; }
        public bool Alive { get; set; }
    }
}
