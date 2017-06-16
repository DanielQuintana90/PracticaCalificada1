using PracticaCalificada1.Models;
using System.Collections.Generic;

namespace PracticaCalificada1.Repositories.SalesDB
{
    public interface IProductRepository : IRepository<Product>
    {
        IEnumerable<Product> GetByName(string name);
    }
}
