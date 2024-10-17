using Interfaces;

namespace Day2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int paymentMethodNumber = SelectPaymentMethod();
            IPayable[] paymentsMethods = { new CreditCardPayment(), new BankTransfer(), new PayPal() };
            paymentsMethods[paymentMethodNumber - 1].pay();


        }
        static int SelectPaymentMethod()
        {
            bool isValidPaymentMethodNumber = true;
            int paymentMethodNumber;
            int numberOfPaymentsMethods = 3;
            do
            {
                if (!isValidPaymentMethodNumber)
                    Console.WriteLine("invalid input try again");
                Console.WriteLine("Chose a Payment method Number: ");
                Console.WriteLine("1. Credit Card\n2. BankTransfer\n3. PayPal");

                isValidPaymentMethodNumber = InputValidation.IsNumberAndInRange(Console.ReadLine(), 1, numberOfPaymentsMethods, out paymentMethodNumber);

            } while (!isValidPaymentMethodNumber);
            return paymentMethodNumber;
        }

    }
}
