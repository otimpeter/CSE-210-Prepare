// The journal program
using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static Journal journal = new Journal();
    static List<string> prompts = new List<string>()
    {
        "Who was the most interesting person you interacted with today?",
        "What was the best part of your day?",
        "How did you see the hand of the Lord in your life today?",
        "What was the strongest emotion you felt today?",
        "If you had one thing you could do over today, what would it be?"
    };

    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("1. New Entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Save Journal to a File");
            Console.WriteLine("4. Load Journal from a File");
            Console.WriteLine("5. Exit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    NewEntry();
                    break;
                case 2:
                    DisplayJournal();
                    break;
                case 3:
                    SaveJournal();
                    break;
                case 4:
                    LoadJournal();
                    break;
                case 5:
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please choose a number between 1 and 5.");
                    break;
            }
        }
    }

    static void NewEntry()
    {
        int index = new Random().Next(prompts.Count);
        string prompt = prompts[index];

        Console.WriteLine(prompt);
        string response = Console.ReadLine();

        Entry entry = new Entry(prompt, response, DateTime.Now);
        journal.AddEntry(entry);
    }

    static void DisplayJournal()
    {
        if (journal.IsEmpty())
        {
            Console.WriteLine("Journal is empty.");
        }
        else
        {
            journal.DisplayEntries();
        }
    }

    static void SaveJournal()
    {
        Console.WriteLine("Enter a file name to save the journal:");
        string fileName = Console.ReadLine();

        journal.SaveEntries(fileName);
        Console.WriteLine("Journal saved to " + fileName);
    }

    static void LoadJournal()
    {
        Console.WriteLine("Enter a file name to load the journal:");
        string fileName = Console.ReadLine();

        journal.LoadEntries(fileName);
    }
}

class Journal
{
    private List<Entry> entries = new List<Entry>();

    public bool IsEmpty()
    {
        return entries.Count == 0;
    }

    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in entries)
        {
            Console.WriteLine(entry.ToString());
        }
    }
}
