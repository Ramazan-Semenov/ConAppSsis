using System;
using Microsoft.SqlServer.Dts.Runtime;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppSsis
{
    //dtexec.exe /F "C:\Users\lenovo\source\repos\Integration Services Project1\Integration Services Project1\Package.dtsx"
    class MyEventListener : DefaultEvents
    {
       
        public override bool OnError(DtsObject source, int errorCode, string subComponent,
          string description, string helpFile, int helpContext, string idofInterfaceWithError)
        {
            // Add application-specific diagnostics here.  
            Console.WriteLine("Error in {0}/{1} : {2}", source, subComponent, description);
            return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string pkgLocation;
            Package pkg;
            Application app;
            DTSExecResult pkgResults;
            MyEventListener eventListener = new MyEventListener();
            pkgLocation =
              @"C:\Users\lenovo\source\repos\Integration Services Project1\Integration Services Project1\Package.dtsx";
            app = new Application();
            pkg = app.LoadPackage(pkgLocation, eventListener);
            pkgResults = pkg.Execute();

            Console.WriteLine(pkgResults.ToString());
            Console.ReadKey();
        }
    }
}
