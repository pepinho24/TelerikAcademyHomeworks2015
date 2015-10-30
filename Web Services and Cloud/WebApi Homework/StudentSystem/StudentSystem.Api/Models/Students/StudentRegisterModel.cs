namespace StudentSystem.Api.Models.Students
{
    using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

    using StudentSystem.Models;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class StudentRegisterModel
    {
        public StudentRegisterModel()
        {
            this.AdditionalInformation = new StudentInfo();
        }

        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        public string LastName { get; set; }

        public int Level { get; set; }

        public StudentInfo AdditionalInformation { get; set; }
    }
}