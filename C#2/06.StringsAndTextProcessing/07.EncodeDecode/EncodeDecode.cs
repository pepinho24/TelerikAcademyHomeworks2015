/*Problem 7. Encode/decode

Write a program that encodes and decodes a string using given encryption key (cipher).
The key consists of a sequence of characters.
The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key, the second – with the second, etc. 
When the last key character is reached, the next is the first.
*/
namespace _07.EncodeDecode
{
    using System;
    using System.Text;
    using System.IO;

    public class EncodeDecode
    {
        public static string Encrypt(string message, string key)
        {
            var encryptedMessage = new StringBuilder(message.Length);

            for (int i = 0; i < message.Length; i++)
                encryptedMessage.Append((char)(message[i] ^ key[i % key.Length]));

            return encryptedMessage.ToString();
        }

        public static string Decrypt(string message, string key)
        {
            return Encrypt(message, key);
        }

        public static void Main()
        {
            string message = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec consectetur ex sit amet dolor rutrum, in imperdiet lorem consequat. Phasellus convallis convallis arcu eget luctus. Pellentesque sed laoreet purus. Proin eget mi feugiat, porttitor metus ut, consectetur tortor. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Morbi fermentum metus non sodales aliquam. Donec vitae libero ornare turpis pretium tempor posuere vitae tortor. Donec non massa ornare, ornare magna eget, interdum tortor. In vehicula, risus id condimentum molestie, metus nunc facilisis est, in imperdiet dui elit a nisl. Donec sed est augue. Suspendisse porta, nulla vitae mattis volutpat, leo turpis auctor erat, at ullamcorper leo velit malesuada neque. Nullam a mauris mollis, cursus dolor et, iaculis dolor. Mauris nec quam dolor. Phasellus porta ut justo sit amet elementum.";
            //Console.WriteLine("Please enter the text: ");
            //string message = Console.ReadLine();

            string key = "nonsense";
            //Console.WriteLine("Please enter the key: ");
            //string key = Console.ReadLine();

            string encrypted = Encrypt(message, key);
            string decrypted = Decrypt(encrypted, key);

            PrintSeparator();
            Console.WriteLine("The message: " + message);
            PrintSeparator();
            Console.WriteLine("The key: " + key);
            PrintSeparator();
            Console.WriteLine("The encrypted message: " + encrypted);
            PrintSeparator();
            Console.WriteLine("The decrypted message: " + decrypted);
        }

        private static void PrintSeparator()
        {
            Console.WriteLine(new string('=', Console.WindowWidth));
        }
    }
}
