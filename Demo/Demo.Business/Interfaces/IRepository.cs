using Demo.Business.Base;
using Demo.Business.Entities;
using System;
using System.Collections.Generic;

namespace Demo.Business.Interfaces
{
    public interface IRepository<T> where T: BaseEntity
    {
        T GetById(Guid id);
        IEnumerable<T> GetAll();
        T Add(T entity);
        T Update(T entity);
        bool Delete(Guid id);
    }
}
