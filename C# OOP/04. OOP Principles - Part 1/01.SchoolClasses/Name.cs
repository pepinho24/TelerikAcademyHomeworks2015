namespace _01.SchoolClasses
{
    public class Name
    {
        private string firstName;
        private string lastName;
        
        public Name(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }
        
        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", this.FirstName, this.LastName);
        }
    }
}
