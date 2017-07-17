using LearnNET.EntityFramework.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace LearnNET.EntityFramework.Data
{
    public class Context : DbContext
    {
        public Context() : base("name=MyDatabaseConnectionstring")
        {
            Database.SetInitializer(new Initializer());
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Project> Projects { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.HasDefaultSchema("");
        }
    }

    public class Initializer : CreateDatabaseIfNotExists<Context>
    {
        protected override void Seed(Context context)
        {
            var plain = new Customer()
            {
                CreatedDate = DateTime.Now,
                Email = "plainindustrial@outlook.com.br",
                Name = "Plain Industrial ",
                Phone = "38763788"
            };

            var ayan = new Customer()
            {
                CreatedDate = DateTime.Now,
                Email = "ayancars@gmail.com.br",
                Name = "Ayan Auto Cars",
                Phone = "87878877"
            };

            var customers = new List<Customer>() { plain, ayan };

            var projectAyan1 = new Project()
            {
                Customer = ayan,
                Name = "Ayan API"
            };

            var projectAyan2 = new Project()
            {
                Customer = ayan,
                Name = "Ayan MVC Web Site"
            };

            var projectPlain1 = new Project()
            {
                Customer = plain,
                Name = "Ayan WCF Services"
            };

            var projectPlain2 = new Project()
            {
                Customer = plain,
                Name = "Ayan Software Management"
            };

            var projects = new List<Project>() { projectAyan1, projectAyan2, projectPlain1, projectPlain2 };

            context.Customers.AddRange(customers);
            context.Projects.AddRange(projects);
            context.SaveChanges();
        }
    }
}
