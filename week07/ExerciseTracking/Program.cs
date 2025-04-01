using System;

class Program
{
    //Leon Chibanda
    static void Main(string[] args)
    {
        Running running = new("29 March 2025", 30, 3);
        Swimming swimming = new("31 March 2025", 60, 100);
        Cycling  cycling = new("1 April 2025", 90, 13);
        

        List<Activity> activities = [running, swimming, cycling];

        foreach(Activity activity in activities) 
        {
           string summary = activity.GetSummary();
           Console.WriteLine(summary);
        }
    }
}