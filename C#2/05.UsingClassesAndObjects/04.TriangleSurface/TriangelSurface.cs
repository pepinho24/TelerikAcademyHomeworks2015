/*Problem 4. Triangle surface

Write methods that calculate the surface of a triangle by given:
Side and an altitude to it;
Three sides;
Two sides and an angle between them;
Use System.Math. */
namespace _04.TriangleSurface
{
    using System;

    public class TriangelSurface
    {
        public static double TriangleArea(double side, double altitude)
        {
            double area;
            area = (side * altitude) / 2;
            return area;
        }

        public static double TriangleArea(double sideA, double sideB, double sideC)
        {
            double area;
            double p = (sideA + sideB + sideC) / 2.0;
            area = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
            return area;
        }

        public static double TriangleArea(double sideA, double sideB, int degreesAngleBetweenBAndA)
        {
            double area;
            double sinAngleBetweenBAndA = degreesAngleBetweenBAndA * Math.PI / 180.0; // convert degrees to radians
            area = (sideA * sideB * Math.Sin(sinAngleBetweenBAndA)) / 2;
            return area;
        }

        public static void Main()
        {
            PrintMenu();
            int choice = GetChoice();

            switch (choice)
            {
                case 1: FindAreaWithTwoSidesAndAngleBetweenThem(); break;
                case 2: FindAreaWithThreeSides(); break;
                case 3: FindAreaWithSideAndHeight(); break;
                default:
                    break;
            }
        }

        private static void FindAreaWithSideAndHeight()
        {
            double sideA;
            double altitude;

            Console.Write("Enter First side: "); 
            sideA = double.Parse(Console.ReadLine());

            Console.Write("Enter Altitude: "); 
            altitude = double.Parse(Console.ReadLine());

            Console.WriteLine(TriangleArea(sideA, altitude));
        }

        private static void FindAreaWithThreeSides()
        {
            double sideA;
            double sideB;
            double sideC;

            Console.Write("Enter First side: ");
            sideA = double.Parse(Console.ReadLine());

            Console.Write("Enter Second side: ");
            sideB = double.Parse(Console.ReadLine());

            Console.Write("Enter Third side: ");
            sideC = double.Parse(Console.ReadLine());

            Console.WriteLine(TriangleArea(sideA, sideB, sideC));
        }

        private static void FindAreaWithTwoSidesAndAngleBetweenThem()
        {
            double sideA;
            double sideB;

            Console.Write("Enter First side: ");
            sideA = double.Parse(Console.ReadLine());

            Console.Write("Enter Second side: ");
            sideB = double.Parse(Console.ReadLine());

            Console.Write("Enter Angle between the sides: ");
            int degreesAngleBetweenBAndA = int.Parse(Console.ReadLine());

            Console.WriteLine(TriangleArea(sideA, sideB, degreesAngleBetweenBAndA));
        }

        private static int GetChoice()
        {
            Console.Write("Enter your choice: ");
            int choice = Int32.Parse(Console.ReadLine());

            while (choice != 1 && choice != 2 && choice != 3)
            {
                Console.WriteLine("Wrong choice!");
                Console.Write("Enter your choice: ");
                choice = Int32.Parse(Console.ReadLine());
            }

            return choice;
        }

        private static void PrintMenu()
        {
            Console.WriteLine("Find triangle area by given:");
            Console.WriteLine("1) Two sides and an angle;");
            Console.WriteLine("2) Three sides;");
            Console.WriteLine("3) Side and altitude.");
        }
    }
}
