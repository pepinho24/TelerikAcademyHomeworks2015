namespace _01.SchoolClasses
{
    using System;
    using System.Collections.Generic;

    public class Student : Person
    {
        private static HashSet<int> ClassNumbers = new HashSet<int>();
        private int classNumber;

        public Student(Name name, int classNumber)
            :base(name)
        {
            this.ClassNumber = classNumber;
            this.Comments = new List<Comment>();
        }

        public int ClassNumber
        {
            get { return this.classNumber; }
            set
            {
                if (ClassNumbers.Contains(value))
                {
                    throw new ArgumentException("There is already a student with that number!");
                }

                ClassNumbers.Add(value);
                this.classNumber = value;
            }
        }
    }
}
