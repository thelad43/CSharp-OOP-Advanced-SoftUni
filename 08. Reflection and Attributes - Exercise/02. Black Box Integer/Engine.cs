using System;
using System.Linq;
using System.Reflection;
using System.Text;

namespace _02._Black_Box_Integer
{
    public class Engine
    {
        private readonly StringBuilder stringBuilder;

        public Engine()
        {
            this.stringBuilder = new StringBuilder();
        }

        public void Run()
        {
            var type = typeof(BlackBoxInteger);
            var classInstance = Activator.CreateInstance(type, true);
            var methods = type.GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
            var fields = type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            var result = ProcessCommands(classInstance, methods, fields);
            Console.WriteLine(result);
        }

        private string ProcessCommands(object classInstance, MethodInfo[] methods, FieldInfo[] fields)
        {
            while (true)
            {
                var inputTokens = Console.ReadLine().Split('_', StringSplitOptions.RemoveEmptyEntries);
                var command = inputTokens[0];

                if (inputTokens[0] == "END")
                {
                    break;
                }

                var number = int.Parse(inputTokens[1]);

                methods
                    .FirstOrDefault(m => m.Name == command)
                    .Invoke(classInstance, new object[] { number });

                foreach (var field in fields)
                {
                    this.stringBuilder.AppendLine(field.GetValue(classInstance).ToString());
                }
            }

            var result = this.stringBuilder.ToString().Trim();
            return result;
        }
    }
}