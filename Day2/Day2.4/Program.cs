namespace Day2._4
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            INotification[] notificationMethods = { new Email(), new SMS(), new PushNotification() };
            foreach (INotification notification in notificationMethods)
            {
                Notifier notifer = new Notifier(notification);
                notifer.Notify("this is a notify message");
            }
            Console.ReadLine();

        }
    }
}
