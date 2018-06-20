namespace _01._Stream_Progress_Info
{
    using Models;
    using Streams;
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var file = new File("File name", 1234, 123);
            var fileProcessInfo = new StreamProgressInfo(file);
            Console.WriteLine(fileProcessInfo.CalculateCurrentPercent());

            var music = new Music("Singer", "Album", 123456, 12349);
            var musicProcessInfo = new StreamProgressInfo(music);
            Console.WriteLine(musicProcessInfo.CalculateCurrentPercent());
        }
    }
}