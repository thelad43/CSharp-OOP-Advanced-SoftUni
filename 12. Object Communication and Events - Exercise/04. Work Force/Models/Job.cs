namespace _04._Work_Force.Models
{
    using Interfaces;
    using System;

    public delegate void JobDoneEventHandler(object sender, JobEventArgs args);

    public class Job : IJob
    {
        public event JobDoneEventHandler JobDone;

        private int requiredHoursOfWork;
        private readonly IEmployee employee;

        public Job(string name, int requiredHoursOfWork, IEmployee employee)
        {
            this.Name = name;
            this.requiredHoursOfWork = requiredHoursOfWork;
            this.employee = employee;
            this.IsActive = true;
        }

        public string Name { get; private set; }

        public bool IsActive { get; private set; }

        public int RequiredHoursOfWork
        {
            get
            {
                return this.requiredHoursOfWork;
            }
            set
            {
                this.requiredHoursOfWork = value;

                if (this.requiredHoursOfWork <= 0 && this.IsActive)
                {
                    this.requiredHoursOfWork = 0;
                    Console.WriteLine($"Job {this.Name} done!");
                    this.JobDone?.Invoke(this, new JobEventArgs(this));
                    this.IsActive = false;
                }
            }
        }

        public void Update()
        {
            this.RequiredHoursOfWork -= this.employee.WorkHoursPerWeek;
        }

        public override string ToString()
        {
            return $"Job: {this.Name} Hours Remaining: {this.RequiredHoursOfWork}";
        }
    }
}