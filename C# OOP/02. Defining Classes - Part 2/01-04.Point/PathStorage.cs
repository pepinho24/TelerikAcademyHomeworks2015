/*Problem 4. Path

Create a static class PathStorage with static methods to save and load paths from a text file.
Use a file format of your choice.*/
namespace _01_04.Point
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.IO;
    using System.Threading.Tasks;

    public static class PathStorage
    {
        public static void SavePath(Path path, string destinationFilePath = null)
        {
            using (StreamWriter output = new StreamWriter("../../Output.txt"))
            {
                foreach(var point in path.PointsSequence)
                {
                    output.WriteLine(string.Format("{0} {1} {2}", point.X, point.Y, point.Z));
                }
            }
        }

        public static Path LoadPath(string sourceFilePath = "../../Input.txt")
        {
            var path = new Path();
            using (StreamReader input = new StreamReader(sourceFilePath))
            {
                for (int row = 0; !input.EndOfStream; row++)
                {
                    double[] numbers = input.ReadLine().Split(' ').Select(double.Parse).ToArray();
                    path.AddPoint(new Point3D(numbers[0],numbers[1],numbers[2]));
                }
            }
            
            return path;
        }
    }
}
