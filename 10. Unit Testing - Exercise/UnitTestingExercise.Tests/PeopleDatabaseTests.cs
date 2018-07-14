namespace UnitTestingExercise.Tests
{
    using _02._Extended_Database;
    using NUnit.Framework;
    using System;

    public class PeopleDatabaseTests
    {
        private const string PersonExistsExceptionMessage = "Person already exists!";
        private const string PersonDoesnotExistExceptionMessage = "There is no person corresponding to given one!";
        private const string UsernameIsEmptyOrNullExceptionMessage = "Username cannot be null or empty!";
        private const string IdIsNegativeExceptionMessage = "Id cannot be less than zero!";

        private Database db;

        [SetUp]
        public void TestInit()
        {
            this.db = new Database(new Person(1, "Gosho"), new Person(2, "Pesho"));
        }

        [Test]
        public void AddUser()
        {
            // Arrange
            var expectedCount = 3;

            // Act
            this.db.Add(new Person(3, "Stamat"));

            // Assert
            Assert.AreEqual(expectedCount, this.db.Count);
        }

        [Test]
        public void AddUserWithDuplicatingUsername()
        {
            // Arrange

            // Act
            var ex = Assert.Throws<InvalidOperationException>(() => this.db.Add(new Person(2, "Gosho")));

            // Assert
            Assert.AreEqual(PersonExistsExceptionMessage, ex.Message);
        }

        [Test]
        public void AddUserWithDuplicatingId()
        {
            // Arrange

            // Act
            var ex = Assert.Throws<InvalidOperationException>(() => this.db.Add(new Person(2, "Ivan")));

            // Assert
            Assert.AreEqual(PersonExistsExceptionMessage, ex.Message);
        }

        [Test]
        public void RemoveUser()
        {
            // Arrange

            // Act
            this.db.Remove();

            // Assert
            Assert.AreEqual(1, this.db.Count);
        }

        [Test]
        public void FindPersonByUsername()
        {
            // Arrange

            // Act
            var person = this.db.FindByUsername("Gosho");

            // Assert
            Assert.IsNotNull(person);
        }

        [Test]
        public void FindPersonWithNonExistingUsernameShouldThrowException()
        {
            // Arrange

            // Act
            var ex = Assert.Throws<InvalidOperationException>(() => this.db.FindByUsername("Petkovec"));

            // Assert
            Assert.AreEqual(PersonDoesnotExistExceptionMessage, ex.Message);
        }

        [Test]
        public void FindPersonWithEmptyValueForUsername()
        {
            // Arrange

            // Act
            var ex = Assert.Throws<ArgumentNullException>(() => this.db.FindByUsername(string.Empty));

            // Assert
            Assert.AreEqual(UsernameIsEmptyOrNullExceptionMessage + Environment.NewLine + "Parameter name: UserName", ex.Message);
        }

        [Test]
        public void FindPersonWithNullValueForUsername()
        {
            // Arrange

            // Act
            var ex = Assert.Throws<ArgumentNullException>(() => this.db.FindByUsername(null));

            // Assert
            Assert.AreEqual(UsernameIsEmptyOrNullExceptionMessage + Environment.NewLine + "Parameter name: UserName", ex.Message);
        }

        [Test]
        public void FindExistingPersonById()
        {
            // Arrange

            // Act
            var person = this.db.FindById(2);

            // Assert
            Assert.IsNotNull(person);
        }

        [Test]
        public void FindNonExsitingPersonById()
        {
            // Arrange

            // Act
            var ex = Assert.Throws<InvalidOperationException>(() => this.db.FindById(1024));

            // Assert
            Assert.AreEqual(PersonDoesnotExistExceptionMessage, ex.Message);
        }

        [Test]
        public void FindPersonWithNegativeId()
        {
            // Arrange

            // Act
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => this.db.FindById(-10));

            // Assert
            Assert.AreEqual(IdIsNegativeExceptionMessage + Environment.NewLine + "Parameter name: id", ex.Message);
        }

        [Test]
        public void AddPeopleWithExactNamesCaseSensitive()
        {
            // Arrange

            // Act
            this.db.Add(new Person(200, "Ivan"));
            this.db.Add(new Person(204, "ivan"));
            var first = this.db.FindById(200);
            var second = this.db.FindById(204);

            // Assert
            Assert.AreNotEqual(first, second);
        }
    }
}