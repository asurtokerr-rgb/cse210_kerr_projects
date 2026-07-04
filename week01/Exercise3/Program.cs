using System;
using System.Formats.Asn1;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        string answer = "";
        do
        {
            Random randomGenerator = new Random();

            int number = randomGenerator.Next(1, 20);
            int guessNumber = 0;
            int numberOfGuess = 0;
            do
            {
                Console.WriteLine("What is your guess number?");
                guessNumber = int.Parse(Console.ReadLine());
                numberOfGuess += 1;
                if (guessNumber < number)
                {
                    Console.WriteLine("Higher");
                }
                else if (guessNumber > number)
                {
                    Console.WriteLine("Lower");
                }
            } while (guessNumber != number);
            Console.WriteLine("You guessed it!");
            Console.WriteLine($"You got it right in {numberOfGuess} guesses");
            Console.WriteLine("Do you want to play again?");
            answer = Console.ReadLine();
        } while (answer == "yes");
        Console.WriteLine("Bye!");


    }
}