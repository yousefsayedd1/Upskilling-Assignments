namespace Day2._4
{
    internal partial class Program
    {
        // why interface vs abstract class:
        // 1. there is no shared data or methods
        public interface INotification
        {
            void Send(string message);
        }
    }
}
