namespace StudentSystem.Api.Controllers
{
    using Data;
    using System.Web.Http;

    public abstract class BaseController : ApiController
    {
        protected StudentsSystemData data { get; set; }
        
        public BaseController(StudentsSystemData data)
        {
            this.data = data;
        }

        public BaseController()
            :this(new StudentsSystemData())
        {

        }
    }
}
