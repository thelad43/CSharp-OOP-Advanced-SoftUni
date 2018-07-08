namespace _04._BarrackWars_The_Commands_Strike_Back.Factories
{
    using Interfaces;
    using System;

    public class UnitFactory : IUnitFactory
    {
        private const string NamespaceAsString = "_04._BarrackWars_The_Commands_Strike_Back.Models.Units";

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