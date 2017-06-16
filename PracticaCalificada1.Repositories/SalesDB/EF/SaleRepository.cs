using Microsoft.EntityFrameworkCore;
using PracticaCalificada1.Models;

namespace PracticaCalificada1.Repositories.SalesDB.EF
{
    public class SaleRepository : Repository<Sale>, ISaleRepository
    {
        public SaleRepository(DbContext dbContext) : base(dbContext)
        {

        }
    }
}
