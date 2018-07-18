namespace _04._Work_Force.Controllers
{
    using Interfaces;
    using Models;
    using Models.Employees;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    public class Engine : IRunnable
    {
        private const string MissingEmployeeExceptionMessage = "Employee {0} is not available";
        private const string WrongParametersCountInCommandExceptionMessage = "Expected parameters are: {0}";
        private const string CommandSuffix = "Command";

        private readonly IList<IEmployee> employees;
        private readonly IList<IJob> jobs;

        private readonly IReader reader;
        private readonly IWriter writer;
        private readonly MethodInfo[] methods;

        public Engine(IReader reader, IWriter writer)
           : this(new List<IJob>(), new List<IEmployee>(), reader, writer)
        {
        }

        public Engine(IList<IJob> jobs, IList<IEmployee> employees, IReader reader, IWriter writer)
        {
            this.jobs = jobs;
            this.employees = employees;
            this.reader = reader;
            this.writer = writer;
            this.methods = this.GetType().GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
        }

        public void Run()
        {
            while (true)
            {
                var inputTokens = this.reader.ReadLine().Split();

                if (inputTokens[0] == "End")
                {
                    break;
                }

                var commandName = inputTokens[0] + CommandSuffix;

                var methodForExecution = this.methods
                    .FirstOrDefault(m => m.Name.Equals(commandName));

                if (methodForExecution != null)
                {
                    this.InvokeMethod(inputTokens.Skip(1).ToArray(), methodForExecution);
                }
            }
        }

        private void InvokeMethod(string[] cmdArgs, MethodInfo methodForExecution)
        {
            var requiredParams = methodForExecution.GetParameters();

            if (cmdArgs.Length < requiredParams.Length)
            {
                throw new ArgumentException(string.Format(WrongParametersCountInCommandExceptionMessage,
                    string.Join(", ", requiredParams.Select(rp => rp.Name))));
            }

            var parsedParams = new object[requiredParams.Length];

            for (int i = 0; i < requiredParams.Length; i++)
            {
                var paramType = requiredParams[i].ParameterType;
                parsedParams[i] = Convert.ChangeType(cmdArgs[i], paramType);
            }

            methodForExecution.Invoke(this, parsedParams);
        }

        private void JobCommand(string jobName, int requiredHoursOfWork, string employeeName)
        {
            var assigningEmployee = this.employees.FirstOrDefault(e => e.Name == employeeName);

            if (assigningEmployee == null)
            {
                throw new ArgumentException(string.Format(MissingEmployeeExceptionMessage, employeeName));
            }

            var job = new Job(jobName, requiredHoursOfWork, assigningEmployee);
            job.JobDone += this.OnJobDone;
            this.jobs.Add(new Job(jobName, requiredHoursOfWork, assigningEmployee));
        }

        private void OnJobDone(object sender, JobEventArgs args) =>
            this.writer.WriteLine($"Job {args.Job.Name} done!");

        private void StandardEmployeeCommand(string name) =>
            this.employees.Add(new StandartEmployee(name));

        private void PartTimeEmployeeCommand(string name) =>
            this.employees.Add(new PartTimeEmployee(name));

        private void StatusCommand() =>
            this.writer.WriteLine(string.Join(Environment.NewLine, this.jobs.Where(j => j.RequiredHoursOfWork > 0)));

        private void PassCommand()
        {
            foreach (var job in this.jobs)
            {
                job.Update();
            }
        }
    }
}