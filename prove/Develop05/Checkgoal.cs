using System;

public class CheckGoal : SimpleGoal
{
    private int _bonus;
    private int _numCompleted;
    private int _totalRequired;

    public CheckGoal(string title, string description, int points, int bonus, int totalRequired)
        : base(title, description, points)
    {
        _bonus = bonus;
        _totalRequired = totalRequired;
        _numCompleted = 0;
    }

    public override int RecordEvent()
    {
        if (_numCompleted >= _totalRequired)
        {
            return 0;
        }

        _numCompleted++;
        int earned = _points;

        if (_numCompleted == _totalRequired)
        {
            _completed = true;
            earned += _bonus;
        }

        return earned;
    }

    public override bool IsComplete()
    {
        return _completed;
    }

    public override string GetDisplayString()
    {
        string mark = _completed ? "[X]" : "[ ]";
        return $"{mark} {_title} ({_description}) -- Completed {_numCompleted}/{_totalRequired} times";
    }

    public override string GetSaveString()
    {
        return $"CheckGoal:{_title},{_description},{_points},{_bonus},{_numCompleted},{_totalRequired}";
    }
}