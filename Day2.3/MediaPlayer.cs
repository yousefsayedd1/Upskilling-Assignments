namespace Day2._3
{
    public class MediaPlayer
    {
        private IPlayable _playable;
        public MediaPlayer(IPlayable playable)
        {
            _playable = playable;
        }
        public void Play()
        {
            _playable.Play();
        }
        public void Stop()
        {
            _playable.Stop();
        }

    }
}
