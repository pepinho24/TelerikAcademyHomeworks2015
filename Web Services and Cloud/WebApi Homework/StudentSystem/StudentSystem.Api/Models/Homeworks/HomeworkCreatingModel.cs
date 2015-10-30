namespace StudentSystem.Api.Models.Homeworks
{
    using System;

    public class HomeworkCreatingModel
    {
        public string FileUrl { get; set; }

        public int StudentIdentification { get; set; }

        public Guid CourseId { get; set; }
    }
}