using System;
using System.Collections.Generic;
using System.Text;
using Common;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Castle.MicroKernel;
using Castle.Windsor.Installer;


namespace Windsor.Test
{
    public static class Registry
    {
        public static readonly IWindsorContainer container;

        static Registry()
        {
            container = new WindsorContainer();
            container.Register(Component.For<ContactStaffHandler>());
            container.Register(Component.For<IRepository>().ImplementedBy<SQLRepository>());
        }
       
    }

}
