namespace StudentSystem.Data
{
    using StudentSystem.Data.Repositories;
    using StudentSystem.Models;

    public interface IStudentSystemData
    {
        IGenericRepository<Course> Courses { get; }

        IGenericRepository<Homework> Homeworks { get; }
        
        StudentsRepository Students { get; }

        IGenericRepository<Test> Tests { get; }
    }
}
