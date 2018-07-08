namespace _03._BarrackWars_A_New_Factory.Core.Factories
{
    using Interfaces;
    using System;
    using System.Linq;
    using System.Reflection;

    public class UnitFactory : IUnitFactory
    {
        public IUnit CreateUnit(string unitType)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var type = assembly.GetTypes().FirstOrDefault(t => t.Name == unitType);

            if (type == null)
            {
                throw new ArgumentException($"{unitType} is not a Unit type!");
            }

            if (!typeof(IUnit).IsAssignableFrom(type))
            {
                throw new ArgumentException("Invalid Unit type!");
            }

            return (IUnit)Activator.CreateInstance(type);
        }
    }
}