using Ninject.Modules;
using PhotoFundao.Infra.Repositories;
using PhotoFundao.Domain;
using PhotoFundao.App;
using PhotoFundao.Infra;
using System.Data.Entity;

namespace PhotoFundao.Configuration.Modules
{
    public class MainModule : NinjectModule
    {
        public override void Load()
        {
            Bind<DbContext>().To<Context>();
            Bind<IGenericRepository<Customer>>()
                .To<GenericRepository<Customer>>();
            Bind<CustomerManager>().ToSelf();
        }
    }
}
