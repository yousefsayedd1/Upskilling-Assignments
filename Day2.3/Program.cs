namespace Day2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPlayable[] playables = { new Audio(), new Video() };
            foreach (var playable in playables)
            {
                MediaPlayer Player = new MediaPlayer(playable);
                Player.Play();
                Player.Stop();
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
