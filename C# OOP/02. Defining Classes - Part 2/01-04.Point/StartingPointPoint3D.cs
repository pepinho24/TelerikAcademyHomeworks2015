/*
 Problem 1. Structure

Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space.
Implement the ToString() to enable printing a 3D point.
Problem 2. Static read-only field

Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}.
Add a static property to return the point O.
Problem 3. Static class

Write a static class with a static method to calculate the distance between two points in the 3D space.
Problem 4. Path

Create a class Path to hold a sequence of points in the 3D space.
Create a static class PathStorage with static methods to save and load paths from a text file.
Use a file format of your choice.*/

namespace _01_04.Point
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StartingPointPoint3D
    {
        public static void Main()
        {
            var firstPoint = new Point3D(0, 1, 2);
            var secondPoint = new Point3D(0, 1, 3);

            var distance = CalculateDistance.BetweenTwo3DPoints(firstPoint, secondPoint);

            Console.WriteLine("The distance between points A{0} and B{1} is {2}.", firstPoint.ToString(), secondPoint.ToString(), distance);

            var path = PathStorage.LoadPath();
            Console.WriteLine(path);

            PathStorage.SavePath(path);
        }
    }
}
