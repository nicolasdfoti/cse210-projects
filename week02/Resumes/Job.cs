public class Job
{
    public string _company = "";
    public string _job_title = "";
    public int _start_year = 0;
    public int _end_year = 0;

    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_job_title} ({_company}) {_start_year} - {_end_year}");
    }

}