using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Catálogo_de_Empleados_Rosa_Icela_Contreras_Ocampo.Models
{
    public class EmployeeViewModel
    {
        public List<EmployeesRosa> datos { get; set; }
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public string RFC { get; set; }
        public string Email { get; set; } 
        public string PhoneNumber { get; set; }
        public int PositionId { get; set; }
        public bool IsDelete { get; set; }
    }
}