namespace _02.BankAccounts
{
    using System;

    public class LoanAccount : Account
    {
        public LoanAccount(CustomerType customer, decimal balance = 0, decimal interestRate = 0)
            : base(customer, balance, interestRate)
        {
        }

        //Loan accounts have no interest for the first 3 months if are held by individuals and 
        //for the first 2 months if are held by a company.
        public override decimal CalculateInterestAmount(int periodInMonths)
        {
            switch (Customer)
            {
                case CustomerType.Individual:
                    if (periodInMonths < 3)
                    {
                        return 0;
                    }
                    else
                    {
                        return base.CalculateInterestAmount(periodInMonths - 3);
                    }

                case CustomerType.Company:
                    if (periodInMonths < 2)
                    {
                        return 0;
                    }
                    else
                    {
                        return base.CalculateInterestAmount(periodInMonths - 2);
                    }

                default:
                    throw new ArgumentException("Invalid customer!");
            }
        }
    }
}
