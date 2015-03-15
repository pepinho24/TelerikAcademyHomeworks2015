﻿/*Problem 1. Structure

Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space.
Implement the ToString() to enable printing a 3D point.
 
Problem 2. Static read-only field

Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}.
Add a static property to return the point O.*/
namespace _01_04.Point
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public struct Point3D
    {
        public double X { get; set; }

        public double Y { get; set; }

        public double Z { get; set; }

        private static readonly Point3D o = new Point3D(0,0,0);

        public Point3D(double x, double y, double z)
            :this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public static Point3D O 
        {
            get { return o; }
        }

        public override string ToString()
        {
            return string.Format("[X: {0}, Y: {1}, Z: {2}]", this.X, this.Y, this.Z);
        }

    }
}
