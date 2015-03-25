/*Problem 1. Shapes

Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height.
Define two new classes Triangle and Rectangle that implement the virtual method and return the surface of the figure (height*width for rectangle and height*width/2 for triangle).
Define class Square and suitable constructor so that at initialization height must be kept equal to width and implement the CalculateSurface() method.
Write a program that tests the behaviour of the CalculateSurface() method for different shapes (Square, Rectangle, Triangle) stored in an array.*/
namespace _01.Shapes
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            var shapes = new List<Shape>()
            {
                new Triangle(2,1), // area = 2 * 1 / 2 = 1
                new Rectangle(4,6), // area = 4 * 6 = 24
                new Square(5) //area = 5 * 5 = 25
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.CalculateSurface());
            }
        }
    }
}
