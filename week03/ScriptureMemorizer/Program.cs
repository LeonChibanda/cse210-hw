// Added creativity by adding a list of scripture objects so that a random scripture is displayed when the program run.
// Added a condition to check if the user input is 'Enter', and if so, the program will hide a random word in the scripture.
using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> indexes = new List<int>();
        for (int i = 0; i < 5; i++)
        {
            indexes.Add(i+1);
        }
        List<Scripture> scriptureList = new List<Scripture>();


        Reference scripRef1 = new Reference("Alma", 5, 27);
        Reference scripRef2 = new Reference("John", 3, 16, 17);
       
        Scripture scripture1 = new Scripture(scripRef1, "Have ye walked, keeping yourselves blameless before God? Could ye say, if ye were called to die at this time, within yourselves, that ye have been sufficiently humble? That your garments have been cleansed and made white through the blood of Christ, who will come to redeem his people from their sins?");
        Scripture scripture2 = new Scripture(scripRef2, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life. For God sent not his Son into the world to condemn the world; but that the world through him might be saved.");
     
        scriptureList.Add(scripture1);
        scriptureList.Add(scripture2);

        Random random = new Random();
        int scripIndex = random.Next(scriptureList.Count);
        Scripture randomScripture = scriptureList[scripIndex];

        bool completelyHidden = randomScripture.IsCompletelyHidden();

        Console.WriteLine(randomScripture.GetDisplayText());
        Console.Write("Click 'Enter' to hide words, or type 'quit' to exit the program: ");
        string userInp = Console.ReadLine();
        Console.Clear();

        while (userInp != "quit")
        {
            Random r = new Random();
            int hideWords = random.Next(indexes.Count);
            randomScripture.HideRandomWords(indexes[hideWords]);

            Console.WriteLine(randomScripture.GetDisplayText());

            completelyHidden = randomScripture.IsCompletelyHidden();

            if (completelyHidden == true)
            {
                Console.Clear();
                break;
            }
            Console.Write("Click 'Enter' to hide words, or type 'quit' to exit the program: ");
            userInp = Console.ReadLine();
            Console.Clear();
        }
    }
}





