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
        Reference scripRef3 = new Reference("John", 10, 10);
        Reference scripRef4 = new Reference("Romans", 12, 1);
        Reference scripRef5 = new Reference("D&C", 88, 67);
        Reference scripRef6 = new Reference("2 Nephi", 31, 20);
        Reference scripRef7 = new Reference("D&C", 58, 27);

        Scripture scripture1 = new Scripture(scripRef1, "Have ye walked, keeping yourselves blameless before God? Could ye say, if ye were called to die at this time, within yourselves, that ye have been sufficiently humble? That your garments have been cleansed and made white through the blood of Christ, who will come to redeem his people from their sins?");
        Scripture scripture2 = new Scripture(scripRef2, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life. For God sent not his Son into the world to condemn the world; but that the world through him might be saved.");
        Scripture scripture3 = new Scripture(scripRef3, "The thief cometh not, but for to steal, and to kill, and to destroy: I am come that they might have life, and that they might have it more abundantly.");
        Scripture scripture4 = new Scripture(scripRef4, "I beseech you therefore, brethren, by the mercies of God, that ye present your bodies a living sacrifice, holy, acceptable unto God, which is your reasonable service.");
        Scripture scripture5 = new Scripture(scripRef5, "And if your eye be single to my glory, your whole bodies shall be filled with light, and there shall be no darkness in you; and that body which is filled with light comprehendeth all things.");
        Scripture scripture6 = new Scripture(scripRef6, "Wherefore, ye must press forward with a steadfastness in Christ, having a perfect brightness of hope, and a love of God and of all men. Wherefore, if ye shall press forward, feasting upon the word of Christ, and endure to the end, behold, thus saith the Father: Ye shall have eternal life.");

        scriptureList.Add(scripture1);
        scriptureList.Add(scripture2);
        scriptureList.Add(scripture3);
        scriptureList.Add(scripture4);
        scriptureList.Add(scripture5);
        scriptureList.Add(scripture6);

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





