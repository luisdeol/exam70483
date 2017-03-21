using System;
using System.Reflection;

namespace assemblyInfo
{
    public class Program
    {
        static void Main(string[] args)
        {
            /* To get access to the PublicKeyToken of an Assembly you need to execute sn.exe and pass the Assembly path.
           For example, I used this command to retrieve the PublicKeyToken from System.Data assembly
           "C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.6.1 Tools\sn.exe" -T "C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.5.2\System.Data.dll"
           */
            var assembly =
                Assembly.Load("System.Data, version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089");
            var referencedAssemblies = assembly.GetReferencedAssemblies();

            foreach (var reference in referencedAssemblies)
            {
                Console.WriteLine($"Assembly Name {reference.FullName}");
                Console.WriteLine($"Assembly Version {reference.Version}");
            }
        }
    }
}
