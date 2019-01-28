using System;
using System.Collections.Generic;
using System.Text;
using Common;


namespace Unity.Test
{
    static public class Registry
    {
        static public readonly IUnityContainer container;

        static Registry()
        {
            container = new UnityContainer();

            container.RegisterType<IRepository, SQLRepository>();
 
        }
    }
}
