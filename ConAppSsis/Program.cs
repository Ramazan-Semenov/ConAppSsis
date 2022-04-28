using System;
using Microsoft.SqlServer.Dts.Runtime;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppSsis
{
    class Program
    {
        static void Main(string[] args)
        {
            string pkgLocation;
            Package pkg;
            Application app;
            DTSExecResult pkgResults;

            pkgLocation =
              @"C:\Users\lenovo\source\repos\Integration Services Project1\Integration Services Project1\Package.dtsx";
            app = new Application();
            pkg = app.LoadPackage(pkgLocation, null);
            pkgResults = pkg.Execute();

            Console.WriteLine(pkgResults.ToString());
            Console.ReadKey();
        }
    }
}
