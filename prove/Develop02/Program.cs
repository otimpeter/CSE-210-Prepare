using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
    }
    
    class Journal
{
    public List<Entry> Entries { get; set; }

    public Journal()
    {
        Entries = new List<Entry>();
    }

    public void WriteNewEntry(string prompt)
    {
        Console.WriteLine("Please respond to the following prompt: " + prompt);
        string response = Console.ReadLine();

        Entry newEntry = new Entry
        {
            Prompt = prompt,
            Response = response,
            Date = DateTime.Now.ToString("MM/dd/yyyy")
        };

        Entries.Add(newEntry);
    }

    public void DisplayJournal()
    {
        if (Entries.Count == 0)
        {
            Console.WriteLine("No entries in the journal.");
            return;
        }

        foreach (Entry entry in Entries)
        {
            Console.WriteLine("Prompt: " + entry.Prompt);
            Console.WriteLine("Response: " + entry.Response);
            Console.WriteLine("Date: " + entry.Date);
            Console.WriteLine();
        }
    }

    public void SaveJournal(string fileName)
    {
        string separator = "~|~";

        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (Entry entry in Entries)
            {
                writer.WriteLine(entry.Prompt + separator + entry.Response + separator + entry.Date);
            }
        }
    }
    public void LoadJournal(string fileName)
    {
        Entries.Clear();

        string separator = "~|~";

        using (StreamReader reader = new StreamReader(fileName))
        {
            while (!reader.EndOfStream)
            {
                string[] line = reader.ReadLine().Split(separator);

                Entry entry = new Entry
                {
                    Prompt = line[0],
                    Response = line[1],
                    Date = line[2]
                };

                Entries.Add(entry);
            }
        }
    }
}
class Entry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public string Date { get; set; }
}
class Programs
{
    static List<string> prompts = new List<string>() {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    static Journal journal = new Journal();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");

        }
    }
  }
}
