namespace _01.SchoolClasses
{
    using System.Collections.Generic;
    using System.Linq;

    public class School
    {
        private ICollection<SchoolClass> classes;

        public School()
        {
            this.classes = new HashSet<SchoolClass>();
        }

        public ICollection<SchoolClass> GetClasses()
        {
            return this.classes.ToList();
        }

        public void AddClass(SchoolClass schoolClass)
        {
            this.classes.Add(schoolClass);
        }
    }
}
