public class Resume
{
    public string _name;
    public List<Job> jobs = new List<Job>();
    
    public void Display()
    {
        Console.WriteLine($"{_name}: \nJobs: ");

        foreach (var job in jobs)
        {
            job.Display();
        }
    }
}