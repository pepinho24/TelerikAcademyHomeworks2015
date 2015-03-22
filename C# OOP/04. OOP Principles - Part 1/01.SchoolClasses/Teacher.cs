namespace _01.SchoolClasses
{
    using System.Collections.Generic;

    public class Teacher : Person
    {
        private ICollection<Discipline> disciplines;
       
        public Teacher(Name name)
            :base(name)
        {
            this.Comments = new List<Comment>();
            this.Disciplines = new List<Discipline>();
        }

        public ICollection<Discipline> Disciplines
        {
            get { return this.disciplines; }
            set { this.disciplines = value; }
        }

        public void AddDiscipline(Discipline discipline)
        {
            this.Disciplines.Add(discipline);
        }

        public void RemoveDiscipline(Discipline discipline)
        {
            this.Disciplines.Remove(discipline);
        }

        public void RemoveAllDisciplines()
        {
            this.Disciplines.Clear();
        }
    }
}
