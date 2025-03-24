public class ListingActivity : Activity
{ 
    private int _count;
    private List<string> _prompts = new List<string>();
    // Constructor - ListingActivity 
    public ListingActivity(string name, string description, List<string> prompts) : base(name, description)
    {
        _prompts = prompts;
    }
    // This will run when the selected the Listing Activity
    public void Run()
    {
        List<string> entries = new List<string>();

        DisplayStartingMessage();

        Console.Clear();

        Console.WriteLine("Get ready...");
        ShowSpinner(4);
        Console.WriteLine("List as many responses as you can to the following prompt: ");
        GetRandomPrompt();
        Console.WriteLine("You may begin:");

        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(_duration);

        while (DateTime.Now < end)
        {
            Console.Write("> ");
            entries.Add(Console.ReadLine());
        }
        _count = entries.Count();
        Console.WriteLine($"You listed {_count} items!");

        DisplayEndingMessage();
        
    }
    
    private void GetRandomPrompt()
    {
        Random random = new Random();
        int randInt = random.Next(_prompts.Count);
        Console.WriteLine($"--- {_prompts[randInt]} ---");
    }

    public List<string> GetListFromUser()
    {
        return _prompts;
    }
}