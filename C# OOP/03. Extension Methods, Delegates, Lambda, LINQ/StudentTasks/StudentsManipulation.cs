/*
 *********************************************************************************************************************************************************
 ********************************************************                      ***************************************************************************
 ********************************************************       READ ME!       ***************************************************************************
 ********************************************************                      ***************************************************************************
 *********************************************************************************************************************************************************
 
 * These are all the tasks using the Student class (Tasks: 3, 4, 5, 9, 10, 11, 12, 13, 14, 15, 16*, 18, 19)
 * There is a RandomGenerator class used for generating random names, phones, etc.
 * NB! Sometimes in the list of students there are no students meeting the task  requirements (e.g. task 15), so you should run just restart the program
  
 * P.S. The methods should return the collections but I made the printing in the methods on purpose, in order the Main method to be clear and not so long 
 * P.S.2. If the first tasks are hidden when you print them all at once, try to change the buffer height to bigger number (uncomment // Console.BufferHeight = 500; )
 */
namespace StudentTasks
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StudentsManipulation
    {
        public static string[] DepartmentNames = new string[] { "Mathematics", "Physics", "Electronics", "Chemistry", "Public Relations", "Journalism" };

        private static void PrintSeparator()
        {
            Console.WriteLine();
            Console.WriteLine(new string('=', Console.BufferWidth));
            Console.WriteLine();
        }

        private static Student GenerateStudent()
        {
            var student = new Student()
            {
                FirstName = RandomGenerator.GenerateRandomFirstName(),
                LastName = RandomGenerator.GenerateRandomLastName(),
                FN = RandomGenerator.GenerateRandomNumber(7),
                // Email,
                GroupNumber = RandomGenerator.RandomNumber.Next(1, DepartmentNames.Length + 1),
                // Marks,
                Age = RandomGenerator.RandomNumber.Next(5, 85),
                Tel = RandomGenerator.GenerateRandomTelephoneNumber()
            };

            student.Email = student.FirstName + student.LastName + "@" + RandomGenerator.GenerateRandomEmailDomain();

            int marksCount = RandomGenerator.RandomNumber.Next(1, 7);
            for (int i = 0; i < marksCount; i++)
            {
                student.Marks.Add(RandomGenerator.GenerateRandomMark());
            }

            return student;
        }

        private static List<Student> GenerateStudents(int count = 10)
        {
            var students = new HashSet<Student>();
            for (; students.Count < count; )
            {
                students.Add(GenerateStudent());
            }

            return students.ToList();
        }

        public static void Main()
        {
            List<Student> students = GenerateStudents(50);
            List<Group> departments = new List<Group>();
            
            // Console.BufferHeight = 500; // uncomment if the buffer height is not enough and the first tasks are hidden
            
            for (int i = 1; i <= DepartmentNames.Length; i++)
            {
                departments.Add(new Group() { GroupNumber = i, DepartmentName = DepartmentNames[i - 1] });
            }

            Console.WriteLine(" Problem 3. First name  before last name" + Environment.NewLine);
            FirstBeforeLastNameStudents(students);
            PrintSeparator();

            Console.WriteLine(" Problem 4. Age range (18-24 inclusive)" + Environment.NewLine);
            AgeRangeStudents(students);
            PrintSeparator();

            Console.WriteLine(" Problem 5. Order students" + Environment.NewLine);
            OrderStudentsByNames(students);
            PrintSeparator();

            Console.WriteLine(" Problem 9. Student groups(Linq)" + Environment.NewLine);
            StudentsFromGroup2Linq(students);
            PrintSeparator();

            Console.WriteLine(" Problem 10. Student groups (ExtensionMethods)" + Environment.NewLine);
            StudentsFromGroup2(students);
            PrintSeparator();

            Console.WriteLine(" Problem 11. Extract students with email in abv.bg" + Environment.NewLine);
            StudentsWithEmailInAbv(students);
            PrintSeparator();

            Console.WriteLine(" Problem 12. Extract all students with phones in Sofia (starts with 02 or +359 2)" + Environment.NewLine);
            StudentsWithPhoneInSofia(students);
            PrintSeparator();

            Console.WriteLine(" Problem 13. Extract students with at least one excellent mark" + Environment.NewLine);
            StudentsWithExcellentMark(students);
            PrintSeparator();

            Console.WriteLine(" Problem 14. Extract students with two poor marks" + Environment.NewLine);
            StudentsWithTwoPoorMarks(students);
            PrintSeparator();

            Console.WriteLine(" Problem 15. Extract marks from year 2006" + Environment.NewLine);
            StudentsWithMarks(students);
            PrintSeparator();

            Console.WriteLine(" Problem 16*. Extract All students From Mathematics department" + Environment.NewLine);
            StudentsFromMathematics(students, departments);
            PrintSeparator();

            Console.WriteLine(" Problem 18. Grouped by GroupNumber (using linq)" + Environment.NewLine);
            StudentsGroupedByGroupNumber(students);
            PrintSeparator();

            Console.WriteLine(" Problem 19. Grouped by GroupNumber (using Extension methods)" + Environment.NewLine);
            StudentsGroupedByGroupNumber(students);
            PrintSeparator();
        }

        private static void FirstBeforeLastNameStudents(List<Student> students)
        {
            /*Problem 3. First before last
                Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
                Use LINQ query operators. */

            List<Student> firstBeforeLastNameStudents = (from st in students
                                                         where st.FirstName.CompareTo(st.LastName) <= 0
                                                         select st).ToList();

            List<Student> firstBeforeLastNameStudentsExtensionMethod = students.Where(st => st.FirstName.CompareTo(st.LastName) <= 0).ToList();

            int counter = 1;
            foreach (var student in firstBeforeLastNameStudents)
            {
                Console.WriteLine("{0}. {1} {2}", counter, student.FirstName, student.LastName);
                counter++;
            }
        }

        private static void AgeRangeStudents(List<Student> students)
        {
            /* Problem 4. Age range
                Write a LINQ query that finds the first name and last name of all students with age between 18 and 24. */

            List<Student> AgeRangeStudents = (from st in students
                                              where 18 <= st.Age && st.Age <= 24
                                              select st).ToList();

            List<Student> AgeRangeStudentsExtensionMethod = students.Where(st => 18 <= st.Age && st.Age <= 24).ToList();

            int counter = 1;
            foreach (var student in AgeRangeStudents)
            {
                Console.WriteLine("{0}. {1} {2}: {3} years old!", counter, student.FirstName, student.LastName, student.Age);
                counter++;
            }
        }

        private static void OrderStudentsByNames(List<Student> students)
        {
            /*Problem 5. Order students
                Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order.
                Rewrite the same with LINQ.*/

            List<Student> OrderedStudents = (from st in students
                                             orderby st.FirstName
                                             orderby st.LastName
                                             select st).ToList();

            List<Student> OrderedStudentsExtensionMethod = students
                                                            .OrderByDescending(st => st.FirstName)
                                                            .ThenByDescending(st => st.LastName).ToList();

            int counter = 1;
            foreach (var student in OrderedStudentsExtensionMethod)
            {
                Console.WriteLine("{0}. {1} {2}: {3} years old! !", counter, student.FirstName, student.LastName, student.Age);
                counter++;
            }
        }

        private static void StudentsFromGroup2Linq(List<Student> students)
        {
            /*Problem 9. Student groups
                Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.
                Create a List<Student> with sample students. Select only the students that are from group number 2.
                Use LINQ query. Order the students by FirstName. */

            List<Student> studentsFromGroup2 = (from st in students
                                                where st.GroupNumber == 2
                                                orderby st.FirstName
                                                select st).ToList();

            int counter = 1;
            foreach (var student in studentsFromGroup2)
            {
                Console.WriteLine("{0}. {1} {2} - Group {3} !", counter, student.FirstName, student.LastName, student.GroupNumber);
                counter++;
            }
        }

        private static void StudentsFromGroup2(List<Student> students)
        {
            /*Problem 10. Student groups extensions
                Implement the previous using the same query expressed with extension methods. */

            List<Student> studentsFromGroup2ExtensionMethods = students
                                                .Where(st => st.GroupNumber == 2)
                                                .OrderBy(st => st.FirstName)
                                                .ToList();

            int counter = 1;
            foreach (var student in studentsFromGroup2ExtensionMethods)
            {
                Console.WriteLine("{0}. {1} {2} - Group {3} !", counter, student.FirstName, student.LastName, student.GroupNumber);
                counter++;
            }
        }

        private static void StudentsWithEmailInAbv(List<Student> students)
        {
            /*Problem 11. Extract students by email
                Extract all students that have email in abv.bg.
                Use string methods and LINQ.*/

            List<Student> studentsWithEmailInAbv = students.Where(st => st.Email.EndsWith("abv.bg")).ToList();

            int counter = 1;
            foreach (var student in studentsWithEmailInAbv)
            {
                Console.WriteLine("{0}. {1} {2} - Email: {3} !", counter, student.FirstName, student.LastName, student.Email);
                counter++;
            }
        }

        private static void StudentsWithPhoneInSofia(List<Student> students)
        {
            /*Problem 12. Extract students by phone
                Extract all students with phones in Sofia.
                Use LINQ.*/

            List<Student> studentsWithPhoneInSofia = students.Where(st => st.Tel.StartsWith("02") || st.Tel.StartsWith("3592")).ToList();

            int counter = 1;
            foreach (var student in studentsWithPhoneInSofia)
            {
                Console.WriteLine("{0}. {1} {2} - Phone num: {3} !", counter, student.FirstName, student.LastName, student.Tel);
                counter++;
            }
        }

        private static void StudentsWithExcellentMark(List<Student> students)
        {
            /*Problem 13. Extract students by marks
                Select all students that have at least one mark Excellent (6) into a new anonymous class that has properties – FullName and Marks.
                Use LINQ.*/

            var studentsWithExcellentMark = students
                                               .Where(st => st.Marks.Contains(6))
                                               .Select(st => new
                                               {
                                                   FullName = st.FirstName + " " + st.LastName,
                                                   Marks = st.Marks
                                               })
                                               .ToList();

            int counter = 1;
            foreach (var student in studentsWithExcellentMark)
            {
                Console.WriteLine("{0}. {1} - Marks: [{2}] !", counter, student.FullName, string.Join(", ", student.Marks));
                counter++;
            }
        }

        private static void StudentsWithTwoPoorMarks(List<Student> students)
        {
            /*Problem 14. Extract students with two marks
                Write down a similar program that extracts the students with exactly two marks "2".
                Use extension methods.*/

            List<Student> studentsWithTwoPoorMarks = students.Where(s => s.Marks.Count(m => m == 2) == 2).ToList();

            int counter = 1;
            foreach (var student in studentsWithTwoPoorMarks)
            {
                Console.WriteLine("{0}. {1} {2} - Marks: [{3}] !", counter, student.FirstName, student.LastName, string.Join(", ", student.Marks));
                counter++;
            }
        }

        private static void StudentsWithMarks(List<Student> students)
        {
            /*Problem 15. Extract marks
                Extract all Marks of the students that enrolled in 2006. (The students from 2006 have 06 as their 5-th and 6-th digit in the FN).*/

            var studentsWithExcellentMarkFrom2006 = students.Where(s => s.FN.ToString().Substring(4, 2) == "06")
                                                            .Select(st => new { FullName = st.FirstName + " " + st.LastName, Marks = st.Marks, FN = st.FN })
                                                            .ToList();

            int counter = 1;
            foreach (var student in studentsWithExcellentMarkFrom2006)
            {
                Console.WriteLine("{0}. {1}, FN: {2} - Marks: [{3}] !", counter, student.FullName, student.FN, string.Join(", ", student.Marks));
                counter++;
            }
        }

        private static void StudentsFromMathematics(List<Student> students, List<Group> departments)
        {
            /*Problem 16.* Groups
                Create a class Group with properties GroupNumber and DepartmentName.
                Introduce a property GroupNumber in the Student class.
                Extract all students from "Mathematics" department.
                Use the Join operator.*/

            var studentsFromMathematics = from s in students
                                          join d in departments on s.GroupNumber equals d.GroupNumber
                                          where d.DepartmentName == "Mathematics"
                                          select new { FullName = s.FirstName + " " + s.LastName, Department = d.DepartmentName };

            int counter = 1;
            foreach (var student in studentsFromMathematics)
            {
                Console.WriteLine("{0}. {1}, {2} department!", counter, student.FullName, student.Department);
                counter++;
            }
        }

        private static void StudentsGroupedByGroupNumberLinq(List<Student> students)
        {
            /*Problem 18. Grouped by GroupNumber
                Create a program that extracts all students grouped by GroupNumber and then prints them to the console.
                Use LINQ.*/

            var studentsInGroupsLinq = (from gr in
                                            (from st in students
                                             group st by st.GroupNumber)
                                        orderby gr.Key
                                        select gr).ToList();

            int mainCounter = 1;
            foreach (var group in studentsInGroupsLinq)
            {
                int counter = 1;
                foreach (var student in group)
                {
                    Console.WriteLine("{0}.{1} {2} {3}, {4} Department!", mainCounter, counter, student.FirstName, student.LastName, DepartmentNames[student.GroupNumber - 1]);
                    counter++;
                }

                Console.WriteLine();
                mainCounter++;
            }
        }

        private static void StudentsGroupedByGroupNumber(List<Student> students)
        {
            /*Problem 19. Grouped by GroupName extensions
                Rewrite the previous using extension methods. */

            var studentsInGroups = students.GroupBy(st => st.GroupNumber).OrderBy(gr => gr.Key).ToList();

            int mainCounter = 1;
            foreach (var group in studentsInGroups)
            {
                int counter = 1;
                foreach (var student in group)
                {
                    Console.WriteLine("{0}.{1} {2} {3}, {4} Department!", mainCounter, counter, student.FirstName, student.LastName, DepartmentNames[student.GroupNumber - 1]);
                    counter++;
                }

                Console.WriteLine();
                mainCounter++;
            }
        }
    }
}
