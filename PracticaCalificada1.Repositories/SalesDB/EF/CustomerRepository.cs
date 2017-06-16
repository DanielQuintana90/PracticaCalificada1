using Microsoft.EntityFrameworkCore;
using PracticaCalificada1.Models;
using System.Collections.Generic;
using System.Linq;

namespace PracticaCalificada1.Repositories.SalesDB.EF
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(DbContext dbContext):base(dbContext)
        {

        }

        public IEnumerable<Customer> GetByFirstName(string firstName)
        {
            return _dbContext.Set<Customer>().Where(x => x.FirstName == firstName);
        }
    }
}
