namespace _01._Harvesting_Fields
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Text;

    public class Engine
    {
        private readonly StringBuilder stringBuilder;

        public Engine()
        {
            this.stringBuilder = new StringBuilder();
        }

        public void Run()
        {
            ProcessCommands();

            PrintResult();
        }

        private void ProcessCommands()
        {
            while (true)
            {
                var inputLine = Console.ReadLine();
                var type = typeof(HarvestingFields);
                var fields = type.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);

                if (inputLine == "HARVEST")
                {
                    break;
                }

                switch (inputLine)
                {
                    case "private":
                        this.AppendFieldsToStringBuilder(fields.Where(f => f.IsPrivate));
                        break;

                    case "protected":
                        this.AppendFieldsToStringBuilder(fields.Where(f => f.IsFamily));
                        break;

                    case "public":
                        this.AppendFieldsToStringBuilder(fields.Where(f => f.IsPublic));
                        break;

                    case "all":
                        this.AppendFieldsToStringBuilder(fields);
                        break;

                    default:
                        throw new ArgumentException();
                }
            }
        }

        private void PrintResult()
        {
            Console.WriteLine(this.stringBuilder.ToString().Trim());
        }

        private void AppendFieldsToStringBuilder(IEnumerable<FieldInfo> fields)
        {
            var accessModifier = string.Empty;

            foreach (var field in fields)
            {
                accessModifier = field.Attributes.ToString().ToLower();

                if (accessModifier.CompareTo("family") == 0)
                {
                    accessModifier = "protected";
                }

                this.stringBuilder.AppendLine($"{accessModifier} {field.FieldType.Name} {field.Name}");
            }
        }
    }
}