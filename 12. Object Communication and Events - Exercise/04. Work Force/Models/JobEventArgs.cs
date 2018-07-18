namespace _04._Work_Force.Models
{
    using Interfaces;
    using System;

    public class JobEventArgs : EventArgs
    {
        public JobEventArgs(IJob job)
        {
            this.Job = job;
        }

        public IJob Job { get; }
    }
}