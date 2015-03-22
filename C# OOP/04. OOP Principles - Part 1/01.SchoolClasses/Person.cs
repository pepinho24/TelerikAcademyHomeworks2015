namespace _01.SchoolClasses
{
    using System.Collections.Generic;

    public abstract class Person : ICommentable
    {
        private Name name;
        private ICollection<Comment> comments;

        public Person(Name name)
        {
            this.Name = name;
            this.Comments = new List<Comment>();
        }

        public Name Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public ICollection<Comment> Comments
        {
            get { return this.comments; }
            set { this.comments = value; }
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
