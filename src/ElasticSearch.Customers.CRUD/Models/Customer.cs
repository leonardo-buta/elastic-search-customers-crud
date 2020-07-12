using System;

namespace ElasticSearch.Customers.CRUD.Models
{
    public class Customer
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime BirthDate { get; set; }
        public Address Address { get; set; }
        public bool Active { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
