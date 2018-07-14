namespace _05._Integration_Tests.Interfaces
{
    using System.Collections.Generic;

    public interface IUser
    {
        string Name { get; }

        IEnumerable<ICategory> Categories { get; }

        void AddCategory(ICategory category);

        void RemoveCategory(ICategory category);
    }
}