namespace StudentSystem.Api.Controllers
{
    using System;
    using System.Linq;
    using System.Web.Http;
    using StudentSystem.Models;
    using Models.Courses;

    public class CoursesController : BaseController
    {
        [HttpGet]
        public IHttpActionResult Get()
        {
            var courses = data.Courses.All()
                .Select(c => new CourseViewModel
                {
                    Id =c.Id,
                    Description = c.Description,
                    Homeworks = c.Homeworks,
                    Name = c.Name,
                    Students = c.Students
                });

            return Ok(courses);
        }

        [HttpGet]
        public IHttpActionResult Get(Guid id)
        {
            var course = data.Courses.SearchFor(c => c.Id == id)
                .Select(c => new CourseViewModel
                {
                    Id = c.Id,
                    Description = c.Description,
                    Homeworks = c.Homeworks,
                    Name = c.Name,
                    Students = c.Students
                })
            .FirstOrDefault();

            if (course == null)
            {
                return NotFound();
            }

            return Ok(course);
        }

        [HttpPut]
        public IHttpActionResult Update(Guid id, CourseUpdateModel course)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var dbCourse = new Course
            {
                Id = id,
                Name = course.Name,
                Description = course.Description,
                Homeworks = course.Homeworks,
                Students = course.Students
            };

            data.Courses.Update(dbCourse);
            data.SaveChanges();

            return Ok(course);
        }

        [HttpPost]
        public IHttpActionResult Create(CourseCreatingModel course)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var dbCourse = new Course
            {
                Name = course.Name,
                Description = course.Description,
                Homeworks = course.Homeworks,
                Students = course.Students              
            };

            data.Courses.Add(dbCourse);
            data.SaveChanges();

            return Ok(course);
        }

        [HttpPost]
        public IHttpActionResult Delete(Guid id)
        {
            var course = data.Courses.SearchFor(c => c.Id == id).FirstOrDefault();
            if (course == null)
            {
                return NotFound();
            }

            data.Courses.Delete(course);
            data.SaveChanges();

            return Ok(course);
        }
    }
}