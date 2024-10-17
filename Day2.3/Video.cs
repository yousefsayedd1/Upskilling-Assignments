namespace Day2._3
{
    public class Video : IPlayable
    {
        public void Play()
        {
            Console.WriteLine("Video Played");

        }

        public void Stop()
        {
            Console.WriteLine("Video Stopped");

        }
    }
}
