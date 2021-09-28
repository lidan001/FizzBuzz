using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzzGame game = new FizzBuzzGame();
            var index = 1;
            foreach (var answer in game.Run())
            {
                Console.WriteLine($"Index: {index}, Answer: {answer}");
                index++;
            } 
        }
    }
}
