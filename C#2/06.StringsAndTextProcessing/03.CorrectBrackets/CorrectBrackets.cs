/*Problem 3. Correct brackets

Write a program to check if in a given expression the brackets are put correctly.
Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).*/
namespace _03.CorrectBrackets
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CorrectBrackets
    {
        static bool CheckBrackets(string str)
        {
            int stack = 0;

            for (int i = 0; i < str.Length && stack >= 0; i++)
            {
                if (str[i] == '(')
                {
                    stack++;
                }

                if (str[i] == ')')
                {
                    stack--;
                }

                if (stack < 0)
                {
                    return false;
                }
            }

            return stack == 0;
        }

        public static void Main()
        {
            Console.Write("Please enter an expression to check the brackets of: ");
            var expression = Console.ReadLine();
            var areBracketsCorrect = CheckBrackets(expression);

            Console.WriteLine("The brackets of {0} are {1}!", expression, areBracketsCorrect? "correct" :"incorrect");
        }
    }
}
