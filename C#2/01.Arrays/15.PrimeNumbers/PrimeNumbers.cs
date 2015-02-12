//Problem 15. Prime numbers

//Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.
namespace _15.PrimeNumbers
{
    using System;

    public class PrimeNumbers
    {
        public static void Main()
        {
            int n = 10000;//000;
            bool[] primeNumbers = new bool[n]; //by default they're all false

            for (int i = 2; i < n; i++)
            {
                primeNumbers[i] = true;//set all numbers to true
            }

            //mark the non primes by finding mutiples 
            for (int j = 2; j < n; j++)
            {
                if (primeNumbers[j])//is true
                {
                    for (int p = 2; (p * j) < n; p++)
                    {
                        primeNumbers[p * j] = false;
                    }
                }
            }

            PrintPrimeNumbers(primeNumbers);
        }

        private static void PrintPrimeNumbers(bool[] primeNumbers)
        {
            Console.Write("The prime numbers are: ");
            for (int i = 0; i < primeNumbers.Length; i++)
            {
                if (primeNumbers[i])
                {
                    if (i > 0)
                    {
                        Console.Write(", ");
                    }

                    Console.Write(i);
                }

                if (i == primeNumbers.Length - 1)
                {
                    Console.WriteLine("!");
                }
            }
        }
    }
}
