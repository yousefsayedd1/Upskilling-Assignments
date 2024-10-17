namespace Day2._4
{
    internal partial class Program
    {
        public class PushNotification : INotification
        {
            public void Send(string message)
            {
                Console.WriteLine($"Notification: {message}");
            }
        }
    }
}
