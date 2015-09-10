using PhotoFundao.Domain;
using System.Data.Entity;

namespace PhotoFundao.Infra
{
    public class Context : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
    }
}
