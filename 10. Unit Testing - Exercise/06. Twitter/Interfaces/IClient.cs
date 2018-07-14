namespace _06._Twitter.Interfaces
{
    public interface IClient
    {
        void WriteTweet(string message);

        void SendTweetToServer(string message);
    }
}