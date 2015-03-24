namespace _02.StudentsAndWorkers
{
    public class Student : Human
    {
        private int grade;

        public Student(string firstName, string lastname, int grade)
            : base(firstName, lastname)
        {
            this.Grade = grade;
        }

        public int Grade
        {
            get { return this.grade; }
            set { this.grade = value; }
        }

        public override string ToString()
        {
            return string.Format("{0}, Grade: {1}", base.ToString(), this.Grade);
        }
    }
}
