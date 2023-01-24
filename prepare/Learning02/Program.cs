using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
    }
    // the job class
    class Job
{
    // inputs information
    private string _company;
    private string _title;
    private int _startYear;
    private int _endYear;

    public Job(string company, string title, int startYear, int endYear)
    {
        _company = company;
        _title = title;
        _startYear = startYear;
        _endYear = endYear;
    }

    public void DisplayInformation()
    {
        Console.WriteLine($"{_title} ({_company}) {_startYear}-{_endYear}");
    }
}
// This is resume class 
class Resume
{
    private string _name;
    private List<Job> _jobs;

    public Resume(string name)
    {
        _name = name;
        _jobs = new List<Job>();
    }
    public void AddJob(Job job)
    {
        _jobs.Add(job);
    }
    public void DisplayResume()
    {
        Console.WriteLine(_name);
        foreach (var job in _jobs)
        {
            job.DisplayInformation();
        }
     }
  }
}