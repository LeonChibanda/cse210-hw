using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Supervisor";
        job1._company = "KFC";
        job1._startYear = 2015;
        job1._endYear = 2016;

        Job job2 = new Job();
        job2._jobTitle = "Supervisor";
        job2._company = "Milkylane and Co";
        job2._startYear = 2016;
        job2._endYear = 2017;

        Job job3 = new Job();
        job3._jobTitle = "Manager";
        job3._company = "Milkylane and Co";
        job3._startYear = 2017;
        job3._endYear = 2020;

        Job job4 = new Job();
        job4._jobTitle = "Manager";
        job4._company = "Fishaways";
        job4._startYear = 2020;
        job4._endYear = 2022;

        Job job5 = new Job();
        job5._jobTitle = "Manager";
        job5._company = "Debonairs Pizza";
        job5._startYear = 2022;
        job5._endYear = 2024;

        Resume myResume = new Resume();
        
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume._jobs.Add(job3);
        myResume._jobs.Add(job4);
        myResume._jobs.Add(job5);
        myResume._name = "Leon Chibanda";

        myResume.Display();

    }
}