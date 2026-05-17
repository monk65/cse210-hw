using System;

class Program
{
    static void Main(string[] args)
    {
        Journal j = new Journal();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n=== Journal Menu ===");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Random random = new Random();
                    string prompt = Journal._prompts[random.Next(Journal._prompts.Count)];
                    Console.WriteLine($"\nPrompt: {prompt}");
                    Console.Write("> ");
                    string response = Console.ReadLine();

                    Entry e = new Entry();
                    e._prompt   = prompt;
                    e._response = response;
                    e._date     = DateTime.Now.ToShortDateString();

                    j.AddEntry(e);
                    Console.WriteLine("Entry saved!");
                    break;
                case "2":
                    j.Display();
                    break;
                case "3":
                    Console.Write("Enter filename to save: ");
                    j.SaveJournal(Console.ReadLine());
                    break;
                case "4":
                    Console.Write("Enter filename to load: ");
                    j.LoadJournal(Console.ReadLine());
                    break;
                case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}