/*Problem 2. Bank accounts

A bank holds different types of accounts for its customers: deposit accounts, loan accounts and mortgage accounts. Customers could be individuals or companies.
All accounts have customer, balance and interest rate (monthly based).
Deposit accounts are allowed to deposit and with draw money.
Loan and mortgage accounts can only deposit money.
All accounts can calculate their interest amount for a given period (in months). In the common case its is calculated as follows: number_of_months * interest_rate.
Loan accounts have no interest for the first 3 months if are held by individuals and for the first 2 months if are held by a company.
Deposit accounts have no interest if their balance is positive and less than 1000.
Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 6 months for individuals.
Your task is to write a program to model the bank system by classes and interfaces.
You should identify the classes, interfaces, base classes and abstract actions and implement the calculation of the interest functionality through overridden methods.*/
namespace _02.BankAccounts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main()
        {
            var individualAcc = new MortgageAccount(CustomerType.Individual, 1000, 10);
            var companyAcc = new DepositAccount(CustomerType.Company, 100000, 10);

            // 14 - 6 = 8 months, 10% * 8monts = 80 per 14 months
            Console.WriteLine("Individual Mortgage Account balance: {0}, interest rate: {1}%, interest sum for 14 months: {2}"
                                        , individualAcc.Balance, individualAcc.InterestRate, individualAcc.CalculateInterestAmount(14));

            // balance > 1000 10% * 14 Months = 140 per month
            Console.WriteLine("Company Deposit Account balance: {0}, interest rate: {1}%, interest sum for 14 months: {2}"
                                        , companyAcc.Balance, companyAcc.InterestRate, companyAcc.CalculateInterestAmount(14));

        }
    }
}
