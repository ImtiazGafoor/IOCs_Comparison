using Common;
using Ninject.Modules;

namespace Ninject.Test
{
    public class Registry : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IRepository>().To<SQLRepository>();
        }
    }
}
