namespace _02.BankAccounts
{
    using System;

    public class DepositAccount : Account
    {
        public DepositAccount(CustomerType customer, decimal balance = 0, decimal interestRate = 0)
            : base(customer, balance, interestRate)
        {
        }

        public void Withdraw(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("Withdraw amount cannot be negative!");
            }

            this.Balance -= amount;
        }

        //Deposit accounts have no interest if their balance is positive and less than 1000.
        public override decimal CalculateInterestAmount(int periodInMonths)
        {
            if (this.Balance < 1000)
            {
                return 0;
            }
            else
            {
                return base.CalculateInterestAmount(periodInMonths);
            }
        }
    }
}
