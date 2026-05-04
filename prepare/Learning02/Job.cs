using System;
public class Job
{
    public String _company ="";
    public string _jobTitle = "";
    public int _startYear = 0;
    public int _endYear = 0;
    public Job()
    {}
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}