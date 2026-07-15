using System;

public class Swimming : Activity
{
    private int _numberOfLaps;

    public Swimming(DateTime date, int lengthMinutes, int numberOfLaps)
        : base(date, lengthMinutes)
    {
        _numberOfLaps = numberOfLaps;
    }

    public override double GetDistance()
    {
        return (_numberOfLaps * 50 / 1000.0) * 0.62;
    }
}