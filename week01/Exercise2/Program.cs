// Stretch Challenge
// reads a percentage grade from the user and output the corresponding letter grade
// and I am also using the byu grading scale.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent;
        
        if (!int.TryParse(answer, out percent))
        {
            Console.WriteLine("Invalid input. Please enter a numeric value.");
            return;
        }

        string letter = "";

        if (percent >= 93)
        {
            letter = "A";
        }
        else if (percent >= 90)
        {
            letter = "A-";
        }
        else if (percent >= 87)
        {
            letter = "B+";
        }
        else if (percent >= 83)
        {
            letter = "B";
        }
        else if (percent >= 80)
        {
            letter = "B-";
        }
        else if (percent >= 77)
        {
            letter = "C+";
        }
        else if (percent >= 73)
        {
            letter = "C";
        }
        else if (percent >= 70)
        {
            letter = "C-";
        }
        else if (percent >= 67)
        {
            letter = "D+";
        }
        else if (percent >= 63)
        {
            letter = "D";
        }
        else if (percent >= 60)
        {
            letter = "D-";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");
        
        if (percent >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}
