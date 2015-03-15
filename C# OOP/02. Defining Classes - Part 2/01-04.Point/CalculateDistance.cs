/*Problem 3. Static class

Write a static class with a static method to calculate the distance between two points in the 3D space.
 * http://quiz.uprm.edu/visual3d/manual/coor_sys/dist_two_points.html
 */
namespace _01_04.Point
{
    using System;

    public static class CalculateDistance
    {
        public static double BetweenTwo3DPoints(Point3D firstPoint, Point3D secondPoint)
        {
            return Math.Sqrt((firstPoint.X - secondPoint.X) * (firstPoint.X - secondPoint.X)
                + (firstPoint.Y - secondPoint.Y) * (firstPoint.Y - secondPoint.Y)
                + (firstPoint.Z - secondPoint.Z) * (firstPoint.Z - secondPoint.Z));
        }
    }
}
