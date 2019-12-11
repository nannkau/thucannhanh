using System.Collections.Generic;
using System.Linq;
using ApplicationCore.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories
{
    public class Repository<T> : IRepository<T> where T : class, IAggregateRoot
    {
        private DbContext _context;
        public Repository(DbContext context)
        {
            _context = context;
        }
        protected DbContext Context => _context;
        private IQueryable<T> ApplySpecification(ISpecification<T> spec)
        {
            var query = _context.Set<T>().AsQueryable();
            return SpecificationEvaluator<T>.Evaluate(query, spec);
        }
        public T Add(T entity)
        {
            _context.Add(entity);
            return entity;
        }

        public void AddRange(IEnumerable<T> entities)
        {
            _context.AddRange(entities);
        }

        public int Count(ISpecification<T> spec)
        {
            return ApplySpecification(spec).Count();
        }

        public IEnumerable<T> Find(ISpecification<T> spec)
        {
            return ApplySpecification(spec).ToList();
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetBy(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            _context.Set<T>().RemoveRange(entities);
        }
    }
}