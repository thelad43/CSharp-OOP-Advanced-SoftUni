namespace _03._Dependency_Inversion.Controllers
{
    using Interfaces;
    using Strategies;
    using System;
    using System.Collections.Generic;

    public class Engine : IRunnable
    {
        private readonly IReader reader;
        private readonly IWriter writer;
        private IDictionary<char, IStrategy> symbolicStrategyMapper;
        private readonly IPrimitiveCalculator calculator;

        public Engine(IPrimitiveCalculator calculator, IReader reader, IWriter writer)
            : this(calculator, reader, writer, new Dictionary<char, IStrategy>())
        {
            this.SetDefaultSymbolicStrategyMapper();
        }

        public Engine(IPrimitiveCalculator calculator, IReader reader, IWriter writer, IDictionary<char, IStrategy> symbolicStrategyMapper)
        {
            this.calculator = calculator;
            this.reader = reader;
            this.writer = writer;
            this.symbolicStrategyMapper = symbolicStrategyMapper;
        }

        public void Run()
        {
            while (true)
            {
                var commandTokens = this.reader.ReadLine().Split();

                if (commandTokens[0] == "End")
                {
                    break;
                }

                ProcessCommand(commandTokens);
            }
        }

        private void ProcessCommand(string[] commandTokens)
        {
            if (commandTokens[0].Equals("mode", StringComparison.OrdinalIgnoreCase))
            {
                var newStrategy = this.symbolicStrategyMapper[commandTokens[1][0]];
                this.calculator.ChangeStrategy(newStrategy);
            }
            else
            {
                var firstOperand = int.Parse(commandTokens[0]);
                var secondOperand = int.Parse(commandTokens[1]);
                var result = this.calculator.PerformCalculation(firstOperand, secondOperand);
                this.writer.WriteLine(result.ToString());
            }
        }

        private void SetDefaultSymbolicStrategyMapper()
        {
            this.symbolicStrategyMapper['+'] = new AdditionStrategy();
            this.symbolicStrategyMapper['-'] = new SubtractionStrategy();
            this.symbolicStrategyMapper['*'] = new MultiplicationStrategy();
            this.symbolicStrategyMapper['/'] = new DivisionStrategy();
        }
    }
}