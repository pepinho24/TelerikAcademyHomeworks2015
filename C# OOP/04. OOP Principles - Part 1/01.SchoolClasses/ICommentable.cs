namespace _01.SchoolClasses
{
    using System.Collections.Generic;

    public interface ICommentable
    {
        ICollection<Comment> Comments { get; set; }

        void AddComment(Comment comment);

        void RemoveComment(Comment comment);

        void RemoveAllComments();
    }
}
