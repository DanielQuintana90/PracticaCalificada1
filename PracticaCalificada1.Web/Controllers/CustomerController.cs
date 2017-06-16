using Microsoft.AspNetCore.Mvc;
using PracticaCalificada1.Models;
using PracticaCalificada1.UnitOfWork;

namespace PracticaCalificada1.Web.Controllers
{
    public class CustomerController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public CustomerController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Listar()
        {
            return View(_unitOfWork.Customers.GetAll());
        }


        public IActionResult Agregar(int id)
        {
            return View(_unitOfWork.Customers.GetById(id));
        }

        public IActionResult Eliminar(int id)
        {
            return View(_unitOfWork.Customers.GetById(id));
        }

        public IActionResult Actualizar(int id)
        {
            return View(_unitOfWork.Customers.GetById(id));
        }

        [HttpPost]
        public IActionResult Agregar(Customer customer)
        {
            _unitOfWork.Customers.Insert(customer);

            return RedirectToAction("Listar");
        }

        [HttpPost] 
        [ActionName("Eliminar")]
        public IActionResult EliminarEntidad(int id)
        {
            _unitOfWork.Customers.Delete(_unitOfWork.Customers.GetById(id));

            return RedirectToAction("Listar");
        }

        [HttpPost]
        public IActionResult Actualizar(Customer customer)
        {
            _unitOfWork.Customers.Update(customer);

            return RedirectToAction("Listar");
        }
    }
}