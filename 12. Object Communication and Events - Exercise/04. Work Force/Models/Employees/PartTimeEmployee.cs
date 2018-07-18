﻿namespace _04._Work_Force.Models.Employees
{
    public class PartTimeEmployee : Employee
    {
        private const int WeeklyWorkingHours = 20;

        public PartTimeEmployee(string name)
            : base(name, WeeklyWorkingHours)
        {
        }
    }
}