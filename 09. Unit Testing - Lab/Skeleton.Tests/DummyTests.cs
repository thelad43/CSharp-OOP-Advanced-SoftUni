namespace Skeleton.Tests
{
    using NUnit.Framework;

    public class DummyTests
    {
        private const int InitialDummyHealth = 10;
        private const int DeadDummyHealth = 0;
        private const int InitialDummyXp = 25;
        private const int PointsToAttack = 5;
        private const int ExpectedHealth = 5;
        private const int ExpectedXp = 25;

        private Dummy dummy;

        [Test]
        public void DummyLosesHealthWhenAttacked()
        {
            // Arrange
            this.dummy = new Dummy(InitialDummyHealth, InitialDummyXp);

            // Act
            this.dummy.TakeAttack(PointsToAttack);

            // Assert
            Assert.That(this.dummy.Health, Is.EqualTo(ExpectedHealth),
                "Dummy doesn't lose health after attack.");
        }

        [Test]
        public void DeadDummyThrowsExceptionWhenAttacked()
        {
            // Arrange
            this.dummy = new Dummy(DeadDummyHealth, InitialDummyXp);

            // Act
            // Assert
            Assert.That(() => this.dummy.TakeAttack(PointsToAttack), Throws.InvalidOperationException
                .With
                .Message
                .EqualTo("Dummy is dead."),
                "Dummy doesn't throw exception when is dead and attacked.");
        }

        [Test]
        public void DeadDummyGivesXp()
        {
            // Arrange
            this.dummy = new Dummy(DeadDummyHealth, InitialDummyXp);

            // Act
            var actualXp = this.dummy.GiveExperience();

            // Assert
            Assert.That(actualXp, Is.EqualTo(ExpectedXp),
                "Dead Dummy doesn't give XP.");
        }

        [Test]
        public void AliveDummyCannotGiveXp()
        {
            // Arrange
            this.dummy = new Dummy(InitialDummyHealth, InitialDummyXp);

            // Act
            // Assert
            Assert.That(() => this.dummy.GiveExperience(), Throws.InvalidOperationException
                .With
                .Message
                .EqualTo("Target is not dead."),
                "Alive Dummy gives XP.");
        }
    }
}