using StudentSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentSystem.Api.Models.Students
{
    public class StudentUpdateModel
    {
        public int StudentIdentification { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        public string LastName { get; set; }

        public int Level { get; set; }

        public int AssistantId { get; set; }
        
        public ICollection<Student> Trainees { get; set; }

        public ICollection<Course> Courses { get; set; }

        public ICollection<Homework> Homeworks { get; set; }

        public StudentInfo AdditionalInformation { get; set; }
    }
}