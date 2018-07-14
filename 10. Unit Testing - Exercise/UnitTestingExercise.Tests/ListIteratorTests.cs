namespace UnitTestingExercise.Tests
{
    using _03._Iterator_Test;
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    public class ListIteratorTests
    {
        private const string EmptyDataExceptionMessage = "The data cannot be null!";

        private ListIterator listIterator;

        [SetUp]
        public void TestInit()
        {
            var list = new List<string>()
            {
                "aaaaa",
                "bbb",
                "cccc",
                "xxxxx",
            };

            this.listIterator = new ListIterator(list);
        }

        [Test]
        public void CreateListIteratorWithNullDataShouldThrowException()
        {
            // Arrange
            // Act
            // Assert
            Assert.That(() => new ListIterator(null), Throws.ArgumentNullException
                .With
                .Message
                .EqualTo(EmptyDataExceptionMessage + Environment.NewLine + "Parameter name: data"));
        }

        [Test]
        public void CreateListIteratorWithEmptyDataShouldThrowException()
        {
            // Arrange
            // Act
            // Assert
            Assert.That(() => new ListIterator(new List<string>()), Throws.ArgumentNullException
                .With
                .Message
                .EqualTo(EmptyDataExceptionMessage + Environment.NewLine + "Parameter name: data"));
        }

        [Test]
        public void MoveValid()
        {
            // Arrange
            // Act
            for (int i = 0; i < 3; i++)
            {
                var moved = this.listIterator.Move();

                // Assert
                Assert.IsTrue(moved);
            }
        }

        [Test]
        public void HasNextValid()
        {
            // Arrange
            // Act
            for (int i = 0; i < 3; i++)
            {
                var hasNext = this.listIterator.HasNext();
                this.listIterator.Move();

                // Assert
                Assert.IsTrue(hasNext);
            }
        }

        [Test]
        public void MoveInvalid()
        {
            // Arrange
            // Act
            for (int i = 0; i < 3; i++)
            {
                var moved = this.listIterator.Move();
            }

            // Assert
            Assert.IsFalse(this.listIterator.Move());
        }

        [Test]
        public void HasNextInvalid()
        {
            // Arrange
            // Act
            for (int i = 0; i < 3; i++)
            {
                var hasNext = this.listIterator.HasNext();
                this.listIterator.Move();
            }

            for (int i = 0; i < 5; i++)
            {
                // Assert
                Assert.IsFalse(this.listIterator.HasNext());
                this.listIterator.Move();
            }
        }
    }
}