namespace _01._Stealer
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Text;

    public class Spy
    {
        public string StealFieldInfo(string className, params string[] fields)
        {
            var type = Type.GetType(GetType().Namespace + "." + className);

            var classFields = type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic |
                BindingFlags.Public | BindingFlags.Static);

            var result = new StringBuilder();
            var classInstance = Activator.CreateInstance(type, new object[] { });
            result.AppendLine($"Class under investigation: {className}");

            foreach (var field in classFields.Where(f => fields.Contains(f.Name)))
            {
                result.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
            }

            return result.ToString().Trim();
        }
    }
}