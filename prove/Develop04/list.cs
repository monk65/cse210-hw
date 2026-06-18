using System;
using System.Collections.Generic;

public class Listing : Activity
{
    private List<string> _prompts;

    public Listing(List<string> prompts, double duration)
        : base(
            "Listing Activity",
            "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",
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
        Console.WriteLine("You will begin listing items in...");
        Animate(5);

        Console.WriteLine();
        Console.WriteLine("Start listing items, pressing Enter after each one.");
        Console.WriteLine();

        DateTime endTime = GetEndTime();
        int itemCount = 0;

        while (DateTime.Now < endTime)
        {
            string item = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(item))
            {
                itemCount++;
            }
        }

        Console.WriteLine();
        Console.WriteLine($"You listed {itemCount} items!");

        End();
    }
}