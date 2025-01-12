using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        Job job1 = new Job();

        job1._company = "Ford";
        job1._job_title = "Engineer";
        job1._start_year = 2003;
        job1._end_year = 2007;

        job1.DisplayJobDetails();

        Job job2 = new Job();

        job2._company = "Apple";
        job2._job_title = "Software Developer";
        job2._start_year = 2007;
        job2._end_year = 2020;

        job2.DisplayJobDetails();

        Resume resume1 = new Resume();

        resume1._name = "Nicolás";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        
        resume1.DisplayResume();

    }
}