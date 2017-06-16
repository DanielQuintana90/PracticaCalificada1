using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace PracticaCalificada1.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly DbContext _dbContext;

        public Repository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool Delete(T entity)
        {
            _dbContext.Remove(entity);

            return _dbContext.SaveChanges() >= 1;
        }

        public IEnumerable<T> GetAll()
        {
            return _dbContext.Set<T>();
        }

        public T GetById(int id)
        {
            return _dbContext.Set<T>().Find(id);
        }

        public bool Insert(T entity)
        {
            _dbContext.Add(entity);

            return _dbContext.SaveChanges() >= 1;
        }

        public bool Update(T entity)
        {
            _dbContext.Update(entity);

            return _dbContext.SaveChanges() >= 1;
        }
    }
}
