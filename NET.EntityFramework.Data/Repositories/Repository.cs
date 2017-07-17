using LearnNET.EntityFramework.Data.Entities;
using LearnNET.EntityFramework.Data.Interfaces;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace LearnNET.EntityFramework.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : Base
    {
        protected readonly Context context;

        public Repository()
        {
            context = new Context();
        }

        public T Delete(T entity)
        {
            context.Entry(entity).State = EntityState.Deleted;
            context.SaveChanges();
            return entity;
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public T Get(int id)
        {
            return context.Set<T>().Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return context.Set<T>().ToList();
        }

        public T Insert(T entity)
        {
            context.Set<T>().Add(entity);
            context.SaveChanges();
            return entity;
        }

        public T Update(T entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
            return entity;
        }
    }
}
