using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;


namespace JournalApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Created a new journal
            Journal myJournal = new Journal("My Personal Journal");

            // Added my prompts here
            List<string>prompts = new List<string>
            {
                "What did you do in the morning?",
                "Did you say your prayer today?",
                "How is the weather?",
                "Do you have a plan?",
                "When are you going to take a nap?",

            };

            while (true)
            {
                Console.WriteLine("1. Write a new entry");
                Console.WriteLine("2. Display the journal");
                Console.WriteLine("3. Save the journal to the file");
                Console.WriteLine("4. Load the journal from the file");
                Console.WriteLine("5. Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: string prompt = prompts[new Random().Next(prompts.Count)];

                        Console.WriteLine($"Prompt:{prompt}");
                        Console.Write("Your response:");

                        string response = Console.ReadLine();

                        myJournal.AddEntry(prompt,response);

                        break;
                     
                    case 2:

                        myJournal.DisplayEntries(); 

                        break; 

                    case 3: 

                         Console.Write("Enter filename to save");
                         string saveFilename = Console.ReadLine();
                         myJournal.SaveToFile(saveFilename);
                         break;
                    case 4:
                        Console.Write("Enter filename to load:" ); 
                        string loadFilename = Console.ReadLine();
                        myJournal.LoadFromFile(loadFilename);
                        break;
                    case 5: 
                          Environment.Exist(0);
                    default:
                         Console.WriteLine("Invalid choice. try again.");
                         break;        
                } 
            } 
        }     
    } 
                        

    class Journal
    {
        private string _name;
        private List<Entry> _entries;

        public Journal (string name)
        {
            _name = name;
            _entries = new List<Entry>();      
        }  
        public void AddEntry(string prompt, string response)
        {
            _entries.Add(new Entry(DateTime.Now, prompt, response));
        }
    
       public void DisplayEntries()
        {
           Console.WriteLine($"Entries in {_name}:");
           foreach (var entry in _entries)

            {
                Console.WriteLine($"{entry.Date}: {entry.Prompt} - {entry.Response}");

            }
        }                     
        public void SaveToFile(string filename)
            {
                // Save to file
            }
    class Entry
    {
        public DateTime Date { get; } 
        public string Prompt { get; }
        public string Response { get; }

        public Entry(DateTime date, string prompt, string response)
        {
            Date = date;
            Prompt = prompt;
            Response = response;
        }
    }
}    
