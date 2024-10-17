using Interfaces;

namespace Day2
{
    public class CreditCardPayment : IPayable
    {
        public void pay()
        {
            Console.WriteLine("You paid by CreditCard");
        }
    }
}
