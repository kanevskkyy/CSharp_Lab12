using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    internal class Job<T>
    {
        public string JobName { get; set; }
        public int RequiredHours { get; set; }
        public string Worker { get; set; }

        public delegate void JobHandler(string message);
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
            if (RequiredHours <= 0) Console.WriteLine($"Job {JobName} is done!");
        }
    }
}
