namespace Day2._4
{
    internal partial class Program
    {
        public class Notifier
        {
            private readonly INotification _notificationMethod;
            public Notifier(INotification notificationMethod)
            {
                _notificationMethod = notificationMethod;
            }
            public void Notify(string message)
            {
                _notificationMethod.Send(message);
            }
        }
    }
}
