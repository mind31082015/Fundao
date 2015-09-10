using System;

namespace PhotoFundao.Domain
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BornOn { get; set; }
        public bool Active { get; set; }
    }
}
