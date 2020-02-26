using Demo.Business.DTO;
using Demo.Business.Entities;
using Demo.Business.Interfaces;
using System;
using System.Collections.Generic;

namespace Demo.Business.Services
{
    public class ProductService : IProductService
    {
        private IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public Product Add(ProductDTO entity)
        {
            return _productRepository.Add(new Product(entity.Name));
        }

        public bool Delete(Guid id)
        {
            return _productRepository.Delete(id);
        }

        public IEnumerable<Product> GetAll()
        {
            return _productRepository.GetAll();
        }

        public Product GetById(Guid id)
        {
            return _productRepository.GetById(id);
        }

        public bool Update(ProductDTO entity)
        {
            return _productRepository.Update(new Product(entity.Name));
        }
    }
}
