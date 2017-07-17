using LearnNET.EntityFramework.Data.Entities;
using LearnNET.EntityFramework.Data.Interfaces;
using System.Linq;

namespace LearnNET.EntityFramework.Data.Repositories
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public Customer GetByEmail(Customer customer)
        {
            return context.Customers.FirstOrDefault(e => e.Email.Equals(customer.Email));
        }
    }
}
