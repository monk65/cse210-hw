using System;
using System.Threading;

public abstract class Activity
{
    protected string _name;
    protected string _instruction;
    protected double _duration;

    public Activity(string name, string instruction, double duration)
    {
        _name = name;
        _instruction = instruction;
        _duration = duration;
    }

    protected void Start()
    {
        Console.Clear();
        Console.WriteLine($"--- {_name} ---");
        Console.WriteLine();
        Console.WriteLine(_instruction);
        Console.WriteLine();
        Console.WriteLine("Get ready...");
        Animate(3);
    }

    protected void End()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!");
        Animate(3);
        Console.WriteLine();
        Console.WriteLine($"You have completed the {_name} for {_duration} seconds.");
        Animate(3);
    }

    protected void Animate(double seconds)
    {
        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            Console.Write(".");
            Thread.Sleep(500);
        }

        Console.WriteLine();
    }

    protected DateTime GetEndTime()
    {
        return DateTime.Now.AddSeconds(_duration);
    }
}
