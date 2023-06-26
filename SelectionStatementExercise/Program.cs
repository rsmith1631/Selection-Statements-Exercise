namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guest the number that I'm thinking of!");

            var myNumber = 25;

            var userGuess = int.Parse(Console.ReadLine());

            if (userGuess < myNumber)
            {
                Console.Write($"Wrong! The number I'm thinking of is higher.");
            }
            else if (userGuess > myNumber)
            {
                Console.WriteLine($"Incorrect! The number that I'm thinking of is lower.");
            }
            
            else 
            {
                Console.WriteLine($"Correct! You guessed 25. That's exactly the number I was thinking of.");
            }
        }
    }
}
