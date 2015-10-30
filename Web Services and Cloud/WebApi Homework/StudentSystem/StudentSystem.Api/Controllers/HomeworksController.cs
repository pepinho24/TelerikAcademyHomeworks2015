namespace StudentSystem.Api.Controllers
{
    using Models.Homeworks;
    using StudentSystem.Models;
    using System;
    using System.Linq;
    using System.Web.Http;

    public class HomeworksController : BaseController
    {
        [HttpGet]
        public IHttpActionResult Get()
        {
            var homeworks = data.Homeworks.All().Select(h => new HomeworkViewModel
            {
                Id = h.Id,
                CourseName = h.Course.Name,
                FileUrl = h.FileUrl,
                StudentName = h.Student.FirstName + " " + h.Student.LastName,
                TimeSent = h.TimeSent
            });

            return Ok(homeworks);
        }

        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            var homework = data.Homeworks.SearchFor(h => h.Id == id)
                .Select(h => new HomeworkViewModel
                {
                    Id = h.Id,
                    CourseName = h.Course.Name,
                    FileUrl = h.FileUrl,
                    StudentName = h.Student.FirstName + " " + h.Student.LastName,
                    TimeSent = h.TimeSent
                })
                .FirstOrDefault();

            if (homework == null)
            {
                return NotFound();
            }

            return Ok(homework);
        }

        [HttpPut]
        public IHttpActionResult Update(int id, HomeworkUpdateModel homework)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var dbHomework = data.Homeworks.SearchFor(h => h.Id == id).FirstOrDefault();
            dbHomework.FileUrl = homework.FileUrl;

            data.Homeworks.Update(dbHomework);
            data.SaveChanges();

            return Ok(homework);
        }

        [HttpPost]
        public IHttpActionResult Create(HomeworkCreatingModel homework)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var dbHomework = new Homework
            {
                  CourseId = homework.CourseId,
                  FileUrl = homework.FileUrl,
                  StudentIdentification = homework.StudentIdentification,
                  TimeSent = DateTime.Now                  
            };

            data.Homeworks.Add(dbHomework);
            data.SaveChanges();

            return Ok(homework);
        }

        [HttpPost]
        public IHttpActionResult Delete(int id)
        {
            var homework = data.Homeworks.SearchFor(h => h.Id == id).FirstOrDefault();
            if (homework == null)
            {
                return NotFound();
            }

            data.Homeworks.Delete(homework);
            data.SaveChanges();

            return Ok();
        }
    }
}