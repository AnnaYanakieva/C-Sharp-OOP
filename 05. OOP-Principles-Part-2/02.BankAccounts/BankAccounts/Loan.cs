namespace _02.BankAccounts
{
    using _02.BankAccounts.Abstract;
    using _02.BankAccounts.Common;

    public class Loan : Account
    {
        public Loan(CustomerType customer, double balance, double interestRate) : base(customer, balance, interestRate)
        {
        }

        public override double DepositMoney(double amount)
        {
            this.Balance += amount;
            return this.Balance;
        }

        public override double CalculateInterestAmount(int numberOfMonths)
        {
            double interestAmount = 0;

            if (Customer == CustomerType.individual)
            {
                interestAmount = (numberOfMonths - Constants.noInterestLoansIndividuals) * this.InterestRate;
            }
            else if (Customer == CustomerType.companie)
            {
                interestAmount = (numberOfMonths - Constants.noInterestLoansCompanies) * this.InterestRate;

            }
            return interestAmount;
        }
    }
}
