namespace _03._BarrackWars_A_New_Factory.Data
{
    using Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class UnitRepository : IRepository
    {
        private readonly IDictionary<string, int> amountOfUnits;

        public UnitRepository()
        {
            this.amountOfUnits = new SortedDictionary<string, int>();
        }

        public string Statistics
        {
            get
            {
                var statBuilder = new StringBuilder();

                foreach (var entry in this.amountOfUnits)
                {
                    var formatedEntry = string.Format($"{entry.Key} -> {entry.Value}");
                    statBuilder.AppendLine(formatedEntry);
                }

                return statBuilder.ToString().Trim();
            }
        }

        public void AddUnit(IUnit unit)
        {
            var unitType = unit.GetType().Name;

            if (!this.amountOfUnits.ContainsKey(unitType))
            {
                this.amountOfUnits.Add(unitType, 0);
            }

            this.amountOfUnits[unitType]++;
        }

        public void RemoveUnit(string unitType)
        {
            //TODO: implement for Problem 4
            throw new NotImplementedException();
        }
    }
}