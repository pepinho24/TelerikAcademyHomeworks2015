/*Problem 11. Version attribute

Create a [Version] attribute that can be applied to structures, classes, interfaces, enumerations and methods and holds a version in the format major.minor (e.g. 2.11).
Apply the version attribute to a sample class and display its version at runtime.*/
namespace _11.VersionAttribute
{
    using System;

    [Version(2.11)]
    public class StartingPointVersionAttribute
    {
        public static void Main()
        {
            Type type = typeof(StartingPointVersionAttribute);
            object[] allAttributes = type.GetCustomAttributes(false);

            foreach (VersionAttribute attr in allAttributes)
            {
                Console.WriteLine("The version of the class is: {0}", attr.ToString());
            }
        }
    }
}
