namespace _05._BarrackWars_Return_of_the_Dependencies.Factories
{
    using Interfaces;
    using System;

    public class UnitFactory : IUnitFactory
    {
        private const string NamespaceAsString = "_05._BarrackWars_Return_of_the_Dependencies.Models.Units";

        public IUnit CreateUnit(string unitType)
        {
            var type = Type.GetType(NamespaceAsString + "." + unitType);

            if (type == null)
            {
                return null;
            }

            return (IUnit)Activator.CreateInstance(type);
        }
    }
}