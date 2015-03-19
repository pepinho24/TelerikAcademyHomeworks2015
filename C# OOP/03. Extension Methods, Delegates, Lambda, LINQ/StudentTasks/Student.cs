namespace StudentTasks
{
    using System.Collections.Generic;
    using System.Text;

    public class Student
    {
        private string tel;

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int FN { get; set; }

        public string Tel
        {
            get
            {
                return this.tel;
            }
            set
            {
                var sb = new StringBuilder();
                foreach (var digit in value)
                {
                    if (char.IsDigit(digit))
                    {
                        sb.Append(digit);
                    }
                }

                this.tel = sb.ToString();
            }
        }

        public int Age { get; set; }

        public string Email { get; set; }

        public List<int> Marks { get; set; }

        public int GroupNumber { get; set; }

        public Student()
        {
            this.Marks = new List<int>();
        }
    }
}
