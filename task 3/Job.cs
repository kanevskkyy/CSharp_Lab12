namespace task_3
{
    internal class Job
    {
        public string JobName { get; set; }
        public int RequiredHours { get; set; }
        public string Worker { get; set; }

        public delegate void JobHandler(Job job);
        public event JobHandler? JobCompleted;

        public Job(string jobName, int requiredHours, string worker)
        {
            JobName = jobName;
            RequiredHours = requiredHours;
            Worker = worker;
        }

        public void Update(int hours)
        {
            RequiredHours -= hours;
            if (RequiredHours <= 0) JobCompleted?.Invoke(this);
        }

        public override string ToString()
        {
            return $"Job: {JobName} Hours Remaining: {RequiredHours}";
        }
    }
}