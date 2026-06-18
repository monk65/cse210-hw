using System;
using System.Collections.Generic;

public class Reflection : Activity
{
    private List<string> _prompts;

    private static readonly List<string> Questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public Reflection(List<string> prompts, double duration)
        : base(
            "Reflection Activity",
            "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",
            duration)
    {
        _prompts = prompts;
    }

    public void Begin()
    {
        Start();

        Random random = new Random();
        Console.WriteLine();
        Console.WriteLine(_prompts[random.Next(_prompts.Count)]);
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press Enter to continue.");
        Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Animate(3);

        DateTime endTime = GetEndTime();

        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            Console.WriteLine(Questions[random.Next(Questions.Count)]);
            Animate(5);
        }

        End();
    }
}