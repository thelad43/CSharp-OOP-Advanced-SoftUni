namespace UnitTestingExercise.Tests
{
    using _09._DateTimeProblem;
    using Moq;
    using NUnit.Framework;
    using System;

    internal class DateTimeTests
    {
        private Mock<IClock> time;

        [SetUp]
        public void TestInit()
        {
            this.time = new Mock<IClock>();
        }

        [Test]
        public void GetCurrentTime()
        {
            // Arrange
            // Act
            this.time.SetupGet(x => x.Now).Returns(DateTime.Now);

            // Assert
            Assert.AreEqual(DateTime.Now.ToShortTimeString(), this.time.Object.Now.ToShortTimeString());
        }

        [Test]
        public void AddDayThatJumpsToNextMonth()
        {
            // Arrange
            this.time.SetupProperty(x => x.Now, new DateTime(2018, 06, 30));

            // Act
            var dummyClock = this.time.Object.Now.AddDays(1);

            // Assert
            Assert.IsTrue(dummyClock.Month == 7 && dummyClock.Day == 1);
        }

        [Test]
        public void AddNegativeDays()
        {
            // Arrange
            this.time.SetupProperty(x => x.Now, new DateTime(2017, 08, 31));

            // Act
            var dummyClock = this.time.Object.Now.AddDays(-10);

            // Assert
            Assert.IsTrue(dummyClock.Month == 8 && dummyClock.Day == 21);
        }

        [Test]
        public void AddNegativeDaysThatJumpBackAMonth()
        {
            // Arrange
            this.time.SetupProperty(x => x.Now, new DateTime(2017, 08, 31));

            // Act
            var dummyClock = this.time.Object.Now.AddDays(-31);

            // Assert
            Assert.IsTrue(dummyClock.Month == 7 && dummyClock.Day == 31);
        }

        [Test]
        public void AddDayToLeapYearMonth()
        {
            // Arrange
            this.time.SetupProperty(x => x.Now, new DateTime(2008, 02, 28));

            // Act
            var dummyClock = this.time.Object.Now.AddDays(1);

            // Assert
            Assert.IsTrue(dummyClock.Month == 2 && dummyClock.Day == 29);
        }

        [Test]
        public void AddDayToNonLeapYearMonth()
        {
            // Arrange
            this.time.SetupProperty(x => x.Now, new DateTime(1900, 02, 28));

            // Act
            var dummyClock = this.time.Object.Now.AddDays(1);

            // Assert
            Assert.IsTrue(dummyClock.Month == 3 && dummyClock.Day == 1);
        }

        [Test]
        public void AddDayToDateTimeMinValue()
        {
            // Arrange
            // Act
            this.time.SetupProperty(x => x.Now, DateTime.MinValue);

            // Assert
            Assert.DoesNotThrow(() => this.time.Object.Now.AddDays(1));
        }

        [Test]
        public void SubtractDayToDateTimeMinValue()
        {
            // Arrange
            // Act
            this.time.SetupProperty(x => x.Now, DateTime.MinValue);

            // Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => this.time.Object.Now.AddDays(-1));
        }

        [Test]
        public void AddDayToDateTimeMaxValue()
        {
            // Arrange
            // Act
            this.time.SetupProperty(x => x.Now, DateTime.MaxValue);

            // Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => this.time.Object.Now.AddDays(1));
        }

        [Test]
        public void SubtractDayToDateTimeMaxValue()
        {
            // Arrange
            // Act
            this.time.SetupProperty(x => x.Now, DateTime.MaxValue);

            // Assert
            Assert.DoesNotThrow(() => this.time.Object.Now.AddDays(-1));
        }
    }
}