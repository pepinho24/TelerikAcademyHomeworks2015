namespace _04.Person
{
    public class Person
    {
        public int? Age { get; set; }

        public string Name { get; set; }

        public Person(string name, int? age = null)
        {
            this.Name = name;
            this.Age = age;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}!", this.Name, this.Age == null ? "Age not specified" : (this.Age.ToString() + " years old"));
        }
    }
}
