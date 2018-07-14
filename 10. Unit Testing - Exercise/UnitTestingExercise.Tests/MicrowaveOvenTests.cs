namespace UnitTestingExercise.Tests
{
    using _06._Twitter.Interfaces;
    using _06._Twitter.Models;
    using Moq;
    using NUnit.Framework;

    public class MicrowaveOvenTests
    {
        private const string Message = "Test";

        [Test]
        public void SendTweetToServerShouldSendTheMessageToItsServer()
        {
            // Arrange
            var writer = new Mock<IWriter>();
            var tweetRepo = new Mock<ITweetRepository>();
            tweetRepo.Setup(tr => tr.SaveTweet(It.IsAny<string>()));
            var microwaveOven = new MicrowaveOven(writer.Object, tweetRepo.Object);

            // Act
            microwaveOven.SendTweetToServer(Message);

            // Assert
            tweetRepo.Verify(tr => tr.SaveTweet(It.Is<string>(s => s == Message)), Times.Once);
        }

        [Test]
        public void WriteTweetShouldCallItsWriterWithTheTweetsMessage()
        {
            // Arrange
            var writer = new Mock<IWriter>();
            writer.Setup(w => w.WriteLine(It.IsAny<string>()));
            var tweetRepo = new Mock<ITweetRepository>();
            var microwaveOven = new MicrowaveOven(writer.Object, tweetRepo.Object);

            // Act
            microwaveOven.WriteTweet(Message);

            // Assert
            writer.Verify(w => w.WriteLine(It.Is<string>(s => s == Message)));
        }
    }
}