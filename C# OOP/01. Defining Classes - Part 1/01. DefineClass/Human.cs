namespace _01.DefineClass
{
    public class Human
    {
        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName
        {
            get 
            {
                return this.FirstName + " " + this.LastName;
            }
        }
    }
}
