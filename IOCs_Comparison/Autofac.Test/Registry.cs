using Common;
using Autofac.Core;

namespace Autofac.Test
{
    static public class Registry
    {
        static public readonly IContainer container;

        static Registry()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<SQLRepository>().As<IRepository>();
            builder.RegisterType<ContactStaffHandler>().AsSelf();
            container = builder.Build();

        }
    }
}
