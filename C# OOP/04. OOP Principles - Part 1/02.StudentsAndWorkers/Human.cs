namespace _02.StudentsAndWorkers
{
    public class Human
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", this.FirstName, this.LastName);
        }
    }
}
