﻿namespace _03._Dependency_Inversion.Strategies
{
    using Interfaces;

    public class AdditionStrategy : IStrategy
    {
        public int Calculate(int firstOperand, int secondOperand)
        {
            return firstOperand + secondOperand;
        }
    }
}