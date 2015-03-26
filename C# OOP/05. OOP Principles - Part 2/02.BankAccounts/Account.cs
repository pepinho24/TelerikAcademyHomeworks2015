/*All accounts have customer, balance and interest rate (monthly based).
Deposit accounts are allowed to deposit and with draw money.
Loan and mortgage accounts can only deposit money.
All accounts can calculate their interest amount for a given period (in months).
 * In the common case its is calculated as follows: number_of_months * interest_rate.*/
namespace _02.BankAccounts
{
    using System;
   
    public abstract class Account
    {
        public CustomerType Customer { get; set; }

        public decimal Balance { get; set; }

        public decimal InterestRate { get; set; }

        public Account(CustomerType customer, decimal balance = 0, decimal interestRate = 0)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public virtual void Deposit(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("The deposit amount cannot be a negative number");
            }

            this.Balance += amount;
        }

        public virtual decimal CalculateInterestAmount(int periodInMonths)
        {
            return this.InterestRate * periodInMonths;
        }
    }
}
