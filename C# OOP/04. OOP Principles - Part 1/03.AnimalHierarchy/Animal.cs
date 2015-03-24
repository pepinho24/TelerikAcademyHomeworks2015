namespace _03.AnimalHierarchy
{
    public abstract class Animal : ISound
    {
        public int Age { get; set; }

        public string Name { get; set; }

        public Gender Gender { get; set; }

        public Animal(string name, int age, Gender gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public abstract void ProduceSound();
    }
}
