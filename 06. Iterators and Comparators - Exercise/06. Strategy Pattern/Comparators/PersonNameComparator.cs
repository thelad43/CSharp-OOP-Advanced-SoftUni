namespace _06._Strategy_Pattern.Comparators
{
    using System.Collections.Generic;

    public class PersonNameComparator : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            var comparison = x.Name.Length.CompareTo(y.Name.Length);

            if (comparison == 0)
            {
                comparison = x.Name.ToLower()[0].CompareTo(y.Name.ToLower()[0]);
            }

            return comparison;
        }
    }
}