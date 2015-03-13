namespace _01.DefineClass
{
    using System;

    public class Human
    {
        private string firstName;
        private string lastName;

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (value != null)
                {
                    this.firstName = value;
                }
                else
                {
                    throw new ArgumentNullException("First name cannot be null!");
                }
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Last name cannot be null or empty!");
                }
                else
                {
                    this.lastName = value;
                }
            }
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName; 
        }
    }
}
