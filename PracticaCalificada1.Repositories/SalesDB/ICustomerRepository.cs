using PracticaCalificada1.Models;
using System.Collections.Generic;

namespace PracticaCalificada1.Repositories.SalesDB
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        IEnumerable<Customer> GetByFirstName(string firstName);
    }
}
