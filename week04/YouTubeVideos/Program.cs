// Leon Chibanda
using System;
using DocumentFormat.OpenXml.Spreadsheet;

internal class Program
{
    private static void Main(string[] args)
    {
        Comments _com = new Comments(); ;
        Video _video1 = new Video();
        _video1._title = "Star Trek: First Contact";
        _video1._author = "Paramount Pictures";
        _video1._length = 111;

        Video _video2 = new Video();
        _video2._title = "Naruto: The Last Movie";
        _video2._author = "Studio Pierrot";
        _video2._length = 112;

        Video _video3 = new Video();
        _video3._title = "The Matrix";
        _video3._author = "Warner Bros.";
        _video3._length = 136;

        Video _video4 = new Video();
        _video4._title = "Avengers: Endgame";
        _video4._author = "Marvel Studios";
        _video4._length = 181;

        bool menuLoop = true;
        while (menuLoop)
        {
            Console.WriteLine($"In what video you want to comment? \n1.- {_video1._title} \n2.- {_video2._title} \n3.- {_video3._title} \n4.- {_video4._title} \n5. - Quit");
            int number = int.Parse(Console.ReadLine());
            if (number != 4)
            {
                Console.WriteLine("What is your name?");
                _com._name = Console.ReadLine();
                Console.WriteLine("What is the comment?");
                _com._comments = Console.ReadLine();
                switch (number)
                {

                    case 1:
                        _video1.AddComment(_com._name, _com._comments);
                        Console.WriteLine();
                        _com.DisplayComments(_video1);
                        Console.WriteLine();

                        break;
                    case 2:
                        _video2.AddComment(_com._name, _com._comments);
                        Console.WriteLine();
                        _com.DisplayComments(_video2);
                        Console.WriteLine();
                        break;
                    case 3:
                        _video3.AddComment(_com._name, _com._comments);
                        Console.WriteLine();
                        _com.DisplayComments(_video3);
                        Console.WriteLine();
                        break;
                    case 4:
                        _video4.AddComment(_com._name, _com._comments);
                        Console.WriteLine();
                        _com.DisplayComments(_video4);
                        Console.WriteLine();
                        break;
                }
            }

            else
            {
                menuLoop = false;
            }

        }
    }
}