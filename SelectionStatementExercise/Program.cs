using System;
using System.ComponentModel.Design;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 1000);
            favNumber = 25;
            Console.WriteLine("Guess My Favorite Number (Guess any number from 1 to 1000)");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            {
                Console.WriteLine($"Too Low");
            }

            else if (userInput > favNumber)
            {
                Console.WriteLine($"Too High");
            }

            else
            {
                Console.WriteLine($"You guessed it!");
            }

        }
    }
}

