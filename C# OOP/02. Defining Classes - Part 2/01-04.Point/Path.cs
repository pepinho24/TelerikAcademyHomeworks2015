/*
 Problem 4. Path

Create a class Path to hold a sequence of points in the 3D space.
 */
namespace _01_04.Point
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Path
    {
        private List<Point3D> pointsSequence;

        public Path()
        {
            this.PointsSequence = new List<Point3D>();
        }

        public List<Point3D> PointsSequence
        {
            get { return pointsSequence; }
            set { pointsSequence = value; }
        }

        public void AddPoint(Point3D point)
        {
            this.PointsSequence.Add(point);
        }

        public override string ToString()
        {
            var str = new StringBuilder();

            foreach (var point in this.PointsSequence)
            {
                str.AppendLine(point.ToString());
            }

            return str.ToString();
        }
    }
}
