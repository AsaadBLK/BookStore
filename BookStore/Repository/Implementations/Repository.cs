using BookStore.ModelsHelpers;
using BookStore.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace BookStore.Repository.Implementations
{
    // repositori implementations heritate from irepository
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        //access just in class derived  
        protected readonly DbContext _context;

        private DbSet<TEntity> _dbSet;

        //constuct
        public Repository(DbContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>(); //entity is table represent in db
        }
        public void Add(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            _dbSet.AddRange(entities);
        }

        public TEntity Get(Guid id)
        {
            return _dbSet.Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _dbSet.ToList();
        }

        public void Remove(TEntity entity)
        {
            _dbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            _dbSet.RemoveRange(entities);
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> filter = null, string includeProperties = null, Page page = null)
        {
            IQueryable<TEntity> query = _dbSet;
            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (!String.IsNullOrEmpty(includeProperties))
            {
                // for get other properities of author category
                string[] propertys = includeProperties.Split(",", StringSplitOptions.RemoveEmptyEntries);
                foreach (string property in propertys)
                {
                    query = query.Include(property);
                }
            }
            if (page != null)
            {
                int index = page.pageIndex;
                int size = page.pageSize;
                query = (index > 1) ? query.Skip((index - 1) * size).Take(size) : query.Take(size);
            }
            // "Author,Category"
            return query.ToList();
        }
    }
}