namespace UnitTestingExercise.Tests
{
    using NUnit.Framework;
    using System;

    public class HackTests
    {
        [Test]
        public void MathAbs()
        {
            // Arrange
            var a = -5.8;
            var b = -78;
            var c = 9;

            var expectedA = 5.8;
            var expectedB = 78;
            var expectedC = 9;

            // Act
            a = Math.Abs(a);
            b = Math.Abs(b);
            c = Math.Abs(c);

            // Assert
            Assert.AreEqual(expectedA, a);
            Assert.AreEqual(expectedB, b);
            Assert.AreEqual(expectedC, c);
        }

        [Test]
        public void MathFloor()
        {
            // Arrange
            var a = 5.899;
            var b = -78.253;
            var c = 9.456;

            var expectedA = 5;
            var expectedB = -79;
            var expectedC = 9;

            // Act
            var actualA = Math.Floor(a);
            var actualB = Math.Floor(b);
            var actualC = Math.Floor(c);

            // Assert
            Assert.AreEqual(expectedA, actualA);
            Assert.AreEqual(expectedB, actualB);
            Assert.AreEqual(expectedC, actualC);
        }
    }
}