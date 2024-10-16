using Interfaces;

namespace Day2
{
    public class BankTransfer : IPayable
    {
        public void pay()
        {
            Console.WriteLine("You paid by a Band Transfer");
        }
    }
}
