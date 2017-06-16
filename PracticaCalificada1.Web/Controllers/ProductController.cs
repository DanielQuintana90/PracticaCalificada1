using Microsoft.AspNetCore.Mvc;
using PracticaCalificada1.Models;
using PracticaCalificada1.UnitOfWork;
using PracticaCalificada1.Web.Filter;
using System;

namespace PracticaCalificada1.Web.Controllers
{
    [ExceptionLoggerFilter]
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Listar()
        {
            return View(_unitOfWork.Products.GetAll());
        }

        public IActionResult Agregar(int id)
        {
            return View(_unitOfWork.Products.GetById(id));
        }

        public IActionResult Eliminar(int id)
        {
            return View(_unitOfWork.Products.GetById(id));
        }

        public IActionResult Actualizar(int id)
        {
            return View(_unitOfWork.Products.GetById(id));
        }

        [HttpPost]
        public IActionResult Agregar(Product product)
        {
            _unitOfWork.Products.Insert(product);

            return RedirectToAction("Listar");
        }

        [HttpPost]
        [ActionName("Eliminar")]
        public IActionResult EliminarEntidad(int id)
        { 
            _unitOfWork.Products.Delete(_unitOfWork.Products.GetById(id));

            return RedirectToAction("Listar");
        }

        [HttpPost]
        public IActionResult Actualizar(Product product)
        {
            _unitOfWork.Products.Update(product);

            return RedirectToAction("Listar");
        }

        [Route("Home/Issue")]
        public IActionResult CreateIssue()
        {
            throw new Exception("New error for demostration");
        }

    }
}