namespace _03._Dependency_Inversion.Strategies
{
    using Interfaces;

    public class DivisionStrategy : IStrategy
    {
        public int Calculate(int firstOperand, int secondOperand)
        {
            return firstOperand / secondOperand;
        }
    }
}