using Ninject;
using PhotoFundao.Configuration.Modules;

namespace PhotoFundao.Configuration.Factories
{
    public static class Factory
    {
        private static StandardKernel StandardKernel { get; set; }

        static Factory()
        {
            var module = new MainModule();
            StandardKernel = new StandardKernel(module);
        }

        public static TEntity Get<TEntity>()
        {
            return StandardKernel.Get<TEntity>();
        }

        public static TEntity Get<TEntity>(string mappingName)
        {
            return StandardKernel.Get<TEntity>(mappingName);
        }
    }
}
