namespace _03.AnimalHierarchy
{
    using System;

    public abstract class Cat : Animal
    {
        public Cat(string name, int age, Gender gender)
            : base(name, age, gender)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("{0} the cat says: Meow meow!", this.Name);
        }
    }
}
