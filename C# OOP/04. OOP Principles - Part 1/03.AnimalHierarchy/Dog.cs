namespace _03.AnimalHierarchy
{
    using System;

    public class Dog : Animal
    {
        public Dog(string name, int age, Gender gender)
            :base (name,age,gender)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("{0} the dog says: Bau bau!", this.Name);
        }
    }
}
