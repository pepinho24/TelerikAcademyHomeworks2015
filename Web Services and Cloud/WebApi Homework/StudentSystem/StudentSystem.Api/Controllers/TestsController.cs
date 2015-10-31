namespace StudentSystem.Api.Controllers
{
    using Models.Tests;
    using StudentSystem.Models;
    using System.Data;
    using System.Linq;
    using System.Web.Http;

    public class TestsController : BaseController
    {
        [HttpGet]
        public IHttpActionResult Get()
        {
            var tests = data.Tests.All().Select(t => new TestViewModel
            {
                CourseName = t.Course.Name,
                Students = t.Students.Select(s => s.FirstName + " " + s.LastName).ToList()
            });

            return Ok(tests);
        }

        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            var test = data.Tests.SearchFor(t => t.Id == id)
                .Select(t => new TestViewModel
                {
                    CourseName = t.Course.Name,
                    Students = t.Students.Select(s => s.FirstName + " " + s.LastName).ToList()
                })
                .FirstOrDefault();

            if (test == null)
            {
                return NotFound();
            }

            return Ok(test);
        }

        [HttpPut]
        public IHttpActionResult Update(int id, TestUpdateModel test)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var students = data.Students.SearchFor(s => test.StudentIds.Contains(s.StudentIdentification)).ToList();
            var dbTest = new Test
            {
                CourseId = test.CourseId,
                Students = students
            };

            data.Tests.Update(dbTest);
            data.SaveChanges();

            return Ok(test);
        }

        [HttpPost]
        public IHttpActionResult Create(TestCreatingModel test)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var students = data.Students.SearchFor(s => test.StudentIds.Contains(s.StudentIdentification)).ToList();

            var dbTest = new Test
            {
                CourseId = test.CourseId,
                Students = students
            };

            data.Tests.Add(dbTest);
            data.SaveChanges();

            return Ok(test);
        }

        [HttpPost]
        public IHttpActionResult Delete(int id)
        {
            var test = data.Tests.SearchFor(t => t.Id == id).FirstOrDefault();
            if (test == null)
            {
                return NotFound();
            }

            data.Tests.Delete(test);
            data.SaveChanges();

            return Ok();
        }
    }
}
