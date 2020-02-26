using Demo.Business.DTO;
using Demo.Business.Entities;
using System;
using System.Collections.Generic;

namespace Demo.Business.Interfaces
{
    public interface IProductService
    {
        Product GetById(Guid id);
        IEnumerable<Product> GetAll();
        Product Add(ProductDTO entity);
        bool Update(ProductDTO entity);
        bool Delete(Guid id);
    }
}
