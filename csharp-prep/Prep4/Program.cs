using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        Console.Write("Enter number: ");
        int input = int.Parse(Console.ReadLine());

        while (input != 0)
        {
            numbers.Add(input);
            Console.Write("Enter number: ");
            input = int.Parse(Console.ReadLine());
        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");
        double average = (double)sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");
        int largest = numbers[0];
        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }
        Console.WriteLine($"The largest number is: {largest}");
    }
}