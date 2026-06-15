using System;
using System.Collections.Generic;
 
class Program
{
    static void Main()
    {
        string text = "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.";
        var scripture = new Scripture(text, "Proverbs", 3, new List<int> { 5, 6 });
 
        while (true)
        {
            try { Console.Clear(); } catch (IOException) {}
            scripture.Display();
            Console.WriteLine();
 
            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("All words are hidden — great work!");
                break;
            }
 
            Console.Write("Press Enter to continue or type 'quit' to exit: ");
            string input = Console.ReadLine() ?? "";
 
            if (input.Trim().ToLower() == "quit")
                break;
 
            scripture.HideWords(3);
        }
    }
}