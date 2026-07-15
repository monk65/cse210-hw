using System;

public abstract class Activity
{
    private DateTime _date;
    private int _lengthMinutes;

    public Activity(DateTime date, int lengthMinutes)
    {
        _date = date;
        _lengthMinutes = lengthMinutes;
    }

    public virtual double GetDistance()
    {
        return GetSpeed() * _lengthMinutes / 60;
    }

    public virtual double GetSpeed()
    {
        return (GetDistance() / _lengthMinutes) * 60;
    }

    public virtual double GetPace()
    {
        return _lengthMinutes / GetDistance();
    }

    public string GetSummary()
    {
        string type = GetType().Name;
        return $"{_date:dd MMM yyyy} {type} ({_lengthMinutes} min) - " +
               $"Distance {GetDistance():0.0} miles, Speed {GetSpeed():0.0} mph, " +
               $"Pace: {GetPace():0.0} min per mile";
    }
}