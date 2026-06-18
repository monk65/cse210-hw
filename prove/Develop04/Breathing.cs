using System;

public class Breathing : Activity
{
    public Breathing(double duration)
        : base(
            "Breathing Activity",
            "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.",
            duration)
    {
    }

    public void Begin()
    {
        Start();

        DateTime endTime = GetEndTime();
        bool breatheIn = true;

        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            Console.WriteLine(breatheIn ? "Breathe in..." : "Breathe out...");
            Animate(4);

            breatheIn = !breatheIn;
        }

        End();
    }
}
