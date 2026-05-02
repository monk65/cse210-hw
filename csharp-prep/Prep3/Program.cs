using System;

class Program
{
    static void Main(string[] args)
    {
    Random randomGenerator = new Random();
int mNumber = randomGenerator.Next(1, 101);

int guess;

do
{    
    Console.Write("What is your guess? ");
    guess = int.Parse(Console.ReadLine());

    if (guess < mNumber)
    {
        Console.WriteLine("Higher");
    }
    else if (guess > mNumber)
    {
        Console.WriteLine("Lower");
    }
    else
    {
        Console.WriteLine("You guessed the magic number!");
    }
} while (guess != mNumber);
    }
}