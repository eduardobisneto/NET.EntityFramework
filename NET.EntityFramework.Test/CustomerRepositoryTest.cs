using LearnNET.EntityFramework.Data.Entities;
using LearnNET.EntityFramework.Data.Interfaces;
using LearnNET.EntityFramework.Data.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LearnNET.EntityFramework.Test
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        private readonly ICustomerRepository customerRepository;

        public CustomerRepositoryTest()
        {
            customerRepository = new CustomerRepository();
        }

        [TestMethod]
        public void Get()
        {
            var result = customerRepository.Get(1);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetAll()
        {
            var list = customerRepository.GetAll();

            Assert.IsNotNull(list);
        }

        [TestMethod]
        public void GetAllCount()
        {
            List<Customer> list = customerRepository.GetAll() as List<Customer>;
            Assert.AreNotEqual(0, list.Count);
        }

        [TestMethod]
        public void Insert()
        {
            Customer customer = customerRepository.Insert(new Customer()
            {
                Email = "almirante.colchoes@gmail.com",
                Name = "Almirante Colchões",
                Phone = "+35367652637"
            });

            Assert.AreNotEqual(0, customer.Id);
        }

        [TestMethod]
        public void Update()
        {
            Customer customerToUpdate = customerRepository.Get(1);

            customerToUpdate.Email = "ayancars@ayancars.com.br";

            Customer customer = customerRepository.Update(customerToUpdate);

            Assert.IsNotNull(customer);
        }

        [TestMethod]
        public void Delete()
        {
            Customer customer = customerRepository.Delete(new Customer()
            {
                Id = 3
            });

            Assert.IsNotNull(customer);
        }

        [TestMethod]
        public void GetByEmail()
        {
            Customer customer = customerRepository.GetByEmail(new Customer()
            {
                Email = "plainindustrial@outlook.com.br"
            });

            Assert.IsNotNull(customer);
            Assert.AreNotEqual(0, customer.Id);
        }
    }
}
