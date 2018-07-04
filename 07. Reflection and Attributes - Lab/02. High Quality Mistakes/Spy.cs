namespace _02._High_Quality_Mistakes
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

        public string AnalyzeAcessModifiers(string className)
        {
            var type = Type.GetType(GetType().Namespace + "." + className);

            var fields = type.GetFields();
            var publicMethods = type.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);
            var privateMethods = type.GetMethods();

            var stringBuilder = new StringBuilder();

            foreach (var field in fields)
            {
                stringBuilder.AppendLine($"{field.Name} must be private!");
            }

            foreach (var method in publicMethods.Where(m => m.Name.StartsWith("get")))
            {
                stringBuilder.AppendLine($"{method.Name} have to be public!");
            }

            foreach (var method in privateMethods.Where(m => m.Name.StartsWith("set")))
            {
                stringBuilder.AppendLine($"{method.Name} have to be private!");
            }

            var result = stringBuilder.ToString().Trim();
            return result;
        }
    }
}