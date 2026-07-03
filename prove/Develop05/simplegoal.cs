using System;

public class SimpleGoal
{
    protected string _title;
    protected string _description;
    protected int _points;
    protected bool _completed;

    public SimpleGoal(string title, string description, int points)
    {
        _title = title;
        _description = description;
        _points = points;
        _completed = false;
    }

    public string GetTitle()
    {
        return _title;
    }

    public virtual int RecordEvent()
    {
        _completed = true;
        return _points;
    }

    public virtual bool IsComplete()
    {
        return _completed;
    }

    public virtual string GetDisplayString()
    {
        string mark = _completed ? "[X]" : "[ ]";
        return $"{mark} {_title} ({_description})";
    }

    public virtual string GetSaveString()
    {
        return $"SimpleGoal:{_title},{_description},{_points},{_completed}";
    }
}