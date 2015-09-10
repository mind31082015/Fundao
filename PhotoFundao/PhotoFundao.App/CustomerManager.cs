using PhotoFundao.Domain;
using PhotoFundao.Infra.Repositories;
using System;
using System.Linq;

namespace PhotoFundao.App
{
    public class CustomerManager
    {
        private IGenericRepository<Customer> CustomerRepository { get; set; }

        public CustomerManager(IGenericRepository<Customer> customerRepository)
        {
            CustomerRepository = customerRepository;
        }

        public IQueryable<Customer> GetAllActive()
        {
            return CustomerRepository.GetAll(c => c.Active);
        }

        public IQueryable<Customer> GetAllBorn(DateTime start, DateTime end)
        {
            return CustomerRepository.GetAll(c => c.BornOn >= start && c.BornOn <= end);
        }
    }
}
