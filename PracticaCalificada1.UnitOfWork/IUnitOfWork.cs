using PracticaCalificada1.Repositories.SalesDB;

namespace PracticaCalificada1.UnitOfWork
{
    public interface IUnitOfWork
    {
        ICustomerRepository Customers { get; }
        IEmployeeRepository Employees { get; }
        IProductRepository Products { get; }
        ISaleRepository Sales { get; }
    }
}
