using Common;
using Lamar;
namespace Lamar.Test
{
    static public class Registry
    {
        static public readonly Container container;

        static Registry()
        {
            container = new Container(c=>
            {
                c.For<IRepository>().Use<SQLRepository>();
            });

        }
    }
}
