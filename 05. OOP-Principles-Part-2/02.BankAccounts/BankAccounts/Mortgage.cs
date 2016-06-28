namespace _02.BankAccounts
{
    using _02.BankAccounts.Abstract;
    using _02.BankAccounts.Common;

    public class Mortgage : Account
    {
        public Mortgage(CustomerType customer, double balance, double interestRate) : base(customer, balance, interestRate)
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
                interestAmount = (numberOfMonths - Constants.noInterestMortageIndividuals) * this.InterestRate;

            }
            else if (Customer == CustomerType.companie)
            {
                if (numberOfMonths <= 12)
                {
                    interestAmount = numberOfMonths * (this.InterestRate / 2);
                }
                else if (numberOfMonths > 12)
                {
                    interestAmount = numberOfMonths * (this.InterestRate / 2);
                    interestAmount += (numberOfMonths - 12) * this.InterestRate;
                }
            }
            return interestAmount;
        }
    }
}
