using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Teller/Customer Service Rep.";
        job1._company = "America First Credit Union";
        job1._startYear = 2017;
        job1._endYear = 2020;

        Job job2 = new Job();
        job2._jobTitle = "Inventory Control Specialist";
        job2._company = "Nutraceutical/Better Being Co.";
        job2._startYear = 2020;
        job2._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Robert Hadley";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}