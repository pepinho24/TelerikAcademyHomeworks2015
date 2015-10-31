using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentSystem.Api.Models.Tests
{
    public class TestUpdateModel
    {
        public ICollection<int> StudentIds { get; set; }

        public Guid CourseId { get; set; }
    }
}