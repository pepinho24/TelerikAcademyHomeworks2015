/* Problem 12. Call history test

   Write a class GSMCallHistoryTest to test the call history functionality of the GSM class.
   Create an instance of the GSM class.
   Add few calls.
   Display the information about the calls.
   Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
   Remove the longest call from the history and calculate the total price again.
   Finally clear the call history and print it.
 */
namespace _01.DefineClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class GSMCallHistoryTest
    {
        private static Random rnd = new Random();

        public static void TestCallHistory()
        {
            var phone = new GSM("One M8", "HTC");
            for (int i = 0; i < 10; i++)
            {
                phone.AddCall(new Call(DateTime.Now.AddDays(-rnd.Next(1, 50)).AddMinutes(-rnd.Next(1, 50)), rnd.Next(15, 7180), rnd.Next(99999999).ToString()));
            }

            Console.WriteLine("Phone call History: ");
            Console.WriteLine(GSM.GetCallHistoryAsString(phone.CallHistory));
            Console.WriteLine();

            Console.WriteLine("The price of all the calls is: {0}", phone.CalculatePriceOfCallsInCallHistory(0.37));
            Console.WriteLine(new string('-', Console.BufferWidth));
            Console.WriteLine();

            Call longestCall = GetLongestCall(phone.CallHistory);
            phone.DeleteCall(longestCall);

            Console.WriteLine("The price of all the calls after deleting the longest call is: {0}", phone.CalculatePriceOfCallsInCallHistory(0.37));
            Console.WriteLine(new string('-', Console.BufferWidth));

            phone.ClearCallHistory();
            Console.WriteLine("Call history after clearing it: ");
            Console.WriteLine(GSM.GetCallHistoryAsString(phone.CallHistory));
        }

        private static Call GetLongestCall(List<Call> listOfCalls)
        {
            if (listOfCalls.Count == 0)
            {
                throw new ArgumentException("The list of calls cannot be empty");
            }

            Call longestCall = listOfCalls[0];

            foreach (var call in listOfCalls)
            {
                if (call.CallDuration > longestCall.CallDuration)
                {
                    longestCall = call;
                }
            }

            return longestCall;
        }
    }
}
