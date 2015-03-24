namespace _03.AnimalHierarchy
{
    using System;

    public class Kitten: Cat
    {
        public Kitten(string name, int age)
            :base(name, age, Gender.Female)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("{0} the little kitten says: Meowwwwwww!", this.Name);
        }
    }
}
