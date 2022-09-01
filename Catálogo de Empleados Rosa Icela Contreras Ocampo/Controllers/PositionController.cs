using Catálogo_de_Empleados_Rosa_Icela_Contreras_Ocampo.Models;
using Catálogo_de_Empleados_Rosa_Icela_Contreras_Ocampo.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Catálogo_de_Empleados_Rosa_Icela_Contreras_Ocampo.Controllers
{
    public class PositionController : Controller
    {
        // GET: Position
        public ActionResult Index()
        {
            var model = new PositionViewModel();
            model.datos = PositionService.getAll();
            return View(PositionService.getAll());
        }

    }
}