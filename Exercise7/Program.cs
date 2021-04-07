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

        static int[] Return50()
        {
            int[] k = new int[50];
            for(int i=0;i<50;i++)
            {
                k[i] = i;
            }
            return k;
        }

        static bool Same(bool first, bool second)
        {
            return first && second;
        }

        static double Product(int first, double second)
        {
            return (double)(first + second);
        }

        static int TwoAverage(int[][] value)
        {
            int a = 0;
            int v = value.GetLength(0);
            int b = value.GetLength(1);
            for (int x = 0; x < v; x++)
                for (int y = 0; y < b; y++)
                    a += value[x][y];
            return (a) / (v + b);
        }
    }
}
