/*Problem 1. School classes

We are given a school. In the school there are classes of students.
 * Each class has a set of teachers. Each teacher teaches a set of disciplines. 
 * Students have name and unique class number. Classes have unique text identifier. 
 * Teachers have name. Disciplines have name, number of lectures and number of exercises. 
 * Both teachers and students are people. 
 * Students, classes, teachers and disciplines could have optional comments (free text block).
Your task is to identify the classes (in terms of OOP) and their attributes and operations, 
 * encapsulate their fields, define the class hierarchy 
 * and create a class diagram with Visual Studio.*/
namespace _01.SchoolClasses
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            var school = new School();
            var schoolClass = new SchoolClass("XIIB");

            // Throws exception, because there is already a class with name XIIB 
            // var secondSchoolClass = new SchoolClass("XIIB");

            // Cannot create an instance of the class Person because it is abstract
            //var person = new Person(new Name("Pesho", "Petrov"));

            var teacher = new Teacher(new Name("Kosta", "Kolarov"));
            var student = new Student(new Name("Pesho", "Petrov"), 123);

            // Throws exception, because there is already a student with class number 123 
            //var secondStudent = new Student(new Name("Pesho", "Petrov"), 123);

            var discipline = new Discipline("Math");
            var comment = new Comment("Anonymous", "Such wow");

            school.AddClass(schoolClass);
            schoolClass.AddTeacher(teacher);
            teacher.AddDiscipline(discipline);

            var commentableObjects = new List<ICommentable>()
            {
                schoolClass,
                teacher,
                student,
                discipline
            };

            foreach (var item in commentableObjects)
            {
                item.AddComment(comment);
            }

            foreach (var item in commentableObjects)
            {
                Console.WriteLine(string.Join(", ", item.Comments));
            }

            Console.WriteLine("Everything is working okay!");
        }
    }
}
