using Demo.Business.Base;
using System;
using System.Collections.Generic;

namespace Demo.Business.Interfaces
{
    public interface IRepository<T> where T: BaseEntity
    {
        T GetById(Guid id);
        IEnumerable<T> GetAll();
        T Add(T entity);
        bool Update(T entity);
        bool Delete(Guid id);
    }
}
