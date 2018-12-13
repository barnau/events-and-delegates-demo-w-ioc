using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace EventsAndDelegatesPractice.IoC
{
    public class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterInstance<IMediator>(Mediator.GetInstance());
            builder.RegisterType<Printer>().As<IPrinter>();
            builder.RegisterType<Application>().As<IApplication>();


            return builder.Build();
        }
    }
}
