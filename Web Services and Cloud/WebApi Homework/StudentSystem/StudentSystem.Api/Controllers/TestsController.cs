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

    public class TestsController : BaseController
    {
        [HttpGet]
        public IHttpActionResult Get()
        {
            var tests = data.Tests.All();
            return Ok(tests);
        }

        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            var test = data.Tests.SearchFor(t => t.Id == id).FirstOrDefault();
            if (test == null)
            {
                return NotFound();
            }

            return Ok(test);
        }

        [HttpPut]
        public IHttpActionResult Update(int id, Test test)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != test.Id)
            {
                return BadRequest();
            }

            data.Tests.Update(test);
            data.SaveChanges();

            return Ok(test);
        }

        [HttpPost]
        public IHttpActionResult Create(Test test)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            data.Tests.Add(test);
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

            return Ok(test);
        }
    }
}
