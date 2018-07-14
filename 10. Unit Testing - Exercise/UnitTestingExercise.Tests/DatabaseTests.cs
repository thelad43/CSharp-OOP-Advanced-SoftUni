namespace UnitTestingExercise.Tests
{
    using _01._Database;
    using NUnit.Framework;
    using System.Linq;

    public class DatabaseTests
    {
        [Test]
        public void CreateDatabaseWithConstructor()
        {
            // Arrange
            var db = new Database(1, 2, 3, 4, 5, 6);

            // Act
            // Assert
            Assert.That(db.Fetch(), Is.EqualTo(new int[] { 1, 2, 3, 4, 5, 6 }));
        }

        [Test]
        public void CreateDatabaseWithMoreThan16ElementsShouldThrowException()
        {
            // Arrange
            // Act
            // Assert
            Assert.That(() => new Database(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17), Throws.InvalidOperationException
                .With
                .Message
                .EqualTo("Items cannot be more than 16!"));
        }

        [Test]
        public void AddElementsToDatabaseShouldWorkCorrectly()
        {
            // Arrange
            var db = new Database();

            // Act
            for (int i = 1; i <= 10; i++)
            {
                db.Add(i);
            }

            // Assert
            Assert.That(db.Fetch(), Is.EqualTo(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }));
        }

        [Test]
        public void RemoveElementsFromDatabaseShouldWorkCorrectly()
        {
            // Arrange
            var db = new Database();

            for (int i = 1; i <= 10; i++)
            {
                db.Add(i);
            }

            // Act
            for (int i = 0; i < 5; i++)
            {
                db.Remove();
            }

            // Assert
            Assert.That(db.Fetch(), Is.EqualTo(new int[] { 1, 2, 3, 4, 5 }));
        }

        [Test]
        public void FullDatabaseThrowsExceptionWhenAddingMoreItems()
        {
            // Arrange
            var db = new Database();

            for (int i = 0; i < 16; i++)
            {
                db.Add(i);
            }

            // Act
            // Assert
            Assert.That(() => db.Add(7), Throws.InvalidOperationException
                .With
                .Message
                .EqualTo("The Database is full!"));
        }

        [Test]
        public void RemoveLastItemFromDatabase()
        {
            // Arrange
            var db = new Database(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11);

            // Act
            db.Remove();

            // Assert
            Assert.That(() => db.Fetch().Last(), Is.EqualTo(10));
        }

        [Test]
        public void RemovingItemFromEmptyDatabaseThrowsException()
        {
            // Arrange
            var db = new Database();

            // Act
            // Assert
            Assert.That(() => db.Remove(), Throws.InvalidOperationException
                .With
                .Message
                .EqualTo("The Database if empty!"));
        }

        [Test]
        public void FetchEmptyDatabaseReturnsEmptyCollection()
        {
            // Arrange
            var db = new Database();

            // Act
            // Assert
            Assert.That(db.Fetch(), Is.EqualTo(new int[0]));
        }
    }
}