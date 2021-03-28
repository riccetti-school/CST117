using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            // we need two dice
            var die1 = new Die(6);
            var die2 = new Die(6);

            die1.rollDie();
            die2.rollDie();

            var total = die1.Rolls + die2.Rolls;

            Console.WriteLine($"It took {total} rolls to get snake eyes");
        }
    }
}
