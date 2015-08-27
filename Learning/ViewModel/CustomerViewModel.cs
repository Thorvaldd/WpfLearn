using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Media;
using Learning.BaseBind;
using Learning.Model;

namespace Learning.ViewModel
{
    public class CustomerViewModel:BindableBase
    {
        public CustomerViewModel()
        {
            Customers = new List<Customer>
            {
                new Customer{Id = 1, FirstName = "1", LastName = "2", WorkedHours = DateTime.Now.AddHours(50)},
                new Customer{Id = 2, FirstName = "2", LastName = "2", WorkedHours = DateTime.Now.AddHours(120)}
            };
        }

        public List<Customer> Customers { get; set; }

    }

}
