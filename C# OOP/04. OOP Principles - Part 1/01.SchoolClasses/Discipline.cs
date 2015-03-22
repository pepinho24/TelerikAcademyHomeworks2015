namespace _01.SchoolClasses
{
    using System.Collections.Generic;

    public class Discipline : ICommentable
    {
        private string name;
        private int numberOfLectures;
        private int numberOfExercises;
        private ICollection<Comment> comments;

        public Discipline(string name, int numberOfLectures = 0, int numberOfExercises = 0)
        {
            this.Name = name;
            this.numberOfLectures = numberOfLectures;
            this.numberOfExercises = numberOfExercises;
            this.comments = new List<Comment>();
        }

        public ICollection<Comment> Comments
        {
            get { return comments; }
            set { comments = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int NumberOfLectures
        {
            get { return this.numberOfLectures; }
            set { this.numberOfLectures = value; }
        }

        public int NumberOfExercises
        {
            get { return this.numberOfExercises; }
            set { this.numberOfExercises = value; }
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
    }
}
