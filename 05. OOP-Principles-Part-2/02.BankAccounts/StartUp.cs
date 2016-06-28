namespace _02.BankAccounts
{
    using _02.BankAccounts.Common;
    using System;

    class StartUp
    {
        static void Main()
        {
            Deposit depositAccount = new Deposit(CustomerType.companie, 1250, 5);
            Console.WriteLine("Interest amount on a {0} {1} account\nfor 12 months: ${2}"
                , depositAccount.Customer.ToString()
                , depositAccount.GetType().Name
                , depositAccount.CalculateInterestAmount(12));

            Console.WriteLine();

            Loan loanAccount = new Loan(CustomerType.individual, 30000, 50);
            Console.WriteLine("Interest amount on a {0} {1} account\nfor 3 months: ${2}"
               , loanAccount.Customer.ToString()
               , loanAccount.GetType().Name
               , loanAccount.CalculateInterestAmount(3));

            Console.WriteLine();

            Mortgage mortgageAccount = new Mortgage(CustomerType.companie, 100000, 12);
            Console.WriteLine("Interest amount on a {0} {1} account\nfor 12 months: ${2}"
                , mortgageAccount.Customer.ToString()
                , mortgageAccount.GetType().Name
                , mortgageAccount.CalculateInterestAmount(12));
        }
    }
}
