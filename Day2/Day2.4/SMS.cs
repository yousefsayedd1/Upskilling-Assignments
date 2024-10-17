namespace Day2._4
{
    internal partial class Program
    {
        public class SMS : INotification
        {
            public void Send(string message)
            {
                Console.WriteLine($"SMS: {message}");
            }
        }
    }
}
