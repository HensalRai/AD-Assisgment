namespace Exercise2
{
    internal class BankAccount
    {
        private string accountNumber;
        private decimal balance;

        internal BankAccount(string accountNumber)
        {
            this.accountNumber = accountNumber;
            this.balance = 0.0;
        }

        internal void Deposit(decimal amount)
        {
            this.balance += amount;
        }

        internal void Withdraw(decimal amount) 
        {
            this.balance -= amount;
        }
        static void Main(string[] args)
        {
            BankAccount bankAccount = new("Ram");
            bankAccount.Deposit(1000);
            bankAccount.Withdraw(500);
            Console.WriteLine("Account number " + bankAccount.accountNumber + "\nBalance: " + bankAccount.balance);

        }
    }
}