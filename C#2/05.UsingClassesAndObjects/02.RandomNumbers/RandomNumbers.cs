/*Problem 2. Random numbers

Write a program that generates and prints to the console 10 random values in the range [100, 200].*/
namespace _02.RandomNumbers
{
    using System;

    public class RandomNumbers
    {
        private static readonly Random random = new Random();

        public static void Main()
        {
            int minRange = 100;
            int maxRange = 200;
            int count = 10;
            int[] randomNumbers = GetRandomNumbers(minRange, maxRange, count);

            Console.WriteLine(string.Join(", ", randomNumbers));
        }

        private static int[] GetRandomNumbers(int minRange, int maxRange, int count)
        {
            var arr = new int[count];

            for (int i = 0; i < count; i++)
            {
                arr[i] = random.Next(minRange, maxRange + 1);
            }

            return arr;
        }
    }
}
