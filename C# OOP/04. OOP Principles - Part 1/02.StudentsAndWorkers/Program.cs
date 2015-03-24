/*Problem 2. Students and workers


 * Define abstract class Human with first name and last name. 
 * Define new class Student which is derived from Human and has new field – grade. 
 * Define class Worker derived from Human with new property WeekSalary and WorkHoursPerDay and method MoneyPerHour() that returns money earned by hour by the worker. 
 * Define the proper constructors and properties for this hierarchy.
Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).
Initialize a list of 10 workers and sort them by money per hour in descending order.
Merge the lists and sort them by first name and last name.*/
namespace _02.StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var students = GenerateStudents();
            Console.WriteLine("All Students: ");
            students.PrintList();
            PrintSeparator();

            var studentsOrderedByGrade = students.OrderBy(s => s.Grade);
            Console.WriteLine("Ordered Students by grade: ");
            studentsOrderedByGrade.PrintList();
            PrintSeparator();

            var workers = GenerateWorkers();
            Console.WriteLine("All workers:");
            workers.PrintList();
            PrintSeparator();

            var workersOrderedByMoneyPerHour = workers.OrderByDescending(w => w.MoneyPerHour());
            Console.WriteLine("Ordered descendingly Workers by money per hour: ");
            workersOrderedByMoneyPerHour.PrintList();
            PrintSeparator();

            List<Human> studentsAndWorkers = new List<Human>();
            studentsAndWorkers.AddRange(studentsOrderedByGrade);
            studentsAndWorkers.AddRange(workersOrderedByMoneyPerHour);
            Console.WriteLine("All students and workers: ");
            studentsAndWorkers.PrintList();
            PrintSeparator();

            var studentsAndWorkeresOrderedByFirstAndLastName = studentsAndWorkers.OrderBy(h => h.FirstName).ThenBy(h => h.LastName);
            Console.WriteLine("All students and workers ordered by first and last name: ");
            studentsAndWorkeresOrderedByFirstAndLastName.PrintList();
            PrintSeparator();
        }


        private static void PrintSeparator()
        {
            Console.WriteLine();
            Console.WriteLine(new string('=', Console.BufferWidth));
            Console.WriteLine();
        }

        private static List<Worker> GenerateWorkers(int workersCount = 10)
        {
            var workers = new List<Worker>();
            for (int i = 0; i < workersCount; i++)
            {
                workers.Add(new Worker(RandomGenerator.GenerateRandomFirstName(), RandomGenerator.GenerateRandomLastName(), (decimal)RandomGenerator.GenerateRandomFloatingPointNumber(0, 2000000), RandomGenerator.GenerateRandomIntegerNumber(0, 24 + 1)));
            }

            return workers;
        }

        private static List<Student> GenerateStudents(int studentsCount = 10)
        {
            var students = new List<Student>();
            for (int i = 0; i < studentsCount; i++)
            {
                students.Add(new Student(RandomGenerator.GenerateRandomFirstName(), RandomGenerator.GenerateRandomLastName(), RandomGenerator.GenerateRandomIntegerNumber(1, 12 + 1)));
            }

            return students;
        }
    }
}