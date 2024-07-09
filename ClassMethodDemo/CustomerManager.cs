using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    public class CustomerManager
    {
        public CustomerManager() { }

        public void AddCustomer(List<Customer>customers, Customer customer)
        {
            customers.Add(customer);
        }

        public void DeleteCustomer(List<Customer>customers, Customer customer)
        {
            customers.Remove(customer);
        }

        public List<Customer> GetAllCustomer(List<Customer> customers)
        {
            return customers;
        }
    }
}
