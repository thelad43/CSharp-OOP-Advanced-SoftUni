namespace Skeleton.Tests
{
    using Interfaces;
    using Moq;
    using NUnit.Framework;

    public class HeroTests
    {
        private const string HeroName = "Ted";

        [Test]
        public void HeroGainsExperienceAfterAttackIfTargetDiesWithMoq()
        {
            // Arrange
            var fakeTarget = new Mock<ITarget>();
            fakeTarget.Setup(ft => ft.Health).Returns(0);
            fakeTarget.Setup(ft => ft.GiveExperience()).Returns(10);
            fakeTarget.Setup(ft => ft.IsDead()).Returns(true);

            var fakeWeapon = new Mock<IWeapon>();
            var hero = new Hero(HeroName, fakeWeapon.Object);

            // Act
            hero.Attack(fakeTarget.Object);

            // Assert
            Assert.AreEqual(10, hero.Experience);
        }
    }
}