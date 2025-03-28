public class ReflectingActivity : Activity
{
    // Lists for questions and prompts that will be used in the methods later on.
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    // Constructor will need all attributes from the base for DisplayStart and Display End on the activity, also using the duration in the run command. 
    public ReflectingActivity(string name, string description, List<string> prompts, List<string> questions) : base(name, description)
    {
        _prompts = prompts;
        _questions = questions;
    }

    // This will run when selected in the reflecting activity.
    public void Run()
    {
        DisplayStartingMessage();

        Console.Clear();

        Console.WriteLine("Get ready...");
        ShowSpinner(4);
        Console.WriteLine("Consider the following prompt:");
        DisplayPrompt();
        Console.WriteLine("When you have something in mind, press enter to continue");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience");
        Console.Write("You may begin in: ");
        ShowCountdown(5);

        Console.Clear();

        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(_duration);

        while (DateTime.Now < end)
        {
            DisplayQuestions();
        }
        DisplayEndingMessage();

    }
    // This gets random prompt from the list of prompts
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randInt = random.Next(_prompts.Count);
        string randPrompt = _prompts[randInt];
        return randPrompt;
    }
    // This does the same as the previous one, but with my list of questions
    public string GetRandomQuestions()
    {
        Random random = new Random();
        int randInt = random.Next(_questions.Count);
        string randQuestion = _questions[randInt];
        return randQuestion;
    }
    // This displays prompt with the --- formatting before and after prompt
    public void DisplayPrompt()
    {
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
    }
    // This does the same as DisplayPrompt but with the question instead. 
    public void DisplayQuestions()
    {
        Console.Write($"> {GetRandomQuestions()} ");
        ShowSpinner(4);
        Console.ReadLine();
    }
}