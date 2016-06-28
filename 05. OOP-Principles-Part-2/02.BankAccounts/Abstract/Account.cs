namespace _02.BankAccounts.Abstract
{
    using _02.BankAccounts.Common;

    public abstract class Account
    {
        private CustomerType customer;
        private double balance;
        private double interstRate;

        public Account(CustomerType customer, double balance, double interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }
        public CustomerType Customer
        {
            get { return this.customer; }
            set { this.customer = value; }
        }
        public double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }

        }
        public double InterestRate
        {
            get { return this.interstRate; }
            set { this.interstRate = value; }

        }

        public abstract double DepositMoney(double amount);

        public virtual double CalculateInterestAmount(int numberOfMonths)
        {
            double interestAmount = numberOfMonths * this.InterestRate;
            return interestAmount;
        }
    }
}
