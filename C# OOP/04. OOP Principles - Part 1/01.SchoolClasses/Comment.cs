namespace _01.SchoolClasses
{
    public class Comment
    {
        private string author;
        private string commentContent;

        public Comment(string author, string commentContent)
        {
            this.Author = author;
            this.CommentContent = commentContent;
        }

        public string Author
        {
            get { return this.author; }
            set { this.author = value; }
        }

        public string CommentContent
        {
            get { return this.commentContent; }
            set { this.commentContent = value; }
        }

        public override string ToString()
        {
            return string.Format("{{{0}: {1}}}", this.Author, this.CommentContent);
        }
    }
}
