namespace ConvertingNumbers_AllTasksInOne_
{
    using System;
    using System.Text;

    public class ConvertingNumbers
    {
        /*Problem 1. Decimal to binary
          Write a program to convert decimal numbers to their binary representation.*/
        private static string ConvertDecimalToBinary(int numberInDecimal)
        {
            return Convert.ToString(numberInDecimal, 2);
        }

        /*Problem 2. Binary to decimal
        Write a program to convert binary numbers to their decimal representation.*/
        private static int ConvertBinaryToDecimal(string binaryVal)
        {
            return Convert.ToInt32(binaryVal, 2);
        }

        /*Problem 3. Decimal to hexadecimal
          Write a program to convert decimal numbers to their hexadecimal representation.*/
        private static string ConvertDecimalToHexadecimal(int decimalValue)
        {
            return decimalValue.ToString("X");
        }

        /* Problem 4. Hexadecimal to decimal
           Write a program to convert hexadecimal numbers to their decimal representation.*/
        private static int ConvertHexadecimalToDecimal(string hexValue)
        {
            return int.Parse(hexValue, System.Globalization.NumberStyles.HexNumber);
        }

        /*Problem 5. Hexadecimal to binary
          Write a program to convert hexadecimal numbers to binary numbers (directly).*/
        private static string ConvertHexadecimalToBinary(string hexValue)
        {
            return Convert.ToString(Convert.ToInt32(hexValue, 16), 2);
        }

        /*Problem 6. Binary to hexadecimal
          Write a program to convert binary numbers to hexadecimal numbers (directly).*/
        private static string ConvertBinaryToHexadecimal(string binaryValue)
        {
            return Convert.ToString(Convert.ToInt32(binaryValue, 2), 16);
        }

        /*Problem 7. One system to any other
          Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤ 16).*/
        private static string ConvertFromAnyToAnyNumerialSystem(int baseFrom, int baseTo, string number)
        {
            string result;

            var temp = ArbitraryToDecimalSystem(number, baseFrom);
            result = DecimalToArbitrarySystem(temp, baseTo);

            return result;
        }

        /*
        Problem 8. Binary short
        Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).*/
        public static string ConvertShortToBinary(short number)
        {
            if (number == 0)
                return new String('0', 16);

            StringBuilder binary = new StringBuilder();

            for (int bit = 0; bit < 16; bit++)
            {
                binary.Insert(0, (number >> bit) & 1);
            }

            return binary.ToString();
        }

        public static void Main()
        {
            // Here is an online converter: http://number.webmasters.sk/numerical.php

            int decimalValue;
            string binaryValue;
            string hexValue;

            while (true)
            {
                /*Problem 1*/
                //Console.Write("Enter the decimal: ");
                //decimalValue = Int32.Parse(Console.ReadLine());
                //binaryValue = ConvertDecimalToBinary(decimalValue);
                //Console.WriteLine("Binary: {0}!", binaryValue);

                /*Problem 2*/
                //Console.Write("Enter the binary number: ");
                //binaryValue = Console.ReadLine();
                //decimalValue = ConvertBinaryToDecimal(binaryValue);
                //Console.WriteLine("The number in decimal is: {0}!", decimalValue);

                /*Problem 3*/
                //Console.Write("Enter the decimal: ");
                //decimalValue = Int32.Parse(Console.ReadLine());
                //hexValue = ConvertDecimalToHexadecimal(decimalValue);
                //Console.WriteLine("The number in hexadecimal is: {0}!", hexValue);

                /*Problem 4*/
                //Console.Write("Enter the hexadecimal: ");
                //hexValue = Console.ReadLine();
                //decimalValue = ConvertHexadecimalToDecimal(hexValue);
                //Console.WriteLine("The num in decimal is: {0}!", decimalValue);

                /*Problem 5*/
                //Console.Write("Enter the hexadecimal: ");
                //hexValue = Console.ReadLine();
                //binaryValue = ConvertHexadecimalToBinary(hexValue);
                //Console.WriteLine("The number in binary is: {0}!", binaryValue);

                /*Problem 6*/
                //Console.Write("Enter the binary: ");
                //binaryValue = Console.ReadLine();
                //hexValue = ConvertBinaryToHexadecimal(binaryValue);
                //Console.WriteLine("The number in hexadecimal is: {0}!", hexValue);

                /*Problem 7 - One system to any other */
                //int baseFrom = GetBase("FROM");
                //int baseTo = GetBase("TO");
                //Console.Write("Enter the number: ");
                //string number = Console.ReadLine();
                //string result = ConvertFromAnyToAnyNumerialSystem(baseFrom, baseTo, number);
                //Console.WriteLine("The converted number is: {0}!", result);

                /*Problem 8*/
                Console.Write("Enter the short number: ");
                short shortValue = short.Parse(Console.ReadLine());
                binaryValue = ConvertShortToBinary(shortValue);
                Console.WriteLine("The number in binary is: {0}!", binaryValue);
            }
        }

        /// <summary>
        /// Converts the given decimal number to the numeral system with the
        /// specified radix (in the range [2, 36]).
        /// http://www.pvladov.com/2012/07/arbitrary-to-decimal-numeral-system.html
        /// </summary>
        /// <param name="decimalNumber">The number to convert.</param>
        /// <param name="radix">The radix of the destination numeral system (in the range [2, 36]).</param>
        /// <returns>Returns the number in the specified numeral system.</returns>
        public static string DecimalToArbitrarySystem(long decimalNumber, int radix)
        {
            const int BitsInLong = 64;
            const string Digits = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            if (radix < 2 || radix > Digits.Length)
                throw new ArgumentException("The radix must be >= 2 and <= " + Digits.Length.ToString());

            if (decimalNumber == 0)
                return "0";

            int index = BitsInLong - 1;
            long currentNumber = Math.Abs(decimalNumber);
            char[] charArray = new char[BitsInLong];

            while (currentNumber != 0)
            {
                int remainder = (int)(currentNumber % radix);
                charArray[index--] = Digits[remainder];
                currentNumber = currentNumber / radix;
            }

            string result = new String(charArray, index + 1, BitsInLong - index - 1);
            if (decimalNumber < 0)
            {
                result = "-" + result;
            }

            return result;
        }

        /// <summary>
        /// Converts the given number from the numeral system with the specified
        /// radix (in the range [2, 36]) to decimal numeral system.
        /// http://www.pvladov.com/2012/05/decimal-to-arbitrary-numeral-system.html
        /// </summary>
        /// <param name="number">The arbitrary numeral system number to convert.</param>
        /// <param name="radix">The radix of the numeral system the given number
        /// is in (in the range [2, 36]).</param>
        /// <returns>Returns the decimal number.</returns>
        public static long ArbitraryToDecimalSystem(string number, int radix)
        {
            const string Digits = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            if (radix < 2 || radix > Digits.Length)
                throw new ArgumentException("The radix must be >= 2 and <= " +
                    Digits.Length.ToString());

            if (String.IsNullOrEmpty(number))
                return 0;

            // Make sure the arbitrary numeral system number is in upper case
            number = number.ToUpperInvariant();

            long result = 0;
            long multiplier = 1;
            for (int i = number.Length - 1; i >= 0; i--)
            {
                char c = number[i];
                if (i == 0 && c == '-')
                {
                    // This is the negative sign symbol
                    result = -result;
                    break;
                }

                int digit = Digits.IndexOf(c);
                if (digit == -1)
                    throw new ArgumentException(
                        "Invalid character in the arbitrary numeral system number",
                        "number");

                result += digit * multiplier;
                multiplier *= radix;
            }

            return result;
        }

        private static int GetBase(string baseMessage)
        {
            int baseNum;
            do
            {
                Console.Write("Enter base{0} (bigger or equal to 2 and less or equal to 32): ", baseMessage);
                baseNum = Int32.Parse(Console.ReadLine());
            } while (baseNum < 2 || baseNum > 32);

            return baseNum;
        }
    }
}
