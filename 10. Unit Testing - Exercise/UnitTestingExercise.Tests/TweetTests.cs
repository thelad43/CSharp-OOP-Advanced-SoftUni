namespace UnitTestingExercise.Tests
{
    using _06._Twitter.Interfaces;
    using _06._Twitter.Models;
    using Moq;
    using NUnit.Framework;

    public class TweetTests
    {
        [Test]
        public void ReceiveMessageShouldInvokeItsClientToWriteTheMessage()
        {
            // Arrange
            var client = new Mock<IClient>();
            client.Setup(c => c.WriteTweet(It.IsAny<string>()));
            var tweet = new Tweet(client.Object);

            // Act
            tweet.ReceiveMessage("Test");

            // Assert
            client.Verify(c => c.WriteTweet(It.IsAny<string>()), Times.Once);
        }

        [Test]
        public void ReceiveMessageShouldInvokeItsClientToSendTheMessageToTheServer()
        {
            // Arrange
            var client = new Mock<IClient>();
            client.Setup(c => c.SendTweetToServer(It.IsAny<string>()));
            var tweet = new Tweet(client.Object);

            // Act
            tweet.ReceiveMessage("Test");

            // Assert
            client.Verify(c => c.SendTweetToServer(It.IsAny<string>()), Times.Once);
        }
    }
}