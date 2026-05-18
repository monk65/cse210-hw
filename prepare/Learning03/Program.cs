using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());

        Console.WriteLine();
        Random random = new Random();
        Fraction f = new Fraction();

        for (int i = 0; i < 20; i++)
        {
            f.SetTop(random.Next(1, 11));
            f.SetBottom(random.Next(1, 11));
            Console.WriteLine($"Fraction {i + 1}: string: {f.GetFractionString()} Number: {f.GetDecimalValue()}");
        }

    }
}