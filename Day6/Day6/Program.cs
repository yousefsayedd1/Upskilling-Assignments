namespace Day6
{
    internal class Program
    {
        static private Customer CaptureCustomerData()
        {
            string name, mobile, email;
            Console.Write("Enter Customer Name: ");
            name = Console.ReadLine();
            Console.Write("Enter Customer Mobile: ");
            mobile = Console.ReadLine();
            Console.Write("Enter Customer Email: ");
            email = Console.ReadLine();
            return new Customer(name,mobile,email);
        }
        static void Main(string[] args)
        {
            List<Customer> Customers = new List<Customer>();

            while (true)
            {
                Customer customer = CaptureCustomerData();
                Customers.Add(customer);
                Console.WriteLine("wanna add another customer? Y for Yes and N for No");
                if (Console.ReadLine()?.ToUpperInvariant() != "Y") break;
            }
            PerformActionOnCustomers(Customers, (custormer) => Console.WriteLine(custormer.ToString()));
            PerformActionOnCustomers(Customers, (customer) => Console.WriteLine($"Welcome {customer.Name}"));

        }
        static void PerformActionOnCustomers(List<Customer> customers, Action<Customer> action)
        {
            foreach (Customer customer in customers)
            {
                action(customer);
            }
        }
    }
}
