using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentSystem.Api.Models.Tests
{
    public class TestViewModel
    {
        public ICollection<string> Students { get; set; }

        public string CourseName { get; set; }
    }
}