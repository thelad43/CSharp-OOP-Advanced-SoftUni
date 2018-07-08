namespace _06._Traffic_Lights
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            var trafficLights = new List<TrafficLight>();

            var inputTokens = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < inputTokens.Length; i++)
            {
                trafficLights.Add((TrafficLight)Activator.CreateInstance(typeof(TrafficLight), new[] { inputTokens[i] }));
            }

            var n = int.Parse(Console.ReadLine());

            var stringBuilder = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                foreach (var trafficLight in trafficLights)
                {
                    trafficLight.UpdateSignal();
                    var field = typeof(TrafficLight).GetField("signal", BindingFlags.Instance | BindingFlags.NonPublic);
                    stringBuilder.Append(field.GetValue(trafficLight) + " ");
                }

                stringBuilder.AppendLine();
            }

            Console.WriteLine(stringBuilder.ToString().Trim());
        }
    }
}