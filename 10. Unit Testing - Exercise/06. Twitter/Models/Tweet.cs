namespace _06._Twitter.Models
{
    using Interfaces;

    public class Tweet : ITweet
    {
        private readonly IClient client;

        public Tweet(IClient client)
        {
            this.client = client;
        }

        public void ReceiveMessage(string message)
        {
            this.client.WriteTweet(message);
            this.client.SendTweetToServer(message);
        }
    }
}