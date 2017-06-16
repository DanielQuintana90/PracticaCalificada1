using Microsoft.EntityFrameworkCore;
using PracticaCalificada1.Models;
using System.Collections.Generic;
using System.Linq;

namespace PracticaCalificada1.Repositories.SalesDB.EF
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(DbContext dbContext) : base(dbContext)
        {

        }

        public IEnumerable<Product> GetByName(string name)
        {
            return _dbContext.Set<Product>().Where(x => x.Name == name);
        }
    }
}
