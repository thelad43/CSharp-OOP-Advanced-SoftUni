namespace _05._Integration_Tests.Interfaces
{
    using System.Collections.Generic;

    public interface ICategory
    {
        string Name { get; }

        ICategory Parent { get; }

        IList<IUser> Users { get; }

        IList<ICategory> ChildCategories { get; }

        void AddChild(ICategory child);

        void AddUser(IUser user);

        void MoveUsersToParent();

        void RemoveChild(string name);

        void SetParent(ICategory category);
    }
}