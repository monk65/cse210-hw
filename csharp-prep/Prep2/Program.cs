using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade:");
        string num = Console.ReadLine();
        string letter = "F";
        int grade = int.Parse(num);
        if (grade >= 90)
        {
           letter = "A";
        }
        else if (grade >= 80 && grade < 90 )
        {
            letter = "B";
        }
        else if (grade >= 70 && grade < 80 )
        {
            letter = "C";
        }
        else if (grade >= 60 && grade < 70 )
        {
            letter = "D";
        }
        else if (grade < 60)
        {
            letter = "F";
        }
        else
        {
            Console.WriteLine("Your grade is undefined");
        }
        if (grade >= 70)
        {
            Console.WriteLine($"You passed the class with a {letter} with a {grade}%");
        }
        else
            Console.WriteLine($"You Failed the class with a {letter} with a {grade}% ");
    }  
}