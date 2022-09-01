using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Catálogo_de_Empleados_Rosa_Icela_Contreras_Ocampo.Models
{
    public class PositionViewModel
    {
        public List<PositionsRosa> datos { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
    }
}