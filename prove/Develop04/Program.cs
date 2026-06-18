using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        List<string> reflectionPrompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        List<string> listingPrompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        bool keepRunning = true;

        while (keepRunning)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine();
            Console.WriteLine("1) Breathing Activity");
            Console.WriteLine("2) Reflection Activity");
            Console.WriteLine("3) Listing Activity");
            Console.WriteLine("4) Quit");
            Console.WriteLine();
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    double breathingDuration = PromptForDuration();
                    Breathing breathing = new Breathing(breathingDuration);
                    breathing.Begin();
                    WaitForEnter();
                    break;
                case "2":
                    double reflectionDuration = PromptForDuration();
                    Reflection reflection = new Reflection(reflectionPrompts, reflectionDuration);
                    reflection.Begin();
                    WaitForEnter();
                    break;
                case "3":
                    double listingDuration = PromptForDuration();
                    Listing listing = new Listing(listingPrompts, listingDuration);
                    listing.Begin();
                    WaitForEnter();
                    break;
                case "4":
                    keepRunning = false;
                    break;
                default:
                    Console.WriteLine("That is not a valid choice. Press Enter to try again.");
                    Console.ReadLine();
                    break;
            }
        }

        Console.WriteLine("Thank you for taking time to be mindful today!");
    }

    private static double PromptForDuration()
    {
        double seconds = 0;
        bool isValid = false;

        while (!isValid)
        {
            Console.Write("How long, in seconds, would you like for your session? ");
            string input = Console.ReadLine();

            if (double.TryParse(input, out seconds) && seconds > 0)
            {
                isValid = true;
            }
            else
            {
                Console.WriteLine("Please enter a number greater than 0.");
            }
        }

        return seconds;
    }

    private static void WaitForEnter()
    {
        Console.WriteLine();
        Console.WriteLine("Press Enter to return to the menu.");
        Console.ReadLine();
    }
}