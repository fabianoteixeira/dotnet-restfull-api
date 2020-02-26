using Demo.Business.Base;
using Demo.Business.Interfaces;
using Demo.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo.Data.Repositories
{
    public class BaseRepository<T> : IRepository<T>
        where T : BaseEntity
    {
        private readonly ApplicationDbContext _context;

        public BaseRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public T Add(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public bool Delete(Guid id)
        {
            var entity = GetById(id);
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
            return true;
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().AsEnumerable();
        }

        public T GetById(Guid id)
        {
            return _context.Set<T>().AsNoTracking().First(x => x.Id == id);
        }

        public T Update(T entity)
        {
            _context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return entity;
        }
    }
}
