using System;
using System.Collections.Generic;
using System.IO;

class JournalEntry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public DateTime Date { get; set; }
}

class Journal
{
    private List<JournalEntry> entries = new List<JournalEntry>();

    public void AddEntry(string prompt, string response, DateTime date)
    {
        var entry = new JournalEntry { Prompt = prompt, Response = response, Date = date };
        entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine($"Date: {entry.Date.ToShortDateString()}");
            Console.WriteLine($"Prompt: {entry.Prompt}");
            Console.WriteLine($"Response: {entry.Response}\n");
        }
    }

    public void SaveToFile(string filename)
    {
        using (var writer = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine($"{entry.Date.ToShortDateString()} | {entry.Prompt} | {entry.Response}");
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        entries.Clear();
        using (var reader = new StreamReader(filename))
        {
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var parts = line.Split(" | ");
                if (parts.Length == 3 && DateTime.TryParse(parts[0], out DateTime date))
                {
                    AddEntry(parts[1], parts[2], date);
                }
            }
        }
    }
}

class Program
{
    static void Main()
    {
        var myJournal = new Journal();

        while (true)
        {
            Console.WriteLine("\n1. Write a new entry");
            Console.WriteLine("2. Display journal entries");
            Console.WriteLine("3. Save journal to a file");
            Console.WriteLine("4. Load journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter a prompt: ");
                    var prompt = Console.ReadLine();
                    Console.Write("Enter your response: ");
                    var response = Console.ReadLine();
                    Console.Write("Enter the date (YYYY-MM-DD): ");
                    if (DateTime.TryParse(Console.ReadLine(), out DateTime date))
                    {
                        myJournal.AddEntry(prompt, response, date);
                    }
                    break;
                case "2":
                    myJournal.DisplayEntries();
                    break;
                case "3":
                    Console.Write("Enter the filename to save: ");
                    myJournal.SaveToFile(Console.ReadLine());
                    break;
                case "4":
                    Console.Write("Enter the filename to load: ");
                    myJournal.LoadFromFile(Console.ReadLine());
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
