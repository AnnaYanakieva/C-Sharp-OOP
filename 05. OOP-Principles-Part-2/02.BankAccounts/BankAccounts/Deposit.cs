namespace _02.BankAccounts
{
    using _02.BankAccounts.Abstract;
    using _02.BankAccounts.Contracts;
    using Common;
    
    public class Deposit : Account, IWithDrawMoney
    {
        public Deposit(CustomerType customer, double balance, double interestRate) : base(customer, balance, interestRate)
        {

        }
        public override double CalculateInterestAmount(int numberOfMonths)
        {
            double interestAmount = 0;
            if (Balance > 0 && Balance < 1000)
            {
                this.InterestRate = 0;
            }
            interestAmount = this.InterestRate * numberOfMonths;
            return interestAmount;
        }

        public override double DepositMoney(double amount)
        {
            this.Balance += amount;
            return this.Balance;
        }

        public double WithDrawMoney(double amount)
        {
            this.Balance -= amount;
            return this.Balance;
        }        
    }
}
