using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Catálogo_de_Empleados_Rosa_Icela_Contreras_Ocampo.Models
{
    public class EmployeePositionModel
    {
        public EmployeesRosa Employee { get; set; }
        //public EmployeeViewModel EmployeeViewModel { get; set; }
        public List<EmployeesRosa> datos { get; set; }
        public IEnumerable<SelectListItem> ListPositions{ get; set; }
    }
}