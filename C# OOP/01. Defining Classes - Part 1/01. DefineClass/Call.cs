/* Problem 8. Calls

   Create a class Call to hold a call performed through a GSM.
   It should contain date, time, dialled phone number and duration (in seconds).
*/
namespace _01.DefineClass
{
    using System;

    public class Call
    {
        private DateTime date;
       
        private int callDuration;
        private string dialledPhoneNumber;
        
        public DateTime Date
        {
            get { return this.date; }
            set
            {
                if (value > DateTime.Now)
                {
                    throw new ArgumentException("Incorrect call date!");
                }
                else
                {
                    this.date = value;
                }
            }
        }

        public int CallDuration
        {
            get { return this.callDuration; }
            set { this.callDuration = value; }
        }
        
        public string DialledPhoneNumber
        {
            get { return this.dialledPhoneNumber; }
            set { this.dialledPhoneNumber = value; }
        }

        public override string ToString()
        {
            return String.Format(@"[To: {0}, Duration: {1:F1} seconds, At: {2}]",
                this.DialledPhoneNumber, this.CallDuration, this.Date.ToString("dd/MM/yy - HH:mm:ss"));
        }
    }
}
