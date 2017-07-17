using LearnNET.EntityFramework.Data.Entities;

namespace LearnNET.EntityFramework.Data.Interfaces
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        Customer GetByEmail(Customer customer);
    }
}
