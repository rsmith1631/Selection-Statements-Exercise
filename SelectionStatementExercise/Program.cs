namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's my favorite number?");

            var myNumber = 34;
            var userInput = int.Parse(Console.ReadLine());


            if (userInput < myNumber)
            {
                Console.WriteLine($"No. That number is too low!");
            }
            else if (userInput > myNumber)
            {
                Console.WriteLine($"No. Your number is too high!");
            }
            else
            {
                Console.WriteLine($"That's the correct guess. Good Job!");
            }
        }
    }
}
