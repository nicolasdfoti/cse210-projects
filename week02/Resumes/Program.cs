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
        job1._end_year = 2024;

        job1.JobInformation();

    }
}