namespace Upskilling
{
    public class BankAccount
    {
        public int AccountNumber { get; }
        public string AccountHolderName { get; set; }
        private decimal _balance;
        public decimal Balance
        {
            get { return _balance; }
            private set
            {
                if (value <= 0)
                {
                    throw new Exception();
                }
                _balance = value;
            }
        }
        public BankAccount(int acountNumber)
        {
            AccountNumber = acountNumber;
        }
        public void Deposit(decimal depositeAmount)
        {
            Balance += depositeAmount;
        }
        public void Withdraw(decimal withdrawAmount)
        {
            Balance -= withdrawAmount;
        }
    }
}