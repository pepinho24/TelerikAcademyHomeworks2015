namespace StudentSystem.Api.Controllers
{
    using System;
    using System.Linq;
    using System.Web.Http;
    using StudentSystem.Models;

    public class CoursesController : BaseController
    {
        [HttpGet]
        public IHttpActionResult Get()
        {
            var courses = data.Courses.All();
            return Ok(courses);
        }

        [HttpGet]
        public IHttpActionResult Get(Guid id)
        {
            Course course = data.Courses.SearchFor(c => c.Id == id).FirstOrDefault();
            if (course == null)
            {
                return NotFound();
            }

            return Ok(course);
        }

        [HttpPut]
        public IHttpActionResult Update(Guid id, Course course)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != course.Id)
            {
                return BadRequest();
            }

            data.Courses.Update(course);
            data.SaveChanges();

            return Ok(course);
        }

        [HttpPost]
        public IHttpActionResult Create(Course course)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            data.Courses.Add(course);
            data.SaveChanges();

            return Ok(course);
        }

        [HttpPost]
        public IHttpActionResult Delete(Guid id)
        {
            Course course = data.Courses.SearchFor(c => c.Id == id).FirstOrDefault();
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