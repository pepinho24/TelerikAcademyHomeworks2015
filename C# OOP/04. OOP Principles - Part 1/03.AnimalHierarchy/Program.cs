/*Problem 3. Animal hierarchy

Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods. 
 * Dogs, frogs and cats are Animals. 
 * All animals can produce sound (specified by the ISound interface). 
 * Kittens and tomcats are cats.
 * All animals are described by age, name and sex.
 * Kittens can be only female and tomcats can be only male. 
 * Each animal produces a specific sound.
Create arrays of different kinds of animals and calculate the average age of each kind of animal using a static method (you may use LINQ).*/
namespace _03.AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var animals = new List<Animal>()
            {
                new Dog("Sharo", 3, Gender.Male),
                new Dog("Lasi", 2, Gender.Female),

                new Frog("Kermit", 1, Gender.Male),

                new Tomcat("Tom", 2),
                new Kitten("Misa",1)
            };

            var averageAge = animals.Average(a => a.Age);

            Console.WriteLine("The average age of the animals is: {0}",averageAge);

            foreach (var animal in animals)
            {
                animal.ProduceSound();
            }
        }
    }
}