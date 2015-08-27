using System.Collections.Generic;
using Learning.Model;

namespace Learning.ViewModel
{
    public class CustomerViewModel
    {
        public CustomerViewModel()
        {
            Customers = new List<Customer>
            {
                new Customer{Id = 1, FirstName = "1", LastName = "2"},
                new Customer{Id = 2, FirstName = "2", LastName = "2"}
            };
        }

        public List<Customer> Customers { get; set; }
    }
}
