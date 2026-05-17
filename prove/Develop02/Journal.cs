public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public static List<string> _prompts = new List<string>
    {
        "What was the best part of my day?",
        "What drained my energy today?",
        "What am I grateful for??",
        "Did I do something kind for someone?",
        "What challenged me, and how did I handle it?",
        "What am I feeling right now, and why?",
        "Who or what made me smile today?"
    };

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void Display()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries yet.");
            return;
        }

        Console.WriteLine($"\n--- Journal ({_entries.Count} entries) ---");
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveJournal(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry e in _entries)
            {
                outputFile.WriteLine($"{e._date}|{e._prompt}|{e._response}");
            }
        }
        Console.WriteLine($"Journal saved to '{file}'.");
    }

    public void LoadJournal(string file)
    {
        _entries.Clear();
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            Entry entry = new Entry();
            entry._date     = parts[0];
            entry._prompt   = parts[1];
            entry._response = parts[2];

            _entries.Add(entry);
        }
        Console.WriteLine($"Loaded {_entries.Count} entries from '{file}'.");
    }
}