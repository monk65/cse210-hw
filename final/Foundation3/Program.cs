using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        Address venueAddress = new Address("400 University Blvd", "Rexburg", "ID", "USA");
        Address hallAddress = new Address("12 Grand Ave", "Boise", "ID", "USA");
        Address parkAddress = new Address("88 River Rd", "Rexburg", "ID", "USA");

        Lecture lecture = new Lecture(
            "Intro to Machine Learning",
            "A beginner-friendly talk on how machine learning works.",
            "08/12/2026",
            "6:00 PM",
            venueAddress,
            "Dr. Elena Ruiz",
            150);

        Reception reception = new Reception(
            "Alumni Welcome Reception",
            "An evening to reconnect with fellow alumni over dinner.",
            "08/20/2026",
            "7:00 PM",
            hallAddress,
            "rsvp@alumni.edu");

        OutdoorGathering picnic = new OutdoorGathering(
            "Community Summer Picnic",
            "A family-friendly picnic with games and food trucks.",
            "08/28/2026",
            "12:00 PM",
            parkAddress,
            "Sunny, high of 82 degrees");

        List<Event> events = new List<Event> { lecture, reception, picnic };

        foreach (Event e in events)
        {
            Console.WriteLine("STANDARD DETAILS");
            Console.WriteLine(e.GetStandardDetails());
            Console.WriteLine();

            Console.WriteLine("FULL DETAILS");
            Console.WriteLine(e.GetFullDetails());
            Console.WriteLine();

            Console.WriteLine("SHORT DESCRIPTION");
            Console.WriteLine(e.GetShortDescription());
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}