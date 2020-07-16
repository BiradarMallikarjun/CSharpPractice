using Autofac;
using Library;
using Library.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reflection
{
    public class ContainerConfigure
    {
        public static  IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Logger>().As<ILogger>();
            builder.RegisterType<ApplicationStart>().As<IApplicationStart>();
            builder.RegisterType<BusinessLogic>().As<IBusinessLogic>();
            builder.RegisterType<Delegates>().As<IDelegates>();

            return builder.Build();
        }
    }
}
