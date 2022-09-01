using Catálogo_de_Empleados_Rosa_Icela_Contreras_Ocampo.Models;
using Catálogo_de_Empleados_Rosa_Icela_Contreras_Ocampo.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Catálogo_de_Empleados_Rosa_Icela_Contreras_Ocampo.Controllers
{
    public class EmployeeController : Controller
    {
        private IEnumerable<SelectListItem> PositionsRosa;

        // GET: Empleado
        public ActionResult Index()
        {
            //var model = new EmployeeViewModel();
            //model.datos = EmployeeService.getAll();
            //return View(model);
            TraerPositions();
            EmployeePositionModel model = new EmployeePositionModel()
            
            {
                ListPositions = PositionsRosa.ToList()
            };
            model.datos = EmployeeService.getAll();
            return View(model);
        }

        private void TraerPositions()
        {
            PositionsRosa = PositionService.getAll().ToList().Select(p => new SelectListItem { Value = p.Id.ToString(), Text = p.Name }); ;
        }

        public ActionResult ToIndex()
        {
            return RedirectToAction("Index");
        }

        public ActionResult Agregar()
        {
            return View();
        }

        /// <summary>
        /// Sirve para mandar llamar el método de agregar un nuevo empleado
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Add(EmployeePositionModel model)
        {
            var employee = new EmployeesRosa()
            {
                CreationDate = DateTime.Now.Date,
                Name = model.Employee.Name,
                LastName = model.Employee.LastName,
                Birthday = model.Employee.Birthday,
                RFC = model.Employee.RFC,
                Email = model.Employee.Email,
                PhoneNumber = model.Employee.PhoneNumber,
                PositionId = model.Employee.PositionId,
                IsDeleted= false
            };
            EmployeeService.Agregar(employee);
            return RedirectToAction("Index");
        }

        //[HttpPost]
        public ActionResult Editar(int id)
        {
            var model = new EmployeePositionModel();
            model.Employee.Name = EmployeeService.Buscar(id).Name;
            model.Employee.LastName = EmployeeService.Buscar(id).LastName;
            model.Employee.Birthday = EmployeeService.Buscar(id).Birthday;
            model.Employee.RFC = EmployeeService.Buscar(id).RFC;
            model.Employee.Email = EmployeeService.Buscar(id).Email;
            model.Employee.PhoneNumber = EmployeeService.Buscar(id).PhoneNumber;
            model.Employee.PositionId = EmployeeService.Buscar(id).PositionId;
            return View(model);
        }


        /// <summary>
        /// Método que manda llamar el servicio Modificar para guardar los cambios de un contacto
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult Actualizar(EmployeePositionModel model)
        {
            //Crea el objeto de contacto
            var employee = new EmployeesRosa()
            {
                Name = model.Employee.Name,
                LastName = model.Employee.LastName,
                Birthday = model.Employee.Birthday,
                RFC = model.Employee.RFC,
                Email = model.Employee.Email,
                PhoneNumber = model.Employee.PhoneNumber,
                PositionId = model.Employee.PositionId
        };
            //Invoca el método modificar
            EmployeeService.Modificar(employee);
            return RedirectToAction("Index");
        }


    }
}