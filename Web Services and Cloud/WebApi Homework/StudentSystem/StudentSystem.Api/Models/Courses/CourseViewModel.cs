namespace StudentSystem.Api.Models.Courses
{
    using System;
    using System.Collections.Generic;
    using StudentSystem.Models;

    public class CourseViewModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public  ICollection<Student> Students { get; set; }

        public  ICollection<Homework> Homeworks { get; set; }
    }
}