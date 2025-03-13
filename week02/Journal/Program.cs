using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Welcome to my Journal!");
        Journal journal = new Journal();
        string choice = "";

        while (!choice.Equals("5"))
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice (1-5): ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    journal.WriteJournalEntry();
                    break;
                case "2":
                    journal.DisplayJournalEntry();
                    break;
                case "3":
                    journal.SaveJournalToFile();
                    break;
                case "4":
                    journal.LoadJournalFromFile();
                    break;
                case "5":
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                    break;
            }
        }   
    }
}


public class Journal
{
    List<JournalEntry> journalEntries;
    List<string> prompts;
    Random rand;
    string filename = "C:\\Users\\leonchibanda\\Documents\\myFile.txt";

    public Journal()
    {
    //journal list
        journalEntries = new List<JournalEntry>();
        rand = new Random();
        prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What did you eat for today?"

        };

    }

    public string getRandomPrompt()
    {
        int randomNum = rand.Next(0, prompts.Count);
        return prompts[randomNum];
    }

    // read all journal entries-file-list
    public void LoadJournalFromFile()
    {
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        
        {
            JournalEntry entry = new JournalEntry(line);
            addEntry(entry);
        }
    }

    public void DisplayJournalEntry()
    {
        foreach (JournalEntry j in journalEntries)
        {
            System.Console.WriteLine(j.ToString());
        }
    }

    public void SaveJournalToFile()
    {
        if (journalEntries.Count == 0)
        {
            System.Console.WriteLine("No journal entries to save.");
            return;
        }

       
        using (StreamWriter outputFile = new StreamWriter(filename, false))
        {
            foreach (JournalEntry j in journalEntries)
            {
                outputFile.WriteLine(j.printToFIle());
            }
        }
    }

    public void WriteJournalEntry()
    {
        // Get the current date
        DateTime currentDate = DateTime.Now;
        string dateText = currentDate.ToShortDateString();
        string prompt = getRandomPrompt();
        System.Console.WriteLine(prompt);
        string response = Console.ReadLine();

        JournalEntry entry = CreateJournalEntry(dateText, prompt, response);

        addEntry(entry);
    }

    public JournalEntry CreateJournalEntry(string date, string prompt, string response)
    {
        JournalEntry entry = new JournalEntry(date, prompt, response);

        return entry;
    }

    public void addEntry(JournalEntry entry)
    {
        journalEntries.Add(entry);
    }
}

public class JournalEntry
{
    private string _date;
    private string _prompt;
    private string _response;

    public JournalEntry(string entry)
    {
        string[] items = entry.Split(",");

        _date = items[0];
        _prompt = items[1];
        _response = items[2];

    }

    public JournalEntry(string date, string prompt, string response)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
    }

    public override string ToString()
    {
        return _date + " " + _prompt + "\n" + _response + "\n\n";
    }

    public string printToFIle()
    {
        return $"{_date},{_prompt},{_response}";
    }

    public string getDate()
    {
        return _date;
    }
}