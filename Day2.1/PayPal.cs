using Interfaces;

namespace Day2
{
    public class PayPal : IPayable
    {

        public void pay()
    {
        Console.WriteLine("You paid by PayPal");
    }
}
}
