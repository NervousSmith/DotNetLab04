using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace Zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            HostFactory.Run(configure =>
            {
                configure.Service<MyService>(service =>
               {
                   service.ConstructUsing(s => new MyService());
                   service.WhenStarted(s => s.Start());
                   service.WhenStopped(s => s.Stop());
               });

                configure.RunAsLocalSystem();
                configure.SetServiceName("MyService");
                configure.SetDisplayName("Moja usługa");
                configure.SetDescription("To jest prosta usługa");
            });
        }
    }
}
