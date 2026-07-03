using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static List<SimpleGoal> goals = new List<SimpleGoal>();
    static int score = 0;

    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine();
            Console.WriteLine($"You have {score} points.");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Record Event");
            Console.WriteLine("  4. Save Goals");
            Console.WriteLine("  5. Load Goals");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                CreateGoal();
            }
            else if (choice == "2")
            {
                DisplayGoals();
            }
            else if (choice == "3")
            {
                RecordEvent();
            }
            else if (choice == "4")
            {
                Save();
            }
            else if (choice == "5")
            {
                Load();
            }
            else if (choice == "6")
            {
                running = false;
            }
            else
            {
                Console.WriteLine("Invalid choice, please try again.");
            }
        }
    }

    static void CreateGoal()
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string type = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
        {
            goals.Add(new SimpleGoal(name, description, points));
        }
        else if (type == "2")
        {
            goals.Add(new EternalGoal(name, description, points));
        }
        else if (type == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int totalRequired = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            goals.Add(new CheckGoal(name, description, points, bonus, totalRequired));
        }
        else
        {
            Console.WriteLine("Invalid goal type.");
        }
    }

    static void DisplayGoals()
    {
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetDisplayString()}");
        }
    }

    static void RecordEvent()
    {
        DisplayGoals();
        Console.Write("Which goal did you accomplish? ");
        int choice = int.Parse(Console.ReadLine());
        int index = choice - 1;

        if (index >= 0 && index < goals.Count)
        {
            int earned = goals[index].RecordEvent();
            score += earned;
            Console.WriteLine($"Congratulations! You have earned {earned} points!");
        }
        else
        {
            Console.WriteLine("Invalid goal selected.");
        }
    }

    static void Save()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(score);

            foreach (SimpleGoal goal in goals)
            {
                outputFile.WriteLine(goal.GetSaveString());
            }
        }
    }

    static void Load()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        goals.Clear();
        string[] lines = File.ReadAllLines(filename);
        score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(":");
            string type = parts[0];
            string[] details = parts[1].Split(",");

            if (type == "SimpleGoal")
            {
                SimpleGoal goal = new SimpleGoal(details[0], details[1], int.Parse(details[2]));
                if (bool.Parse(details[3]))
                {
                    goal.RecordEvent();
                }
                goals.Add(goal);
            }
            else if (type == "EternalGoal")
            {
                goals.Add(new EternalGoal(details[0], details[1], int.Parse(details[2])));
            }
            else if (type == "CheckGoal")
            {
                CheckGoal goal = new CheckGoal(details[0], details[1], int.Parse(details[2]), int.Parse(details[3]), int.Parse(details[5]));
                int numCompleted = int.Parse(details[4]);
                for (int j = 0; j < numCompleted; j++)
                {
                    goal.RecordEvent();
                }
                goals.Add(goal);
            }
        }
    }
}