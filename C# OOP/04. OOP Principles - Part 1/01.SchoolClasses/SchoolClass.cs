namespace _01.SchoolClasses
{
    using System;
    using System.Collections.Generic;

    public class SchoolClass : ICommentable
    {
        private static ICollection<string> ClassNames = new HashSet<string>();
        private string name;
        private ICollection<Teacher> teachers;
        private ICollection<Comment> comments;

        public SchoolClass(string name)
        {
            this.Name = name;
            this.Teachers = new HashSet<Teacher>();
            this.Comments = new List<Comment>();
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (ClassNames.Contains(value))
                {
                    throw new ArgumentException("There is already a class with that name!");
                }

                ClassNames.Add(value);
                this.name = value;
            }
        }

        public ICollection<Comment> Comments
        {
            get { return this.comments; }
            set { this.comments = value; }
        }

        public ICollection<Teacher> Teachers
        {
            get { return this.teachers; }
            private set { this.teachers = value; }
        }

        public void AddComment(Comment comment)
        {
            this.Comments.Add(comment);
        }

        public void RemoveComment(Comment comment)
        {
            this.Comments.Remove(comment);
        }

        public void RemoveAllComments()
        {
            this.Comments.Clear();
        }

        public void AddTeacher(Teacher teacher)
        {
            this.teachers.Add(teacher);
        }

        public void RemoveTeacher(Teacher teacher)
        {
            this.teachers.Remove(teacher);
        }

        public void RemoveAllTeachers()
        {
            this.teachers.Clear();
        }
    }
}
