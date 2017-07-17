using LearnNET.EntityFramework.Data.Entities;
using System;
using System.Collections.Generic;

namespace LearnNET.EntityFramework.Data.Interfaces
{
    public interface IRepository<T> : IDisposable where T : Base
    {
        T Get(int id);
        IEnumerable<T> GetAll();
        T Insert(T entity);
        T Update(T entity);
        T Delete(T entity);
    }
}
