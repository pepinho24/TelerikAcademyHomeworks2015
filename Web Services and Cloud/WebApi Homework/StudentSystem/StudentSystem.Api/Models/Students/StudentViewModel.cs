using StudentSystem.Api.Models.Homeworks;
using StudentSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentSystem.Api.Models.Students
{
    public class StudentViewModel
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

        public string AssistantName { get; set; }
        
        public ICollection<string> Trainees { get; set; }

        public ICollection<string> Courses { get; set; }

        public ICollection<HomeworkViewModel> Homeworks { get; set; }

        public StudentInfo AdditionalInformation { get; set; }
    }
}