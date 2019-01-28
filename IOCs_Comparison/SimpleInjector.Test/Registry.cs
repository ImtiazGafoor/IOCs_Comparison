using System;
using System.Collections.Generic;
using System.Text;
using Common;
using SimpleInjector;

namespace SimpleInjector.Test
{
    static public class Registry
    {
        static public readonly Container container;

        static Registry()
        {
            container = new Container();

            container.Register<IRepository, SQLRepository>();

            //container.Verify();
        }
    }
}
