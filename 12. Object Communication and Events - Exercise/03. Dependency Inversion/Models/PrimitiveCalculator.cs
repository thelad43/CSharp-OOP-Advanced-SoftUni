namespace _03._Dependency_Inversion.Models
{
    using Interfaces;
    using Strategies;

    public class PrimitiveCalculator : IPrimitiveCalculator
    {
        private IStrategy calculationStrategy;

        public PrimitiveCalculator()
            : this(new AdditionStrategy())
        {
        }

        public PrimitiveCalculator(IStrategy calculationStrategy)
        {
            this.calculationStrategy = calculationStrategy;
        }

        public void ChangeStrategy(IStrategy strategy)
        {
            this.calculationStrategy = strategy;
        }

        public int PerformCalculation(int firstOperand, int secondOperand)
        {
            return this.calculationStrategy.Calculate(firstOperand, secondOperand);
        }
    }
}