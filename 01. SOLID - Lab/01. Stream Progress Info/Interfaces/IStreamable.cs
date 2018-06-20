namespace _01._Stream_Progress_Info.Interfaces
{
    public interface IStreamable
    {
        int Length { get; }

        int BytesSent { get; }
    }
}