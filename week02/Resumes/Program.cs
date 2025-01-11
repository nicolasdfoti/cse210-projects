using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
    }

           public class Job
    {
        string _company = "";
        string _job_title = "";
        int _start_year = 0;
        int _end_year = 0;

        public void JobInformation()
        {
            Console.WriteLine($"{_job_title} ({_company}) {_start_year} - {_end_year}");
        }

    }

        public class Resume
        {
            string _name = "";
            List<Job> _jobs = 
        }
}