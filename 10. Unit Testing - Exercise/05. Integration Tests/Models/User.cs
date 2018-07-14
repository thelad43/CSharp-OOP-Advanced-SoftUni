namespace _05._Integration_Tests.Models
{
    using Interfaces;
    using System.Collections.Generic;

    public class User : IUser
    {
        private readonly string name;
        private readonly HashSet<ICategory> categories;

        public User(string name)
        {
            this.name = name;
            this.categories = new HashSet<ICategory>();
        }

        public string Name => this.name;

        public IEnumerable<ICategory> Categories => this.categories as IReadOnlyCollection<ICategory>;

        public void AddCategory(ICategory category) => this.categories.Add(category);

        public void RemoveCategory(ICategory category)
        {
            this.categories.RemoveWhere(c => c.Name == category.Name);

            if (category.Parent != null)
            {
                this.categories.Add(category.Parent);
            }
        }
    }
}