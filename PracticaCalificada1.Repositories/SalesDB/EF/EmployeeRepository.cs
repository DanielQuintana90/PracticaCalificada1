using Microsoft.EntityFrameworkCore;
using PracticaCalificada1.Models;
using System.Collections.Generic;
using System.Linq;

namespace PracticaCalificada1.Repositories.SalesDB.EF
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(DbContext dbContext) : base(dbContext)
        {

        }

        public IEnumerable<Employee> GetByLastName(string lastName)
        {
            return _dbContext.Set<Employee>().Where(x => x.LastName == lastName);
        }
    }
}
