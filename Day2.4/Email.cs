namespace Day2._4
{
    internal partial class Program
    {
        public class Email : INotification
        {
            public void Send(string message)
            {
                Console.WriteLine($"Email: {message}");
            }
        }
    }
}
