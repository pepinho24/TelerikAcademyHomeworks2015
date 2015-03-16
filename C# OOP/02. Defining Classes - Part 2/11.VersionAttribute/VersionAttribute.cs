/*Problem 11. Version attribute

Create a [Version] attribute that can be applied to structures, classes, interfaces, enumerations and methods and holds a version in the format major.minor (e.g. 2.11).
Apply the version attribute to a sample class and display its version at runtime.*/
namespace _11.VersionAttribute
{
    using System;
    using System.Globalization;

    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class |
    AttributeTargets.Interface | AttributeTargets.Enum | AttributeTargets.Method,
    AllowMultiple = false)]
    public class VersionAttribute : Attribute
    {
        public double Version { get; private set; }


        public VersionAttribute(double version = 1.00 )
        {
            this.Version = version;
        }

        public override string ToString()
        {
            return this.Version.ToString(CultureInfo.InvariantCulture);
        }
    }

}
