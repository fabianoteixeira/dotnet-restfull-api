using Demo.Business.Base;
using System;

namespace Demo.Business.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }

        public Product(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
        }

        public Product(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
