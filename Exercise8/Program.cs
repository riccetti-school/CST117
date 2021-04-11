using System;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"If I have 9 fat grams I have {FatCalories(9)} calories..");
            Console.WriteLine($"If I have 12 carbs I have {CarbCalories(12)} calories");
        }

        static double FatCalories(double fatGrams)
        {
            return (fatGrams * 9);
        }

        static double CarbCalories(double carbs)
        {
            return (carbs * 4);
        }
    }
}
