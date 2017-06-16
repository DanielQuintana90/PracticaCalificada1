using PracticaCalificada1.Models;
using System.Collections.Generic;

namespace PracticaCalificada1.Repositories.SalesDB
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        IEnumerable<Employee> GetByLastName(string lastName);
    }
}
