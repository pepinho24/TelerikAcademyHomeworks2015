namespace StudentSystem.Api.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;
    using System.Web.Http.Description;
    using StudentSystem.Data;
    using StudentSystem.Models;

    public class HomeworksController : BaseController
    {
        [HttpGet]
        public IHttpActionResult Get()
        {
            var homeworks = data.Homeworks.All();
            return Ok(homeworks);
        }

        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            var homework = data.Homeworks.SearchFor(h=> h.Id == id).FirstOrDefault();
            if (homework == null)
            {
                return NotFound();
            }

            return Ok(homework);
        }

        [HttpPut]
        public IHttpActionResult Update(int id, Homework homework)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != homework.Id)
            {
                return BadRequest();
            }

            data.Homeworks.Update(homework);
            data.SaveChanges();

            return Ok(homework);
        }

        [HttpPost]
        public IHttpActionResult Create(Homework homework)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            data.Homeworks.Add(homework);
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

            return Ok(homework);
        }
    }
}