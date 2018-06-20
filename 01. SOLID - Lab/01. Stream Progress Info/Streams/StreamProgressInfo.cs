namespace _01._Stream_Progress_Info.Streams
{
    using Interfaces;

    public class StreamProgressInfo
    {
        private readonly IStreamable streamable;

        public StreamProgressInfo(IStreamable streamable)
        {
            this.streamable = streamable;
        }

        public int CalculateCurrentPercent()
        {
            return (this.streamable.BytesSent * 100) / this.streamable.Length;
        }
    }
}