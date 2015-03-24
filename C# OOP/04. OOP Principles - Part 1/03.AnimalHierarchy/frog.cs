namespace _03.AnimalHierarchy
{
    using System;

    public class Frog : Animal
    {
        public Frog(string name, int age, Gender gender)
            : base(name, age, gender)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("{0} the frog says: What does the frog say? ", this.Name);
        }
    }
}
