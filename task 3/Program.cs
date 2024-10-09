using System;
using task_3;

class Task
{
    static List<Job> jobs = new List<Job>();
    static void Main()
    {
        List<PartTimeEmployee> partTimes = new List<PartTimeEmployee>();
        List<StandardEmployee> standardEmployee = new List<StandardEmployee>();

        while (true)
        {
            string[] enteredInfromation = Console.ReadLine().Split();
            if (enteredInfromation[0] == "End") break;

            else if (enteredInfromation[0] == "StandardEmployee")
            {
                StandardEmployee tempStandard = new StandardEmployee(enteredInfromation[1]);
                standardEmployee.Add(tempStandard);
            }

            else if (enteredInfromation[0] == "PartTimeEmployee")
            {
                PartTimeEmployee tempPartTime = new PartTimeEmployee(enteredInfromation[1]);
                partTimes.Add(tempPartTime);
            }

            else if (enteredInfromation[0] == "Job")
            {
                Job tempJob = new Job(enteredInfromation[1], int.Parse(enteredInfromation[2]), enteredInfromation[3]);
                tempJob.JobCompleted += Remove; 
                jobs.Add(tempJob);
            }

            else if (enteredInfromation[0] == "Pass" && enteredInfromation[1] == "Week")
            {
                foreach (Job job in jobs.ToList()) 
                {
                    string nameOfWorker = job.Worker;
                    int hoursOfWorker = 0;

                    foreach(PartTimeEmployee temp in partTimes)
                    {
                        if (temp.Name == nameOfWorker) hoursOfWorker = temp.WeeklyHours;
                    }

                    foreach(StandardEmployee temp in standardEmployee)
                    {
                        if (temp.Name == nameOfWorker) hoursOfWorker = temp.WeeklyHours;
                    }
                    job.Update(hoursOfWorker);
                }
            }

            else if (enteredInfromation[0] == "Status")
            {
                foreach(Job job in jobs)
                {
                    Console.WriteLine(job);
                }
            }

            else Console.WriteLine("Invalid command!");
            Line();
        }
    }

    public static void Remove(Job job)
    {
        jobs.Remove(job);
        Console.WriteLine($"Job {job.JobName} done!");
    }

    public static void Line()
    {
        Console.WriteLine("=======================================");
    }
}