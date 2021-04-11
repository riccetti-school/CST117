using System;
using System.IO;
using System.Linq;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            var textFileData = File.ReadAllText("data.txt");
            var words = textFileData.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);


            var count = 0;

            // check each word if then end in t or e
            foreach(var word in words)
            {
                if (word.ToCharArray().Last() == 't' || word.ToCharArray().Last() == 'e')
                    count++;
            }

            Console.WriteLine($"There are {6} words that end in a t or e");
        }
    }
}
