using System.Collections.Generic;

namespace PracticaCalificada1.Repositories
{
    public interface IRepository<T> where T : class
    {
        bool Insert(T entity);
        bool Delete(T entity);
        bool Update(T entity);
        IEnumerable<T> GetAll();
        T GetById(int id);
    }
}
