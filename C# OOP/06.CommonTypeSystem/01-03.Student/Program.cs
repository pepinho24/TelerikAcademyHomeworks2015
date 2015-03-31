namespace _01_03.Student
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var firstName = "Ivan";
            var middleName = "Ivanov";
            var lastName = "Georgiev";

            var student = new Student(firstName, middleName, lastName,
                "12453-07", "Gorno nanadolnishte nomer shtru",
                "0897654321", "fake@email.com", 3,
                University.Harvard, Faculty.EngineeringAndTechnology, Specialty.ComputerScience);
            var secondStudent = new Student(firstName, middleName, lastName,
                "12453-07", "Gorno nanadolnishte nomer shtru",
                "0897654321", "fake@email.com", 3,
                University.Harvard, Faculty.EngineeringAndTechnology, Specialty.ComputerScience);

            Console.WriteLine(student);
            Console.WriteLine(student == secondStudent);
            Console.WriteLine(student.GetHashCode() == secondStudent.GetHashCode());

            student.MobilePhone = "0887654321";

            Console.WriteLine(student);
            Console.WriteLine(student == secondStudent);
            Console.WriteLine(student.GetHashCode() == secondStudent.GetHashCode()); // true, because the hashcode gets only the SSN and the names

            var thirdStudent = student.Clone() as Student;
            Console.WriteLine(student == thirdStudent);
            student.University = University.Cambridge;
            Console.WriteLine(student == thirdStudent);


        }
    }
}
