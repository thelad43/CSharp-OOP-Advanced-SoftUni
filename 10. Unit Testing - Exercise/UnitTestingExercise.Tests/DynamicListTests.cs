namespace UnitTestingExercise.Tests
{
    using _08._Custom_Linked_List;
    using NUnit.Framework;
    using System;

    public class DynamicListTests
    {
        private DynamicList<int> dynamicList;

        [SetUp]
        public void TestInit()
        {
            this.dynamicList = new DynamicList<int>();
        }

        [Test]
        public void CannotCallElementWithNegativeIndex()
        {
            // Arrange
            var incorrectIndex = -1;

            // Act
            // Assert
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                var test = this.dynamicList[incorrectIndex];
            });
        }

        [Test]
        public void CannotCallElementWithIndexAboveTheRange()
        {
            // Arrange
            var incorrectIndex = 1;

            // Act
            // Assert
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                var test = this.dynamicList[incorrectIndex];
            });
        }

        [Test]
        public void AddShouldIncreaseCollectionCount()
        {
            // Arrange
            // Act
            this.dynamicList.Add(1);

            // Assert
            Assert.AreEqual(1, this.dynamicList.Count);
        }

        [Test]
        [TestCase(2, 0)]
        [TestCase(5, 3)]
        [TestCase(10, 8)]
        [TestCase(15, 14)]
        public void AddShouldSaveTheElementInTheCollection(int numberOfAdditions, int indexToCheck)
        {
            // Arrange
            // Act
            this.AddElements(numberOfAdditions);

            // Assert
            Assert.AreEqual(indexToCheck, this.dynamicList[indexToCheck]);
        }

        [Test]
        [TestCase(-1)]
        [TestCase(1)]
        [TestCase(-5)]
        [TestCase(5)]
        public void RemoveAtIndexOusideTheBoundariesOfTheCollectionIsImpossible(int indexToRemove)
        {
            // Arrange
            // Act
            // Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => this.dynamicList.RemoveAt(indexToRemove));
        }

        [Test]
        [TestCase(3, 1)]
        [TestCase(10, 5)]
        [TestCase(10, 0)]
        [TestCase(10, 8)]
        public void RemoveAtShouldRemoveTheElementAtTheGivenIndex(int numberOfAdditions, int indexToRemove)
        {
            // Arrange
            this.AddElements(numberOfAdditions);

            // Act
            this.dynamicList.RemoveAt(indexToRemove);

            // Assert
            Assert.AreEqual(indexToRemove + 1, dynamicList[indexToRemove]);
        }

        [Test]
        [TestCase(3, 1)]
        [TestCase(5, 4)]
        [TestCase(10, 7)]
        public void IndexOfShouldReturnTheIndexPointingAtTheCurrentLocationOfTheElement(int numberOfAdditions, int keyElement)
        {
            // Arrange
            this.AddElements(numberOfAdditions);
            var expectedIndex = keyElement;

            // Act
            var foundIndex = this.dynamicList.IndexOf(keyElement);

            // Assert
            Assert.AreEqual(expectedIndex, foundIndex);
        }

        [Test]
        [TestCase(3, 3)]
        [TestCase(5, -1)]
        [TestCase(10, 15)]
        public void IndexOfShouldReturnNegativeIntegerIfTheGivenElementDoesNotExists(int numberOfAdditions, int keyElement)
        {
            // Arrange
            this.AddElements(numberOfAdditions);

            // Act
            var isReturnedValueLessThanZero = this.dynamicList.IndexOf(keyElement) < 0;

            // Assert
            Assert.IsTrue(isReturnedValueLessThanZero);
        }

        [Test]
        [TestCase(3, 1)]
        [TestCase(10, 5)]
        [TestCase(10, 0)]
        [TestCase(10, 8)]
        [TestCase(10, 9)]
        public void RemoveShouldDeleteParticularElement(int numberOfAdditions, int elementToRemove)
        {
            // Arrange
            this.AddElements(numberOfAdditions);

            // Act
            this.dynamicList.Remove(elementToRemove);

            // Assert
            Assert.AreEqual(-1, this.dynamicList.IndexOf(elementToRemove));
        }

        [Test]
        [TestCase(3, 3)]
        [TestCase(3, -1)]
        [TestCase(3, 10)]
        public void RemoveUnexistentEelementShouldReturnNegativeInteger(int numberOfAdditions, int elementToRemove)
        {
            // Arrange
            this.AddElements(numberOfAdditions);

            // Act
            var isRemovingResultLesThanZero = this.dynamicList.Remove(elementToRemove) < 0;

            // Assert
            Assert.IsTrue(isRemovingResultLesThanZero);
        }

        [Test]
        [TestCase(3, 1)]
        [TestCase(5, 4)]
        [TestCase(10, 7)]
        public void RemoveShouldReturnTheIndexOfTheRemovedElement(int numberOfAdditions, int elementToRemove)
        {
            // Arrange
            this.AddElements(numberOfAdditions);
            var expectedIndex = elementToRemove;

            // Act
            var returnedIndex = this.dynamicList.Remove(elementToRemove);

            // Assert
            Assert.AreEqual(expectedIndex, returnedIndex);
        }

        [Test]
        [TestCase(3, 1)]
        [TestCase(5, 4)]
        [TestCase(10, 7)]
        public void ContainsShouldReturnTrueIfElementExists(int numberOfAdditions, int keyElement)
        {
            // Arrange
            this.AddElements(numberOfAdditions);

            // Act
            // Assert
            Assert.IsTrue(this.dynamicList.Contains(keyElement));
        }

        [Test]
        [TestCase(3, 3)]
        [TestCase(5, 10)]
        [TestCase(10, 15)]
        public void ContainsShouldReturnfalseIfElementDoesNotExists(int numberOfAdditions, int keyElement)
        {
            // Arrange
            this.AddElements(numberOfAdditions);

            // Act
            // Assert
            Assert.IsFalse(this.dynamicList.Contains(keyElement));
        }

        private void AddElements(int numberOfAdditions)
        {
            for (int i = 0; i < numberOfAdditions; i++)
            {
                this.dynamicList.Add(i);
            }
        }
    }
}