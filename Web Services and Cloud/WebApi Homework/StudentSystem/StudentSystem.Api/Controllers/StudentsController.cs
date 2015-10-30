namespace StudentSystem.Api.Controllers
{
    using Models;
    using StudentSystem.Models;
    using System.Linq;
    using System.Web.Http;

    public class StudentsController : BaseController
    {
        [HttpGet]
        public IHttpActionResult Get()
        {
            var students = data.Students.All().ToList();

            return Ok(students);
        }

        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            var students = data.Students.All();
            var student = students.FirstOrDefault((p) => p.StudentIdentification == id);

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