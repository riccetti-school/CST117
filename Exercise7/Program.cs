using System;
using System.Collections.Generic;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        static int SumNumbers(int first, int second)
        {
            return (first + second);
        }

        static double AverageNumbers(double first, double second, double third, double fourth, double filth)
        {
            return (first + second + third + fourth + filth) / 5;
        }

        static int RandomSum()
        {
            Random random = new Random((int)DateTime.Now.Ticks);

            return (random.Next() + random.Next());
        }

        static bool DivisiableByThree(int first, int second, int third)
        {
            var t = first + second + third;
            return t % 3 == 0;
        }

        static string FewerCharacters(string first, string second)
        {
            if (first.Length < second.Length)
                return first;
            return second;
        }

        static double GetLargest(double[] list)
        {
            if (list.Length < 1)
                return 0;

            double j = 0;

            foreach(var i in list)
            {
                if (i > j)
                    j = i;
            }

            return j;
        }
    }
}
