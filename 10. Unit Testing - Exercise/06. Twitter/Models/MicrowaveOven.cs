namespace _06._Twitter.Models
{
    using Interfaces;

    public class MicrowaveOven : IClient
    {
        private readonly IWriter writer;
        private readonly ITweetRepository tweetRepository;

        public MicrowaveOven(IWriter writer, ITweetRepository tweetRepository)
        {
            this.writer = writer;
            this.tweetRepository = tweetRepository;
        }

        public void SendTweetToServer(string message) => this.tweetRepository.SaveTweet(message);

        public void WriteTweet(string message) => this.writer.WriteLine(message);
    }
}