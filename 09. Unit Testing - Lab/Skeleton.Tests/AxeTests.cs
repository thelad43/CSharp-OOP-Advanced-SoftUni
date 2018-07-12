namespace Skeleton.Tests
{
    using NUnit.Framework;

    public class AxeTests
    {
        private Axe axe;
        private Dummy dummy;

        [Test]
        public void AxeLosesDurabilityAfterAttack()
        {
            // Arrange
            var initialDurability = 5;
            var axeAttack = 3;
            this.axe = new Axe(axeAttack, initialDurability);

            var initialDummyHealth = 15;
            var dummyXp = 8;
            this.dummy = new Dummy(initialDummyHealth, dummyXp);

            var expectedDurability = 4;

            // Act
            this.axe.Attack(this.dummy);

            // Assert
            Assert.That(expectedDurability, Is.EqualTo(this.axe.DurabilityPoints),
                "Axe Durability doesn't change after attack.");
        }

        [Test]
        public void AttackWithBrokenAxeShouldThrowException()
        {
            // Arrange
            var initialDurability = 1;
            var axeAttack = 5;
            this.axe = new Axe(axeAttack, initialDurability);

            var initialDummyHealth = 5;
            var dummyXp = 5;
            this.dummy = new Dummy(initialDummyHealth, dummyXp);

            // Act
            this.axe.Attack(this.dummy);

            // Assert
            Assert.That(() => this.axe.Attack(this.dummy),
                Throws.InvalidOperationException.With.Message.EqualTo("Axe is broken."),
                "Attack with broken axe doesn't throw exception.");
        }
    }
}