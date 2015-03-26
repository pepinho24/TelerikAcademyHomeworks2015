namespace _02.BankAccounts
{
    using System;

    public class MortgageAccount : Account
    {
        public MortgageAccount(CustomerType customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        // Mortgage accounts have ½ interest for the first 12 months for companies and 
        // no interest for the first 6 months for individuals.
        public override decimal CalculateInterestAmount(int periodInMonths)
        {
            switch (Customer)
            {
                case CustomerType.Individual:
                    if (periodInMonths < 6)
                    {
                        return 0;
                    }
                    else
                    {
                        return base.CalculateInterestAmount(periodInMonths - 6);
                    }

                case CustomerType.Company:
                    if (periodInMonths < 12)
                    {
                        return (base.CalculateInterestAmount(periodInMonths) / 2);
                    }
                    else
                    {
                        return ((base.CalculateInterestAmount(12) / 2) + base.CalculateInterestAmount(periodInMonths - 12));
                    }

                default:
                    throw new ArgumentException("Invalid customer!");
            }
        }
    }
}
