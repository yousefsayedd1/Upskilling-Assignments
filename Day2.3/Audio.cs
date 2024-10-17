namespace Day2._3
{
    public class Audio : IPlayable
    {
        public void Play()
        {
            Console.WriteLine("Aduio Played");
        }

        public void Stop()
        {
            Console.WriteLine("Aduio Stoped");
        }
    }
}
