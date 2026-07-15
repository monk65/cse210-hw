using System;

public class OutdoorGathering : Event
{
    private string _weatherForecast;

    public OutdoorGathering(string title, string description, string date, string time, Address address,
        string weatherForecast)
        : base(title, description, date, time, address)
    {
        _weatherForecast = weatherForecast;
    }

    public override string GetFullDetails()
    {
        string details = base.GetFullDetails();
        details += $"\nExpected Weather: {_weatherForecast}";
        return details;
    }
}