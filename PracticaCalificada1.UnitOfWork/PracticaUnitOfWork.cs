using Microsoft.EntityFrameworkCore;
using PracticaCalificada1.Repositories.SalesDB;
using PracticaCalificada1.Repositories.SalesDB.EF;

namespace PracticaCalificada1.UnitOfWork
{
    public class PracticaUnitOfWork : IUnitOfWork
    {
        public PracticaUnitOfWork(DbContext dbcontext)
        {
            Customers = new CustomerRepository(dbcontext);
            Employees = new EmployeeRepository(dbcontext);
            Products = new ProductRepository(dbcontext);
            Sales = new SaleRepository(dbcontext);
        }

        public ICustomerRepository Customers { get; private set; }
        public IEmployeeRepository Employees { get; private set; }
        public IProductRepository Products { get; private set; }
        public ISaleRepository Sales { get; private set; }
    }
}
