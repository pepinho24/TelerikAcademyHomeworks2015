namespace StudentSystem.Api.Controllers
{
    using Models;
    using Models.Students;
    using Models.Homeworks;
    using StudentSystem.Models;
    using System.Linq;
    using System.Web.Http;

    public class StudentsController : BaseController
    {
        [HttpGet]
        public IHttpActionResult Get()
        {
            var students = data.Students.All()
                .Select(s => new StudentViewModel
                {
                    AdditionalInformation = s.AdditionalInformation,
                    AssistantName = s.Assistant.FirstName + " " + s.Assistant.LastName,
                    Courses = s.Courses.Select(c => c.Name).ToList(),
                    FirstName = s.FirstName,
                    LastName = s.LastName,
                    Level = s.Level,
                    StudentIdentification = s.StudentIdentification,
                    Trainees = s.Trainees.Select(t => t.FirstName + " " + t.LastName).ToList(),
                    Homeworks = s.Homeworks.Select(h => new HomeworkViewModel
                    {
                        CourseName = h.Course.Name,
                        FileUrl = h.FileUrl,
                        Id = h.Id,
                        StudentName = h.Student.FirstName + " " + h.Student.LastName,
                        TimeSent = h.TimeSent
                    }).ToList()
                });

            return Ok(students);
        }

        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            var student = data.Students.All().FirstOrDefault(s => s.StudentIdentification == id);

            if (student == null)
            {
                return NotFound();
            }

            return Ok(student);
        }

        [HttpPost]
        public IHttpActionResult Register(StudentRegisterModel student)
        {
            if (!ModelState.IsValid)
            {
                return this.BadRequest(ModelState);
            }

            var dbStudent = new Student()
            { 
                FirstName = student.FirstName,
                LastName = student.LastName,
                Level = student.Level,
                AdditionalInformation = student.AdditionalInformation
            };

            data.Students.Add(dbStudent);

            data.SaveChanges();
            return Ok(dbStudent);
        }

        [HttpPut]
        public IHttpActionResult Update(int id, Student student)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            data.Students.Update(student);
            data.SaveChanges();

            return Ok(student);
        }

        [HttpPost]
        public IHttpActionResult Delete(int id)
        {
            var student = data.Students.SearchFor(c => c.StudentIdentification == id).FirstOrDefault();
            if (student == null)
            {
                return NotFound();
            }

            data.Students.Delete(student);
            data.SaveChanges();

            return Ok(student);
        }
    }
}