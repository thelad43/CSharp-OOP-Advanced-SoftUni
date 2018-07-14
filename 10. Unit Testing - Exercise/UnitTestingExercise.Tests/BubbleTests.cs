namespace UnitTestingExercise.Tests
{
    using _04._Bubble_Sort_Test;
    using NUnit.Framework;
    using System.Collections.Generic;
    using System.Linq;

    public class BubbleTests
    {
        [Test]
        public void SortBubbleList()
        {
            // Arrange
            var bubble = new Bubble<int>(new int[] { 7, 8, 1, 6, 2, 15 });
            var numbers = new List<int>() { 1, 2, 6, 7, 8, 15 };

            // Act
            // Assert
            Assert.IsTrue(numbers.SequenceEqual(bubble));
        }

        [Test]
        public void SortBubbleList2()
        {
            // Arrange
            var bubble = new Bubble<int>(new int[] { 100, 50, 800, 25 });
            var numbers = new List<int>() { 25, 50, 100, 800 };

            // Act
            // Assert
            Assert.IsTrue(numbers.SequenceEqual(bubble));
        }
    }
}