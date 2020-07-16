using Autofac;
using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        static void Main()
        {
            var container = ContainerConfigure.Configure();
            using (var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IApplicationStart>();                
                app.Run();
            }
        }       
       
    }
}
