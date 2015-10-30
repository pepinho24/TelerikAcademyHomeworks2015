namespace StudentSystem.Api.Models.Homeworks
{
    using System;

    public class HomeworkViewModel
    {
        public int Id { get; set; }

        public string FileUrl { get; set; }

        public DateTime TimeSent { get; set; }

        public string StudentName { get; set; }
        // public int StudentIdentification { get; set; }

        public string CourseName { get; set; }

        // public Guid CourseId { get; set; }
    }
}