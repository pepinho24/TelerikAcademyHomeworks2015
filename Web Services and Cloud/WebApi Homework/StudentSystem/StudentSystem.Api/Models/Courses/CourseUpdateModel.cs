namespace StudentSystem.Api.Models.Courses
{
    using StudentSystem.Models;
    using System.Collections.Generic;

    public class CourseUpdateModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public ICollection<Student> Students { get; set; }

        public ICollection<Homework> Homeworks { get; set; }
    }
}